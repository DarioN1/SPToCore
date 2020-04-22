using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdResourceStatus
    {
        public MdResourceStatus()
        {
            AnResource = new HashSet<AnResource>();
        }

        public int IdResourceStatus { get; set; }
        public string Code { get; set; }
        public string ResourceStatus { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual ICollection<AnResource> AnResource { get; set; }
    }
}
