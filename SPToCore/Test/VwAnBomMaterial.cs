using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class VwAnBomMaterial
    {
        public int IdBomMaterial { get; set; }
        public int? IdBom { get; set; }
        public string Progressive { get; set; }
        public int? IdMaterial { get; set; }
        public string MaterialCode { get; set; }
        public string Material { get; set; }
        public int? IdUnitSelling { get; set; }
        public string UnitSellingCode { get; set; }
        public string UnitSelling { get; set; }
        public decimal? VQty { get; set; }
        public decimal? VQtyBase { get; set; }
        public decimal? VQtyScrap { get; set; }
        public decimal? VQtyBaseScrap { get; set; }
        public int IdBomComponent { get; set; }
        public string BomCodeComponent { get; set; }
    }
}
