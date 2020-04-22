using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class VwLock
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public int IdEntityType { get; set; }
        public string EntityCode { get; set; }
        public string Entity { get; set; }
        public int? IdUserLock { get; set; }
        public string UserLock { get; set; }
        public DateTimeOffset? DateUserLock { get; set; }
    }
}
