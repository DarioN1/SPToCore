using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdResourceGroup
    {
        public MdResourceGroup()
        {
            AnPhase = new HashSet<AnPhase>();
            AnResourceGroup = new HashSet<AnResourceGroup>();
        }

        public int IdResourceGroup { get; set; }
        public string Code { get; set; }
        public string ResourceGroup { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual ICollection<AnPhase> AnPhase { get; set; }
        public virtual ICollection<AnResourceGroup> AnResourceGroup { get; set; }
    }
}
