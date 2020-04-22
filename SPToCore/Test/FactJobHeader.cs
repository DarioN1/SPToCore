using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class FactJobHeader
    {
        public FactJobHeader()
        {
            FactJobLine = new HashSet<FactJobLine>();
        }

        public int IdJob { get; set; }
        public string Code { get; set; }
        public string Job { get; set; }
        public string Description { get; set; }
        public int IdJobType { get; set; }
        public int IdCustomer { get; set; }
        public int? IdCurrency { get; set; }
        public DateTime? DateStart { get; set; }
        public int? IntDateStart { get; set; }
        public DateTime? DateEnd { get; set; }
        public int? IntDateEnd { get; set; }
        public int? IdJobStatus { get; set; }
        public bool? IsDeleted { get; set; }
        public int? IdUserLock { get; set; }
        public DateTimeOffset? DateUserLock { get; set; }
        public int? IdUserCreate { get; set; }
        public DateTimeOffset? DateUserCreate { get; set; }
        public int? IdUserLastEdit { get; set; }
        public DateTimeOffset? DateUserLastEdit { get; set; }

        public virtual AnCustomer IdCustomerNavigation { get; set; }
        public virtual MdJobStatus IdJobStatusNavigation { get; set; }
        public virtual MdJobType IdJobTypeNavigation { get; set; }
        public virtual ICollection<FactJobLine> FactJobLine { get; set; }
    }
}
