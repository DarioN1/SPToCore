using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdJobType
    {
        public MdJobType()
        {
            FactJobHeader = new HashSet<FactJobHeader>();
        }

        public int IdJobType { get; set; }
        public string Code { get; set; }
        public string JobType { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual ICollection<FactJobHeader> FactJobHeader { get; set; }
    }
}
