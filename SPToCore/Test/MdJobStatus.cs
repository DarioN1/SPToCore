using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdJobStatus
    {
        public MdJobStatus()
        {
            FactJobHeader = new HashSet<FactJobHeader>();
        }

        public int IdJobStatus { get; set; }
        public string Code { get; set; }
        public string JobStatus { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual ICollection<FactJobHeader> FactJobHeader { get; set; }
    }
}
