namespace SPToCore.Model
{
    public class SpResultElement
    {
        public string? Name { get; set; }
        public string? Order { get; set; }
        public bool isNullable { get; set; }
        public string? Type { get; set; }
        public string? Length { get; set; }
        public string? Precision { get; set; }
        public string? Scale { get; set; }
        public string? Collation { get; set; }

        public string? sql_Name { get; set; }
        public string? sql_Order { get; set; }
        public string? sql_isNullable { get; set; }
        public string? sql_Type { get; set; }
        public string? sql_Length { get; set; }
        public string? sql_Precision { get; set; }
        public string? sql_Scale { get; set; }        
        public string? sql_Collation { get; set; }


    }
}
