using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdMaterialType
    {
        public MdMaterialType()
        {
            AnMaterial = new HashSet<AnMaterial>();
        }

        public int IdMaterialType { get; set; }
        public string Code { get; set; }
        public string MaterialType { get; set; }
        public decimal? SpecificWeight { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual ICollection<AnMaterial> AnMaterial { get; set; }
    }
}
