using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdMaterialStatus
    {
        public MdMaterialStatus()
        {
            AnMaterial = new HashSet<AnMaterial>();
        }

        public int IdMaterialStatus { get; set; }
        public string Code { get; set; }
        public string MaterialStatus { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual ICollection<AnMaterial> AnMaterial { get; set; }
    }
}
