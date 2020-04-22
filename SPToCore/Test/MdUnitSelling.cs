using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdUnitSelling
    {
        public MdUnitSelling()
        {
            AnMaterial = new HashSet<AnMaterial>();
            AnMaterialFormat = new HashSet<AnMaterialFormat>();
        }

        public int IdUnitSelling { get; set; }
        public string Code { get; set; }
        public string UnitSelling { get; set; }
        public int? Decimals { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual ICollection<AnMaterial> AnMaterial { get; set; }
        public virtual ICollection<AnMaterialFormat> AnMaterialFormat { get; set; }
    }
}
