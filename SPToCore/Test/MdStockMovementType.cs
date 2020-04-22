using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdStockMovementType
    {
        public int IdStockMovementType { get; set; }
        public string Code { get; set; }
        public string StockMovementType { get; set; }
        public short? Sign { get; set; }
        public int? IdStockMovementReverse { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }
        public bool? PWarehouseSource { get; set; }
        public bool? PWarehouseSourceMandatory { get; set; }
        public bool? PWarehouseDest { get; set; }
        public bool? PWarehouseDestMandatory { get; set; }
        public bool? PCustomer { get; set; }
        public bool? PCustomerMandatory { get; set; }
        public bool? PSupplier { get; set; }
        public bool? PSupplierMandatory { get; set; }
        public bool? PJob { get; set; }
        public bool? PJobMandatory { get; set; }
        public bool? PPurchaseOrder { get; set; }
        public bool? PPurchaseOrderMandatory { get; set; }
        public bool? PSalesOrder { get; set; }
        public bool? PSalesOrderMandatory { get; set; }
    }
}
