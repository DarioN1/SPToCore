using EMGERP_WebApi.Model;
using Microsoft.EntityFrameworkCore.Scaffolding;
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

/*
 TO DO NEXT: Funziona con una singola SP, testare la totale importazione, ora il debug sta girando su SPCoreContext 
 generato da programma

 I DBSet devono essere creati solo per SP che ritornano risultato ovvero righe con name diverso da stringa vuota

     */

namespace SPToCore
{
    static class Program
    {
        public static string P_ConnectionString = "Data Source=DN1;Initial Catalog=EMGERP;Persist Security Info=True;User ID=EMGERP_User;Password=emgerp;Connection Timeout=360";
        public static string P_NameSpace = "EMGERP_WebApi";
        public static string P_ContextSource = "EMGERPContext";
        public static string P_Schema = "*";
        public static bool P_ExcludeSystemObject = true;
        public static string P_OutPutSolutionFolder = @"Model";
        public static string P_OutPutPhysicalFolder = @"C:\TEMP\SPtoCore";

        public static List<SpException> ExceptionList = new List<SpException>();

        static async System.Threading.Tasks.Task Main(string[] args)
        {

            //using (SPToCoreContext sp = new SPToCoreContext())
            //{

            //    //int prg = 10;
            //    //int? idMat = 0;

            //    //sp.Material_INITIALIZE(1, $"SPTOCORE{prg}", $"SPTOCORE MATERIAL {prg}", 1, 1, ref idMat);

            //    //var res = await sp.Material_GETAsync(1, (int)idMat);

            //    //foreach (var r in res)
            //    //{
            //    //    Console.WriteLine(r.Code);
            //    //    Console.WriteLine(r.Material);
            //    //}

            //    var res2 = await sp.Material_SEARCHAsync(1, null, null, null);
            //    foreach (var m in res2)
            //    {
            //        Console.WriteLine(m.Material);
            //    }

            //}

            //return;



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

            StringBuilder sResultDbSet = new StringBuilder();
            StringBuilder sResultNoKey = new StringBuilder();
            StringBuilder sResultMethods = new StringBuilder();
            StringBuilder sResultClasses = new StringBuilder();

            string template = $@"
using System;
using System.Data;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SPToCore.Test;  
  
namespace {P_NameSpace}.{P_OutPutSolutionFolder}
{{
public partial class SPToCoreContext : {P_ContextSource}
    {{
        [@DBSET]

        public SPToCoreContext()
        {{
        }}

        public SPToCoreContext(DbContextOptions<{P_ContextSource}> options)
            : base(options)
        {{
        }}               

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {{

            // No key
            [@NOKEY]

            //Thanks Valecass!!!
            base.OnModelCreating(modelBuilder);
        }}

        
        [@0]

        [@1]
        
    }}
}}
                ";

            foreach (DataRow r in dt_SpList.Rows) {
                
                _schema = r["ROUTINE_SCHEMA"].ToString();
                _sp = r["ROUTINE_NAME"].ToString();

                dt_SpParam = Get_StoreProcedure_Param(_schema, _sp);
                dt_SpResult = Get_StoreProcedure_Result(_schema, _sp);

                Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH':'mm':'ss")} STEP 2 - {i} / {dt_SpList.Rows.Count} ==> \"{r["ROUTINE_NAME"]}\" (Parameters: {dt_SpParam.Rows.Count}, OutputColumns: {dt_SpResult.Rows.Count}");

                sResultDbSet.AppendLine(SPToCore_GenerateDbSet(_sp, _schema, dt_SpParam, dt_SpResult));
                sResultNoKey.AppendLine(SPToCore_GenerateNoKey(_sp, _schema, dt_SpParam, dt_SpResult));
                sResultMethods.AppendLine(SPToCore_GenerateMethod(_sp,_schema, dt_SpParam, dt_SpResult));
                sResultClasses.AppendLine(SPToCore_GenerateResult(_sp,_schema, dt_SpResult));

                i++;
            }

            template = template.Replace("[@DBSET]", sResultDbSet.ToString());
            template = template.Replace("[@NOKEY]", sResultNoKey.ToString());
            template = template.Replace("[@0]", sResultMethods.ToString());
            template = template.Replace("[@1]", sResultClasses.ToString());

            File.WriteAllText(Path.Combine(P_OutPutPhysicalFolder, "SPToCoreContext.cs"), template);

            Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH':'mm':'ss")} FINISH");

            if (ExceptionList.Count > 0) {
                Console.WriteLine($"{DateTime.Now.ToString("yyyy-MM-dd HH':'mm':'ss")} EXCEPTION FOUND! Please check SPToCore_log.txt");
                WriteException();
            }
            
            
        }

        private static string SPToCore_GenerateDbSet(string _sp, string _schema, DataTable _dtParam, DataTable _dtResult)
        {
            if (_dtResult.Rows.Count == 0)
                return "";

            if (_dtResult.Select("name <> ''").Length == 0)
                return "";

            return $@"private DbSet<{_sp}Result> {_sp} {{ get; set; }}";
        }

        private static string SPToCore_GenerateNoKey(string _sp, string _schema, DataTable _dtParam, DataTable _dtResult)
        {
            return $@"modelBuilder.Query<{_sp}Result>().HasNoKey();";
        }

        private static string SPToCore_GenerateMethod(string _sp,string _schema, DataTable _dtParam, DataTable _dtResult)
        {
            if (_sp == "Material_SEARCH") {

                int pippo = 0;
            }

            string template = $@"                    
                        public [@H0] ([@H1])  
                        {{
                            [@B0]

                            try{{
                                [@B1]

                                [@B2]

                                [@B3]
                                [@B4]
                            }}
                            catch(Exception ex){{
                                throw(ex);
                            }}

                            [@F0]
                        }}  
            ";

            StringBuilder sbH1 = new StringBuilder();
            StringBuilder sbB1 = new StringBuilder();

            string methodReturnType;
            string outputResult;
            string name;
            string type;
            bool isNullable;
            bool isOutput;
            int i;

            //[@H0] ReturnType Definition
            if (_dtResult.Rows.Count == 0)
            {
                //if has no result, its a void ( like crud operations )
                methodReturnType = $"void {_sp}";             
            }
            else
            {
                methodReturnType = $"async Task<List<{_sp}Result>> {_sp}Async";                
            }

            //[@B0] Result declaration
            if (_dtResult.Rows.Count == 0)
            {
                outputResult = "";
            }
            else
            {                
                outputResult = $@"// Initialize Result.  
            List<{_sp}Result> lst = new List<{_sp}Result>();";                
            }

            //[@H1] method Parameters
            foreach (DataRow r in _dtParam.Rows)
            {
                name = r["Parameter_name"].ToString().Replace("@", "");
                type = r["Type"].ToString();
                isNullable = (bool)r["is_nullable"];
                isOutput = (bool)r["is_Output"];

                sbH1.Append($"{(isOutput ? "ref " : "")}{SP_GetType(type, isNullable)} {name}, ");                
            }
            string methodParameters = sbH1.ToString();
            if (methodParameters.Length > 0)
                methodParameters = methodParameters.Remove(methodParameters.Length - 2, 2);

            //[@B1] SP Parameters
            if (_dtParam.Rows.Count > 0) { 
                foreach (DataRow r in _dtParam.Rows)
                {
                    name = r["Parameter_name"].ToString().Replace("@", "");
                    type = r["Type"].ToString();
                    isNullable = (bool)r["is_nullable"];
                    isOutput = (bool)r["is_Output"];

                    sbB1.AppendLine($@"SqlParameter p_{name} = new SqlParameter(""@{name}"", {name} ?? (object)DBNull.Value);");
                }
            }

            //[@B2] SP CALL
            string processing = $@"// Processing.  
                string sqlQuery = $@""EXEC [{_schema}].[{_sp}] {Environment.NewLine} [@PARAMS]"";";

            StringBuilder sbSpParam = new StringBuilder();
            foreach (DataRow r in _dtParam.Rows)
            {
                name = r["Parameter_name"].ToString().Replace("@", "");
                type = r["Type"].ToString();
                isNullable = (bool)r["is_nullable"];
                isOutput = (bool)r["is_Output"];

                sbSpParam.AppendLine($"@{name} {(isOutput ? " OUTPUT" : "")}, ");                
            }
            string p = "";
            if (sbSpParam.Length > 0)
                p = ReplaceLastOccurrence(sbSpParam.ToString(), ", ", "");

            processing = processing.Replace("[@PARAMS]", p);

            //[@B3] OutputParams
            string output3 = "";
            string output4 = "";
            i = 0;

            StringBuilder sbOutParam = new StringBuilder();
            if(_dtResult.Rows.Count > 0){
                output3 = $"lst = await this.{_sp}.FromSqlRaw(sqlQuery[@PARAMS]).ToListAsync();";

                StringBuilder sbOutP = new StringBuilder();
                if (_dtParam.Rows.Count > 0)
                {
                    foreach (DataRow r in _dtParam.Rows)
                    {
                        name = r["Parameter_name"].ToString().Replace("@", "");
                        type = r["Type"].ToString();
                        isNullable = (bool)r["is_nullable"];
                        isOutput = (bool)r["is_Output"];

                        sbOutP.Append($"p_{name}, ");
                    }
                    string tmp = sbOutP.ToString();
                    if (tmp.Length > 0)
                        tmp = tmp.Remove(tmp.Length - 2, 2);

                    output3 = output3.Replace($"[@PARAMS]", $", {tmp}");
                }
                else
                {
                    output3 = output3.Replace("[@PARAMS]", "");
                }
            }
            if (_dtParam.Rows.Count > 0)
            {
                foreach (DataRow r in _dtParam.Rows)
                {
                    name = r["Parameter_name"].ToString().Replace("@", "");
                    type = r["Type"].ToString();
                    isNullable = (bool)r["is_nullable"];
                    isOutput = (bool)r["is_Output"];

                    if (isOutput)
                    {
                        sbOutParam.AppendLine($"{name} = ({SP_GetType(type, isNullable)})p_{name}.Value;");
                        
                        i++;
                    }
                }
                output4 = sbOutParam.ToString();
            }
            

            //[@F0] Return List
            string retList = "";
            if (_dtResult.Rows.Count > 0)
            {
                retList = $"return lst;";
            }


            template = template.Replace("[@H0]", methodReturnType);
            template = template.Replace("[@H1]", methodParameters);

            template = template.Replace("[@B0]", outputResult);
            template = template.Replace("[@B1]", sbB1.ToString());
            template = template.Replace("[@B2]", processing);
            template = template.Replace("[@B3]", output3);
            template = template.Replace("[@B4]", output4);

            template = template.Replace("[@F0]", retList);



            return template;
        }

        private static string SPToCore_GenerateResult(string _sp,string _schema, DataTable _dt)
        {
            
            if (_sp == "Material_GET") {
                int i = 0;
            }
            

            string template = $@"                    
                        public class {_sp}Result  
                        {{
                            [@0]
                        }}  
            ";

            StringBuilder sb = new StringBuilder();

            string name = "";
            string type = "";
            bool isNullable;

            foreach (DataRow r in _dt.Rows) {

                name = r["name"].ToString();
                if (name != "")
                {
                    type = r["system_type_name"].ToString();
                    isNullable = (bool)r["is_nullable"];

                    sb.AppendLine($"public {SP_GetType(type, isNullable)} {name} {{get; set;}}");
                }
            }

            return template.Replace("[@0]", sb.ToString());            
        }

        private static string SP_GetType(string type,bool isNullable)
        {
            
            type = type.ToLower().Trim();

            if (type == "int")
                return "int" + (isNullable ? "?" : "");
            else if (type == "smallint")
                return "int" + (isNullable ? "?" : "");            
            else if (type.IndexOf("decimal") > -1)
                return "decimal" + (isNullable ? "?" : "");
            else if (type.IndexOf("nvarchar") > -1)
                return "string";
            else if (type.IndexOf("varchar") > -1)
                return "string";
            else if (type.IndexOf("datetimeoffset") > -1)
                return "DateTimeOffset" + (isNullable ? "?" : "");
            else if (type.IndexOf("datetime") > -1)
                return "DateTime" + (isNullable ? "?" : "");
            else if (type.IndexOf("smalldatetime") > -1)
                return "DateTime" + (isNullable ? "?" : "");
            else if (type == "decimal")
                return "decimal" + (isNullable ? "?" : "");
            else if (type == "bit")
                return "bool" + (isNullable ? "?" : "");
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
                                    //"AND ROUTINE_NAME = 'Material_SEARCH'" +
                                    " ORDER BY ROUTINE_NAME";

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

        public static string ReplaceLastOccurrence(string source, string find, string replace)
        {
            int place = source.LastIndexOf(find);
            return source.Remove(place, find.Length).Insert(place, replace);
        }

    }
}
