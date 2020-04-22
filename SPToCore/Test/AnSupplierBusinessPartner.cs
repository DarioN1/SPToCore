using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class AnSupplierBusinessPartner
    {
        public int IdSupplierBusinessPartner { get; set; }
        public int IdBusinessPartnerType { get; set; }
        public int IdSupplier { get; set; }
        public string BusinessName { get; set; }
        public string Vat { get; set; }
        public string FiscalCode { get; set; }
        public int? IdCountry { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public string Province { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Mob1 { get; set; }
        public string Mob2 { get; set; }
        public string Fax1 { get; set; }
        public string Fax2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public bool? IsDeleted { get; set; }
        public string Ref1 { get; set; }
        public string Ref2 { get; set; }

        public virtual MdBusinessPartnerType IdBusinessPartnerTypeNavigation { get; set; }
        public virtual AnSupplier IdSupplierNavigation { get; set; }
    }
}
