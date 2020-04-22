using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class AnMetelPriceList
    {
        public int IdMetelPriceList { get; set; }
        public int? IdSupplier { get; set; }
        public string PriceList { get; set; }
        public string CompanyCode { get; set; }
        public string Vat { get; set; }
        public string Number { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateLastChange { get; set; }
        public string Version { get; set; }
        public DateTime? DateStartWholesaler { get; set; }
        public string Batch { get; set; }
        public DateTimeOffset? DateLastImport { get; set; }
        public int? IdUserLastEdit { get; set; }
    }
}
