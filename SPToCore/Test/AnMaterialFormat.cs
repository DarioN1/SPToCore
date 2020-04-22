using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class AnMaterialFormat
    {
        public int IdMaterialFormat { get; set; }
        public int IdMaterial { get; set; }
        public int? IdUnitSelling { get; set; }
        public decimal? VQtyBase { get; set; }
        public decimal? VQtyBox { get; set; }
        public decimal? VQtyMin { get; set; }
        public decimal? VQtyMax { get; set; }
        public decimal? VQtyMulti { get; set; }
        public decimal? VPriceWhosaler { get; set; }
        public decimal? VPriceCustomer { get; set; }
        public int? Decimals { get; set; }

        public virtual AnMaterial IdMaterialNavigation { get; set; }
        public virtual MdUnitSelling IdUnitSellingNavigation { get; set; }
    }
}
