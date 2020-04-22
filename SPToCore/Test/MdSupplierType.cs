using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdSupplierType
    {
        public MdSupplierType()
        {
            AnSupplierType = new HashSet<AnSupplierType>();
        }

        public int IdSupplierType { get; set; }
        public string Code { get; set; }
        public string SupplierType { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual ICollection<AnSupplierType> AnSupplierType { get; set; }
    }
}
