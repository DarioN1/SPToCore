using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdPaymentType
    {
        public MdPaymentType()
        {
            AnCustomer = new HashSet<AnCustomer>();
            AnSupplier = new HashSet<AnSupplier>();
        }

        public int IdPaymentType { get; set; }
        public string Code { get; set; }
        public string PaymentType { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }

        public virtual ICollection<AnCustomer> AnCustomer { get; set; }
        public virtual ICollection<AnSupplier> AnSupplier { get; set; }
    }
}
