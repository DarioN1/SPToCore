using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class VwAnResourceGroup
    {
        public int IdRow { get; set; }
        public int IdResource { get; set; }
        public int IdResourceGroup { get; set; }
        public string ResourceCode { get; set; }
        public string ResourceGroup { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }
    }
}
