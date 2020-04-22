using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdUnitMeasure
    {
        public int IdUnitMeasure { get; set; }
        public string Code { get; set; }
        public string UnitMeasure { get; set; }
        public int? Decimals { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }
    }
}
