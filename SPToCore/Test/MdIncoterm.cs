using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdIncoterm
    {
        public int IdIncoterm { get; set; }
        public string Code { get; set; }
        public string Incoterm { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }
    }
}
