using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class AnSupplierType
    {
        public int IdSupplier { get; set; }
        public int IdSupplierType { get; set; }

        public virtual AnSupplier IdSupplierNavigation { get; set; }
        public virtual MdSupplierType IdSupplierTypeNavigation { get; set; }
    }
}
