using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class VwFactStockMovementDetail
    {
        public int IdStockMovement { get; set; }
        public string Code { get; set; }
        public DateTime? DateStockMovement { get; set; }
        public int? IntDateStockMovement { get; set; }
        public DateTimeOffset? DateLoad { get; set; }
        public int? IntDateLoad { get; set; }
        public int? IdStockMovementType { get; set; }
        public string StockMovementTypeCode { get; set; }
        public string StockMovementType { get; set; }
        public short? Sign { get; set; }
        public int? IdStockMovementStatus { get; set; }
        public string StockMovementStatusCode { get; set; }
        public string StockMovementStatus { get; set; }
        public string WarehouseSourceCode { get; set; }
        public string WarehouseSource { get; set; }
        public int? IdWarehouseDest { get; set; }
        public string WarehouseDestCode { get; set; }
        public string WarehouseDest { get; set; }
        public int? IdUserCreate { get; set; }
        public string Progressive { get; set; }
        public int? IdMaterial { get; set; }
        public string MaterialCode { get; set; }
        public string Material { get; set; }
        public int? IdUnitSelling { get; set; }
        public string UnitSellingCode { get; set; }
        public string UnitSelling { get; set; }
        public int? Decimals { get; set; }
        public decimal? VQty { get; set; }
        public decimal? VAmountUnit { get; set; }
        public decimal? VAmountTot { get; set; }
        public decimal? VQtyBase { get; set; }
        public decimal? VAmountBaseUnit { get; set; }
        public decimal? VAmountBaseTot { get; set; }
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
    }
}
