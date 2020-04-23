using SPToCore.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;

namespace SPToCore
{
    static class Program
    {
        public static string P_ConnectionString = "Data Source=DN1;Initial Catalog=EMGERP;Persist Security Info=True;User ID=EMGERP_User;Password=emgerp;Connection Timeout=360";
        public static string P_NameSpace = "EMGERP_WebApi";
        public static string P_Schema = "*";
        public static bool P_ExcludeSystemObject = true;
        public static string P_OutPutSolutionFolder = @"Model";
        public static string P_OutPutPhysicalFolder = @"C:\TEMP\SPtoCore";

        public static List<SpException> ExceptionList = new List<SpException>();

        static void Main(string[] args)
        {
            var dt_SpList = new DataTable();
            var dt_SpParam = new DataTable();
            var dt_SpResult = new DataTable();

            Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH':'mm':'ss")} STEP 1 - GET STORED PROCEDURE LIST");                       
            
            dt_SpList = Get_StoreProcedure_List();

            Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH':'mm':'ss")} STEP 2 - PROCESS STORED PROCEDURE");
            Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH':'mm':'ss")} STEP 2 - Total Stored Procedure: {dt_SpList.Rows.Count}");

            int i = 1;
            string _schema = "";
            string _sp = "";

            string fileName = "";
            string fileFolder = "";
            string fileContent = "";

            StringBuilder sResultMethods = new StringBuilder();
            StringBuilder sResultClasses = new StringBuilder();

            string template = $@"
                                using System;  
                                using System.Collections.Generic;  
                                using System.Linq;  
                                using System.Threading.Tasks;  
  
                                namespace {P_NameSpace}.{P_OutPutSolutionFolder}
                                {{
                                #Region Methods
                                [@0]
                                #EndRegion
                                #Region Results
                                [@1]
                                #EndRegion
                                }}
                ";

            foreach (DataRow r in dt_SpList.Rows) {
                
                _schema = r["ROUTINE_SCHEMA"].ToString();
                _sp = r["ROUTINE_NAME"].ToString();

                dt_SpParam = Get_StoreProcedure_Param(_schema, _sp);
                dt_SpResult = Get_StoreProcedure_Result(_schema, _sp);

                Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH':'mm':'ss")} STEP 2 - {i} / {dt_SpList.Rows.Count} ==> \"{r["ROUTINE_NAME"]}\" (Parameters: {dt_SpParam.Rows.Count}, OutputColumns: {dt_SpResult.Rows.Count}");

                sResultMethods.AppendLine(SPToCore_GenerateMethod(_sp, dt_SpParam));
                sResultClasses.AppendLine(SPToCore_GenerateResult(_sp, dt_SpResult));

                i++;
            }

            template = template.Replace("[@0]", sResultMethods.ToString());
            template = template.Replace("[@1]", sResultClasses.ToString());

            File.WriteAllText(Path.Combine(P_OutPutPhysicalFolder, "SPToCoreContext.cs"), template);

            Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH':'mm':'ss")} FINISH");

            if (ExceptionList.Count > 0) {
                Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH':'mm':'ss")} EXCEPTION FOUND! Please check SPToCore_log.txt");
                WriteException();
            }
            
            
        }

        private static string SPToCore_GenerateMethod(string _sp, DataTable _dt)
        {
            string template = $@"                    
                        public object {_sp}([@0])  
                        {{
                            return null;
                        }}  
            ";

            StringBuilder sb = new StringBuilder();

            string name = "";
            string type = "";
            string isNullable = "";
            string isOutput = "";

            foreach (DataRow r in _dt.Rows)
            {

                name = type = r["Parameter_name"].ToString().Replace("@","");
                type = r["Type"].ToString();
                isNullable = r["is_Output"].ToString();
                isOutput = r["is_nullable"].ToString();

                sb.Append($"{(isOutput == "1" ? "ref " : "")}{SP_GetType(type, isNullable)} {name}, ");
            }
            string res = sb.ToString();
            if (res.Length > 0)
                res = res.Remove(res.Length - 2, 2);


            return template.Replace("[@0]",res);
        }

        private static string SPToCore_GenerateResult(string _sp, DataTable _dt)
        {
            string template = $@"                    
                        public class {_sp}Result  
                        {{
                            [@0]
                        }}  
            ";

            StringBuilder sb = new StringBuilder();

            string name = "";
            string type = "";
            string isNullable = "";

            foreach (DataRow r in _dt.Rows) {

                name = type = r["name"].ToString();
                type = r["system_type_name"].ToString();
                isNullable = r["system_type_name"].ToString();

                sb.AppendLine($"public {SP_GetType(type,isNullable)} {name} {{get; set;}}");
            }

            return template.Replace("[@0]", sb.ToString());            
        }

        private static string SP_GetType(string type,string isNullable)
        {
            type = type.ToLower().Trim();

            if (type == "int")
                return "int" + (isNullable == "1" ? "?" : "");
            else if (type == "decimal")
                return "decimal" + (isNullable == "1" ? "?" : "");
            else if (type.IndexOf("nvarchar") > -1)
                return "string";
            else if (type.IndexOf("varchar") > -1)
                return "string";
            else if (type.IndexOf("datetimeoffset") > -1)
                return "DateTimeOffset" + (isNullable == "1" ? "?" : "");
            else if (type.IndexOf("datetime") > -1)
                return "DateTime" + (isNullable == "1" ? "?" : "");
            else if (type.IndexOf("smalldatetime") > -1)
                return "DateTime" + (isNullable == "1" ? "?" : "");
            else if (type == "decimal")
                return "decimal" + (isNullable == "1" ? "?" : "");
            else if (type == "bit")
                return "boolean" + (isNullable == "1" ? "?" : "");
            else
                return "WTF?!";                        

        }

        private static DataTable Get_StoreProcedure_List()
        {
            DataTable dtResult = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(P_ConnectionString))
                {
                    string sql = $@"
                                SELECT * 
                                  FROM INFORMATION_SCHEMA.ROUTINES
                                 WHERE ROUTINE_TYPE = 'PROCEDURE' "
                                          + (P_ExcludeSystemObject ? " AND LEFT(ROUTINE_NAME, 3) NOT IN ('sp_', 'xp_', 'ms_')" : "")
                                          + (P_Schema != "*" ? $" AND ROUTINE_SCHEMA = '{P_Schema}'" : "") +

                                    "ORDER BY ROUTINE_NAME";

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand(sql, connection);
                    adapter.Fill(dtResult);

                }

                return dtResult;
            }
            catch (Exception e) {

                ExceptionList.Add(new SpException() { Method = "Get_StoreProcedure_List", Message = e.Message });

                return dtResult;
            }
        }

        private static DataTable Get_StoreProcedure_Param(string schema, string sp)
        {
            DataTable dtResult = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(P_ConnectionString))
                {
                    string sql = $@"
                                SELECT  
                                   'Parameter_name' = name,  
                                   'Type'   = type_name(user_type_id),  
                                   'Length'   = max_length,  
                                   'Prec'   = case when type_name(system_type_id) = 'uniqueidentifier' 
                                              then precision  
                                              else OdbcPrec(system_type_id, max_length, precision) end,  
                                   'Scale'   = OdbcScale(system_type_id, scale),  
                                   'Param_order'  = parameter_id,  
                                   'Collation'   = convert(sysname, 
                                                   case when system_type_id in (35, 99, 167, 175, 231, 239)  
                                                   then ServerProperty('collation') end),
                                  is_Output,
	                              is_nullable
                                  from sys.parameters where object_id = object_id('{schema}.{sp}')
                                  ORDER BY parameter_id
                                ";

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand(sql, connection);
                    adapter.Fill(dtResult);
                }

                return dtResult;
            }
            catch (Exception e) {

                ExceptionList.Add(new SpException() { Method = "Get_StoreProcedure_Param",FullName = $"{schema}.{sp}",Schema = schema, StoreProcedure = sp, Message = e.Message });

                return dtResult;
            }
        }

        private static DataTable Get_StoreProcedure_Result(string schema, string sp)
        {
            DataTable dtResult = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection(P_ConnectionString))
                {
                    string sql = $@"exec sp_describe_first_result_set N'{schema}.{sp}'";

                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = new SqlCommand(sql, connection);
                    adapter.Fill(dtResult);
                }

                return dtResult;
            }
            catch (Exception e) {

                ExceptionList.Add(new SpException() { Method = "Get_StoreProcedure_Result", FullName = $"{schema}.{sp}", Schema = schema, StoreProcedure = sp, Message = e.Message });

                return dtResult;
            }
        }

        private static void WriteException() {
            StringBuilder sb = new StringBuilder();

            int i = 1;
            try{
                foreach (var e in ExceptionList) {
                    sb.AppendLine($"{DateTime.Now.ToString("yyyy-MM-dd HH':'mm':'ss")} - EXCEPTION {i} / {ExceptionList.Count}: {e.StoreProcedure} - {e.Message}");
                    i++;
                }
                File.WriteAllText(Path.Combine(P_OutPutPhysicalFolder, "spToCore_log.txt"),sb.ToString());
            }
            catch (Exception e) {
                Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH':'mm':'ss")} ERROR!!! --> {e.Message}");
            }
        }

        public static string FirstCharToUpper(this string input) =>
        input switch
        {
            null => throw new ArgumentNullException(nameof(input)),
            "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
            _ => input.First().ToString().ToUpper() + input.Substring(1)
        };

    }
}
