using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdPhaseType
    {
        public MdPhaseType()
        {
            AnPhase = new HashSet<AnPhase>();
        }

        public int IdPhaseType { get; set; }
        public string Code { get; set; }
        public string PhaseType { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual ICollection<AnPhase> AnPhase { get; set; }
    }
}
