using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class VwAnBomPhaseMaterial
    {
        public int IdBomPhaseMaterial { get; set; }
        public int? IdBom { get; set; }
        public int? IdBomPhase { get; set; }
        public int? IdBomMaterial { get; set; }
        public string ProgressivePhase { get; set; }
        public string ProgressiveMaterial { get; set; }
        public string BomCode { get; set; }
        public string Bom { get; set; }
        public int IdMaterial { get; set; }
        public string MaterialCode { get; set; }
        public string Material { get; set; }
        public int? IdMaterialClass { get; set; }
        public string MaterialClassCode { get; set; }
        public string MaterialClass { get; set; }
        public int IdUnitSelling { get; set; }
        public string UnitSellingCode { get; set; }
        public string UnitSelling { get; set; }
        public int IdPhase { get; set; }
        public string PhaseCode { get; set; }
        public string Phase { get; set; }
    }
}
