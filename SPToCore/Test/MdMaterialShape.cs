using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdMaterialShape
    {
        public MdMaterialShape()
        {
            AnMaterial = new HashSet<AnMaterial>();
        }

        public int IdMaterialShape { get; set; }
        public string Code { get; set; }
        public string MaterialShape { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }
        public decimal? D1 { get; set; }
        public decimal? D2 { get; set; }
        public decimal? D3 { get; set; }
        public int? IdDimensionFormulaUm { get; set; }
        public int? IdFormula { get; set; }
        public decimal? Area { get; set; }
        public int? IdAreaFormulaUm { get; set; }

        public virtual ICollection<AnMaterial> AnMaterial { get; set; }
    }
}
