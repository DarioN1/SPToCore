using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class AnResource
    {
        public AnResource()
        {
            AnPhaseIdResourceNavigation = new HashSet<AnPhase>();
            AnPhaseIdResourceToolingNavigation = new HashSet<AnPhase>();
            AnResourceGroup = new HashSet<AnResourceGroup>();
        }

        public int IdResource { get; set; }
        public string Code { get; set; }
        public string Resource { get; set; }
        public int? IdResourceType { get; set; }
        public int? IdResourceStatus { get; set; }
        public decimal? VCostH { get; set; }
        public bool? IsEnabled { get; set; }
        public bool? IsDeleted { get; set; }
        public int? IdUserLock { get; set; }
        public DateTimeOffset? DateUserLock { get; set; }
        public int? IdUserCreate { get; set; }
        public DateTimeOffset? DateUserCreate { get; set; }
        public int? IdUserLastEdit { get; set; }
        public DateTimeOffset? DateUserLastEdit { get; set; }

        public virtual MdResourceStatus IdResourceStatusNavigation { get; set; }
        public virtual MdResourceType IdResourceTypeNavigation { get; set; }
        public virtual AnUser IdUserCreateNavigation { get; set; }
        public virtual AnUser IdUserLastEditNavigation { get; set; }
        public virtual AnUser IdUserLockNavigation { get; set; }
        public virtual ICollection<AnPhase> AnPhaseIdResourceNavigation { get; set; }
        public virtual ICollection<AnPhase> AnPhaseIdResourceToolingNavigation { get; set; }
        public virtual ICollection<AnResourceGroup> AnResourceGroup { get; set; }
    }
}
