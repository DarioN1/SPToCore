using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class VwAnMaterialFormat
    {
        public int IdMaterialFormat { get; set; }
        public int IdMaterial { get; set; }
        public int IdUnitSelling { get; set; }
        public string UnitSellingCode { get; set; }
        public string UnitSelling { get; set; }
        public int? Decimals { get; set; }
        public decimal? VQtyBase { get; set; }
        public decimal? VQtyBox { get; set; }
        public decimal? VQtyMin { get; set; }
        public decimal? VQtyMax { get; set; }
        public decimal? VQtyMulti { get; set; }
        public decimal? VPriceWhosaler { get; set; }
        public decimal? VPriceCustomer { get; set; }
    }
}
