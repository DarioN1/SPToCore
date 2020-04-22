using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class FactJobLine
    {
        public FactJobLine()
        {
            FactJobLineMaterial = new HashSet<FactJobLineMaterial>();
        }

        public int IdJobLine { get; set; }
        public int IdJob { get; set; }
        public string Code { get; set; }
        public string JobLine { get; set; }
        public int? IntOrder { get; set; }

        public virtual FactJobHeader IdJobNavigation { get; set; }
        public virtual ICollection<FactJobLineMaterial> FactJobLineMaterial { get; set; }
    }
}
