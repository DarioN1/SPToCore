using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdPhaseCalculation
    {
        public MdPhaseCalculation()
        {
            AnPhase = new HashSet<AnPhase>();
        }

        public int IdPhaseCalculation { get; set; }
        public string Code { get; set; }
        public string PhaseCalculation { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual ICollection<AnPhase> AnPhase { get; set; }
    }
}
