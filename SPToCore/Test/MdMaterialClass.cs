using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdMaterialClass
    {
        public MdMaterialClass()
        {
            AnMaterial = new HashSet<AnMaterial>();
        }

        public int IdMaterialClass { get; set; }
        public string Code { get; set; }
        public string MaterialClass { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual ICollection<AnMaterial> AnMaterial { get; set; }
    }
}
