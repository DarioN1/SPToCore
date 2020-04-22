using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class VwAnBom
    {
        public int IdBom { get; set; }
        public int? IdMaterial { get; set; }
        public string Code { get; set; }
        public string Bom { get; set; }
        public string MaterialCode { get; set; }
        public string Material { get; set; }
        public bool? IsEnabled { get; set; }
        public bool? IsDeleted { get; set; }
        public int? IdUserLock { get; set; }
        public string UserLock { get; set; }
        public DateTimeOffset? DateUserLock { get; set; }
        public int? IdUserCreate { get; set; }
        public string UserCreate { get; set; }
        public DateTimeOffset? DateUserCreate { get; set; }
        public int? IdUserLastEdit { get; set; }
        public string UserLastEdit { get; set; }
        public DateTimeOffset? DateUserLastEdit { get; set; }
    }
}
