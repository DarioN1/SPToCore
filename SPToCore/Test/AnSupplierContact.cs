using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class AnSupplierContact
    {
        public int IdSupplierContact { get; set; }
        public int? IdSupplier { get; set; }
        public int? IdOpportunity { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? IdWorkFunction { get; set; }
        public int? IdWorkDepartment { get; set; }
        public bool? IsDecisionMaker { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Mob1 { get; set; }
        public string Mob2 { get; set; }
        public string Email1 { get; set; }
        public string Email2 { get; set; }
        public int? IdUserCreate { get; set; }
        public int? IdUserLastEdit { get; set; }
        public DateTime? DateLoad { get; set; }
        public DateTime? DateLastEdit { get; set; }
        public bool? IsDeleted { get; set; }
        public bool? IsDefault { get; set; }

        public virtual AnSupplier IdSupplierNavigation { get; set; }
        public virtual MdWorkFunction IdWorkFunctionNavigation { get; set; }
    }
}
