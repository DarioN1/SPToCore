using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdCountry
    {
        public MdCountry()
        {
            AnCustomer = new HashSet<AnCustomer>();
            AnSupplier = new HashSet<AnSupplier>();
        }

        public int IdCountry { get; set; }
        public string Name { get; set; }
        public string Alpha2 { get; set; }
        public string Alpha3 { get; set; }
        public string Code { get; set; }
        public string Iso31662 { get; set; }
        public string Region { get; set; }
        public string SubRegion { get; set; }
        public string IntermediateRegion { get; set; }
        public string RegionCode { get; set; }
        public string SubRegionCode { get; set; }
        public string IntermediateRegionCode { get; set; }

        public virtual ICollection<AnCustomer> AnCustomer { get; set; }
        public virtual ICollection<AnSupplier> AnSupplier { get; set; }
    }
}
