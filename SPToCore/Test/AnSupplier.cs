using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class AnSupplier
    {
        public AnSupplier()
        {
            AnMaterial = new HashSet<AnMaterial>();
            AnPhase = new HashSet<AnPhase>();
            AnSupplierBusinessPartner = new HashSet<AnSupplierBusinessPartner>();
            AnSupplierContact = new HashSet<AnSupplierContact>();
            AnSupplierType = new HashSet<AnSupplierType>();
        }

        public int IdSupplier { get; set; }
        public string Code { get; set; }
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
        public int? IdUserCreate { get; set; }
        public int? IdUserLastEdit { get; set; }
        public DateTimeOffset? DateLoad { get; set; }
        public DateTimeOffset? DateLastEdit { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? AllowEdit { get; set; }
        public int? IdSupplierSource { get; set; }
        public bool? IsInternalSupplier { get; set; }
        public int? IdPaymentType { get; set; }
        public int? IdLead { get; set; }
        public int? IdCompanySector { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public bool? IsEnabled { get; set; }
        public int? IdUserLock { get; set; }
        public DateTimeOffset? DateUserLock { get; set; }
        public string MetelCompanyCode { get; set; }
        public bool? FlStock { get; set; }

        public virtual MdCountry IdCountryNavigation { get; set; }
        public virtual MdPaymentType IdPaymentTypeNavigation { get; set; }
        public virtual ICollection<AnMaterial> AnMaterial { get; set; }
        public virtual ICollection<AnPhase> AnPhase { get; set; }
        public virtual ICollection<AnSupplierBusinessPartner> AnSupplierBusinessPartner { get; set; }
        public virtual ICollection<AnSupplierContact> AnSupplierContact { get; set; }
        public virtual ICollection<AnSupplierType> AnSupplierType { get; set; }
    }
}
