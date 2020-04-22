using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdEntityType
    {
        public MdEntityType()
        {
            FactDocument = new HashSet<FactDocument>();
        }

        public int IdEntityType { get; set; }
        public string Code { get; set; }
        public string EntityType { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual ICollection<FactDocument> FactDocument { get; set; }
    }
}
