using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdSalesArea
    {
        public int IdSalesArea { get; set; }
        public string Code { get; set; }
        public string SalesArea { get; set; }
        public string Description { get; set; }
        public bool? IsEnabled { get; set; }
        public int? IntOrder { get; set; }
        public string DocSignature { get; set; }
    }
}
