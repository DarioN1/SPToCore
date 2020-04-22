using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class AnResourceGroup
    {
        public int IdRow { get; set; }
        public int IdResource { get; set; }
        public int IdResourceGroup { get; set; }

        public virtual MdResourceGroup IdResourceGroupNavigation { get; set; }
        public virtual AnResource IdResourceNavigation { get; set; }
    }
}
