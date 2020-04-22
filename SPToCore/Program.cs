using SPToCore.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SPToCore
{
    static class Program
    {
        public static string P_ConnectionString = "Data Source=DN1;Initial Catalog=EMGERP;Persist Security Info=True;User ID=EMGERP_User;Password=emgerp;Connection Timeout=360";
        public static string P_NameSpace = "EMGERP_WebApi";
        public static string P_Schema = "*";
        public static bool P_ExcludeSystemObject = true;
        public static string P_OutPutFolder = "";

        public static List<SpException> ExceptionList = new List<SpException>();

        static void Main(string[] args)
        {
            var dt_SpList = new DataTable();
            var dt_SpParam = new DataTable();
            var dt_SpResult = new DataTable();

            Console.WriteLine($"{DateTime.Today.ToString("yyyy-MM-dd HH':'mm':'ss")} STEP 1 - GET STORED PROCEDURE LIST");                       
            
            dt_SpList = Get_StoreProcedure_List();

            Console.WriteLine($"{DateTime.Today.ToString("yyyy-MM-dd HH':'mm':'ss")} STEP 2 - PROCESS STORED PROCEDURE");
            Console.WriteLine($"{DateTime.Today.ToString("yyyy-MM-dd HH':'mm':'ss")} STEP 2 - Total Stored Procedure: {dt_SpList.Rows.Count}");

            int i = 1;
            string _schema = "";
            string _sp = "";

            string fileName = "";
            string fileFolder = "";
            string fileContent = "";

            foreach (DataRow r in dt_SpList.Rows) {
                
                _schema = r["ROUTINE_SCHEMA"].ToString();
                _sp = r["ROUTINE_NAME"].ToString();

                dt_SpParam = Get_StoreProcedure_Param(_schema, _sp);
                dt_SpResult = Get_StoreProcedure_Result(_schema, _sp);

                Console.WriteLine($"{DateTime.Today.ToString("yyyy-MM-dd HH':'mm':'ss")} STEP 2 - {i} / {dt_SpList.Rows.Count} ==> \"{r["ROUTINE_NAME"]}\" (Parameters: {dt_SpParam.Rows.Count}, OutputColumns: {dt_SpResult.Rows.Count}");

                fileName = $"{FirstCharToUpper(_sp)}Result.cs";

                //fileFolder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"Output");

                //File.WriteAllText(${fileFolder}fileName, "");

                i++;
            }

            Console.WriteLine($"{DateTime.Today.ToString("yyyy-MM-dd HH':'mm':'ss")} STEP 3 - PRINTING EXCEPTIONS");
            Console.WriteLine($"{DateTime.Today.ToString("yyyy-MM-dd HH':'mm':'ss")} STEP 3 - Total Exceptions: {ExceptionList.Count}");

            i = 1;            
            foreach (var e in ExceptionList)
            {
                Console.WriteLine($"{DateTime.Today.ToString("yyyy-MM-dd HH':'mm':'ss")} STEP 3 - EXCEPTION {i} / {ExceptionList.Count}: {e.StoreProcedure} - {e.Message}");
                i++;
            }
            
            

            Console.WriteLine($"{DateTime.Today.ToString("yyyy-MM-dd HH':'mm':'ss")} FINISH");
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
                                                   then ServerProperty('collation') end)  
                                  from sys.parameters where object_id = object_id('{schema}.{sp}')
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


        public static string FirstCharToUpper(this string input) =>
        input switch
        {
            null => throw new ArgumentNullException(nameof(input)),
            "" => throw new ArgumentException($"{nameof(input)} cannot be empty", nameof(input)),
            _ => input.First().ToString().ToUpper() + input.Substring(1)
        };

    }
}
