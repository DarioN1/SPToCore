using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class FactStockMovementHeader
    {
        public int IdStockMovement { get; set; }
        public string Code { get; set; }
        public int? IdStockMovementType { get; set; }
        public int? IdStockMovementStatus { get; set; }
        public int? IdWarehouseSource { get; set; }
        public int? IdWarehouseDest { get; set; }
        public int? IdCurrency { get; set; }
        public int? IdSupplier { get; set; }
        public int? IdCustomer { get; set; }
        public int? IdJob { get; set; }
        public string PurchaseOrder { get; set; }
        public string SalesOrder { get; set; }
        public decimal? VMovementAmount { get; set; }
        public DateTime? DateStockMovement { get; set; }
        public int? IntDateStockMovement { get; set; }
        public DateTimeOffset? DateLoad { get; set; }
        public int? IntDateLoad { get; set; }
        public bool? IsDeleted { get; set; }
        public int? IdUserLock { get; set; }
        public DateTimeOffset? DateUserLock { get; set; }
        public int? IdUserCreate { get; set; }
        public DateTimeOffset? DateUserCreate { get; set; }
        public int? IdUserLastEdit { get; set; }
        public DateTimeOffset? DateUserLastEdit { get; set; }
    }
}
