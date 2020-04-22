using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class VwAnMaterialWarehouse
    {
        public int IdMaterial { get; set; }
        public int IdWarehouse { get; set; }
        public decimal? VQtyStock { get; set; }
        public string WarehouseCode { get; set; }
        public string Warehouse { get; set; }
        public int? IdCustomer { get; set; }
        public string CustomerCode { get; set; }
        public string Customer { get; set; }
        public int? IdSupplier { get; set; }
        public string SupplierCode { get; set; }
        public string Supplier { get; set; }
    }
}
