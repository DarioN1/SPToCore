using System.Data;

namespace SPToCore.Model
{
    public class SpParam
    {
        public string? Param { get; set; }
        public string? Type { get; set; }
        public string? Length { get; set; }
        public string? Precision { get; set; }
        public string? Scale { get; set; }
        public string? Order { get; set; }
        public bool isOutput { get; set; }
        public bool isNullable { get; set; }        
        public string? Collation { get; set; }
        public string DbType { get; set; }

        public string? sql_Param { get; set; }
        public string? sql_Type { get; set; }
        public string? sql_Length { get; set; }
        public string? sql_Prec { get; set; }
        public string? sql_Scale { get; set; }
        public string? sql_Order { get; set; }
        public string? sql_isOutput { get; set; }
        public string? sql_isNullable { get; set; }
        public string? sql_Collation { get; set; }
        
    }
}
