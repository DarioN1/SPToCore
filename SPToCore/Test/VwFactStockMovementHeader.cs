using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class VwFactStockMovementHeader
    {
        public int IdStockMovement { get; set; }
        public string Code { get; set; }
        public int? IdStockMovementType { get; set; }
        public string StockMovementTypeCode { get; set; }
        public string StockMovementType { get; set; }
        public int? IdStockMovementStatus { get; set; }
        public string StockMovementStatusCode { get; set; }
        public string StockMovementStatus { get; set; }
        public int? IdWarehouseSource { get; set; }
        public string WarehouseSourceCode { get; set; }
        public string WarehouseSource { get; set; }
        public int? IdWarehouseDest { get; set; }
        public string WarehouseDestCode { get; set; }
        public string WarehouseDest { get; set; }
        public int? IdCurrency { get; set; }
        public string CurrencyCode { get; set; }
        public int? IdSupplier { get; set; }
        public string SupplierCode { get; set; }
        public string Supplier { get; set; }
        public int? IdCustomer { get; set; }
        public string CustomerCode { get; set; }
        public string Customer { get; set; }
        public int? IdJob { get; set; }
        public string JobCode { get; set; }
        public string Job { get; set; }
        public string PurchaseOrder { get; set; }
        public string SalesOrder { get; set; }
        public decimal? VMovementAmount { get; set; }
        public DateTime? DateStockMovement { get; set; }
        public int? IntDateStockMovement { get; set; }
        public DateTimeOffset? DateLoad { get; set; }
        public int? IntDateLoad { get; set; }
        public bool? IsDeleted { get; set; }
        public int? IdUserLock { get; set; }
        public string UserLock { get; set; }
        public DateTimeOffset? DateUserLock { get; set; }
        public int? IdUserCreate { get; set; }
        public string UserCreate { get; set; }
        public DateTimeOffset? DateUserCreate { get; set; }
        public int? IdUserLastEdit { get; set; }
        public string UserLastEdit { get; set; }
        public DateTimeOffset? DateUserLastEdit { get; set; }
    }
}
