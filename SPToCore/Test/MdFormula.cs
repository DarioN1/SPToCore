using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdFormula
    {
        public int IdFormula { get; set; }
        public string Code { get; set; }
        public string Formula { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }
    }
}
