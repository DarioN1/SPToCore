using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdMaterialSector
    {
        public MdMaterialSector()
        {
            AnMaterial = new HashSet<AnMaterial>();
        }

        public int IdMaterialSector { get; set; }
        public string Code { get; set; }
        public string MaterialSector { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual ICollection<AnMaterial> AnMaterial { get; set; }
    }
}
