using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class AnWarehouse
    {
        public int IdWarehouse { get; set; }
        public string Code { get; set; }
        public string Warehouse { get; set; }
        public int? IdCustomer { get; set; }
        public int? IdSupplier { get; set; }
    }
}
