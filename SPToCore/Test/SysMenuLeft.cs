using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class SysMenuLeft
    {
        public int IdMenuItem { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string Icon { get; set; }
        public string Link { get; set; }
        public string Action { get; set; }
        public bool? Home { get; set; }
        public bool? Group { get; set; }
        public string PathMatch { get; set; }
        public string Target { get; set; }
        public int? IdMenuItemParent { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }
    }
}
