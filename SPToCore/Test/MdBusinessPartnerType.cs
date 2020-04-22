using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdBusinessPartnerType
    {
        public MdBusinessPartnerType()
        {
            AnCustomerBusinessPartner = new HashSet<AnCustomerBusinessPartner>();
            AnSupplierBusinessPartner = new HashSet<AnSupplierBusinessPartner>();
        }

        public int IdBusinessPartnerType { get; set; }
        public string Code { get; set; }
        public string BusinessPartnerType { get; set; }

        public virtual ICollection<AnCustomerBusinessPartner> AnCustomerBusinessPartner { get; set; }
        public virtual ICollection<AnSupplierBusinessPartner> AnSupplierBusinessPartner { get; set; }
    }
}
