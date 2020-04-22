using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class FactStockMovementDetail
    {
        public int IdStockMovementDetail { get; set; }
        public int? IdStockMovement { get; set; }
        public string Progressive { get; set; }
        public int? IdMaterial { get; set; }
        public int? IdUnitSelling { get; set; }
        public decimal? VQty { get; set; }
        public decimal? VAmountUnit { get; set; }
        public decimal? VAmountTot { get; set; }
        public decimal? VQtyBase { get; set; }
        public decimal? VAmountBaseUnit { get; set; }
        public decimal? VAmountBaseTot { get; set; }
    }
}
