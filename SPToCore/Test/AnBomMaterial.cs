using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class AnBomMaterial
    {
        public int IdBomMaterial { get; set; }
        public int? IdBom { get; set; }
        public string Progressive { get; set; }
        public int? IdMaterial { get; set; }
        public int? IdUnitSelling { get; set; }
        public decimal? VQty { get; set; }
        public decimal? VQtyBase { get; set; }
        public decimal? VQtyScrap { get; set; }
        public decimal? VQtyBaseScrap { get; set; }

        public virtual AnBom IdBomNavigation { get; set; }
        public virtual AnMaterial IdMaterialNavigation { get; set; }
    }
}
