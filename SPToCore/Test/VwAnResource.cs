using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class VwAnResource
    {
        public int IdResource { get; set; }
        public string Code { get; set; }
        public string Resource { get; set; }
        public decimal? VCostH { get; set; }
        public int? IdResourceType { get; set; }
        public string ResourceTypeCode { get; set; }
        public string ResourceType { get; set; }
        public int? IdResourceStatus { get; set; }
        public string ResourceStatusCode { get; set; }
        public string ResourceStatus { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
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
