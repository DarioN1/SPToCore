using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class VwAnCustomer
    {
        public int IdCustomer { get; set; }
        public string Code { get; set; }
        public string BusinessName { get; set; }
        public string Vat { get; set; }
        public string FiscalCode { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public string Zip { get; set; }
        public int? IdCountry { get; set; }
        public string Country { get; set; }
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
        public string UserCreate { get; set; }
        public int? IdUserLastEdit { get; set; }
        public string UserLastEdit { get; set; }
        public DateTimeOffset? DateLoad { get; set; }
        public DateTimeOffset? DateLastEdit { get; set; }
        public bool IsDeleted { get; set; }
        public bool? AllowEdit { get; set; }
        public bool? IsInternalCustomer { get; set; }
        public int? IdCompanySector { get; set; }
        public string CompanySectorCode { get; set; }
        public string CompanySector { get; set; }
        public int? IdPaymentType { get; set; }
        public string PaymentTypeCode { get; set; }
        public string PaymentType { get; set; }
        public string AddressFull { get; set; }
        public string AddressFullFormatted { get; set; }
        public string AddressFullHtml { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int? IdLead { get; set; }
        public int? IdUserLock { get; set; }
        public string UserLock { get; set; }
        public DateTimeOffset? DateUserLock { get; set; }
        public bool? FlStock { get; set; }
    }
}
