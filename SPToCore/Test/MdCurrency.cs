using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdCurrency
    {
        public MdCurrency()
        {
            AnPhase = new HashSet<AnPhase>();
        }

        public int IdCurrency { get; set; }
        public string Code { get; set; }
        public string Currency { get; set; }
        public int? Dec { get; set; }
        public string Symbol { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual ICollection<AnPhase> AnPhase { get; set; }
    }
}
