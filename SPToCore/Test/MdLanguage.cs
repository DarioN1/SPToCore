using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class MdLanguage
    {
        public int IdLanguage { get; set; }
        public string Code { get; set; }
        public string Language { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }
    }
}
