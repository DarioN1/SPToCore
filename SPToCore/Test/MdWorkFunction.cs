using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdWorkFunction
    {
        public MdWorkFunction()
        {
            AnCustomerContact = new HashSet<AnCustomerContact>();
            AnSupplierContact = new HashSet<AnSupplierContact>();
        }

        public int IdWorkFunction { get; set; }
        public string Code { get; set; }
        public string WorkFunction { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual ICollection<AnCustomerContact> AnCustomerContact { get; set; }
        public virtual ICollection<AnSupplierContact> AnSupplierContact { get; set; }
    }
}
