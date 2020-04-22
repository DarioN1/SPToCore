using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdResourceType
    {
        public MdResourceType()
        {
            AnResource = new HashSet<AnResource>();
        }

        public int IdResourceType { get; set; }
        public string Code { get; set; }
        public string ResourceType { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual ICollection<AnResource> AnResource { get; set; }
    }
}
