using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class AnUser
    {
        public AnUser()
        {
            AnCustomerIdUserCreateNavigation = new HashSet<AnCustomer>();
            AnCustomerIdUserLastEditNavigation = new HashSet<AnCustomer>();
            AnCustomerIdUserLockNavigation = new HashSet<AnCustomer>();
            AnMaterialIdUserCreateNavigation = new HashSet<AnMaterial>();
            AnMaterialIdUserLastEditNavigation = new HashSet<AnMaterial>();
            AnMaterialIdUserLockNavigation = new HashSet<AnMaterial>();
            AnPhaseIdUserCreateNavigation = new HashSet<AnPhase>();
            AnPhaseIdUserLastEditNavigation = new HashSet<AnPhase>();
            AnPhaseIdUserLockNavigation = new HashSet<AnPhase>();
            AnResourceIdUserCreateNavigation = new HashSet<AnResource>();
            AnResourceIdUserLastEditNavigation = new HashSet<AnResource>();
            AnResourceIdUserLockNavigation = new HashSet<AnResource>();
        }

        public string Id { get; set; }
        public int IdUser { get; set; }
        public int? IdLanguage { get; set; }
        public int? IdCulture { get; set; }
        public int? IdCurrency { get; set; }
        public bool? IsActive { get; set; }
        public int? IdTimeZone { get; set; }
        public int? IdSalesArea { get; set; }

        public virtual ICollection<AnCustomer> AnCustomerIdUserCreateNavigation { get; set; }
        public virtual ICollection<AnCustomer> AnCustomerIdUserLastEditNavigation { get; set; }
        public virtual ICollection<AnCustomer> AnCustomerIdUserLockNavigation { get; set; }
        public virtual ICollection<AnMaterial> AnMaterialIdUserCreateNavigation { get; set; }
        public virtual ICollection<AnMaterial> AnMaterialIdUserLastEditNavigation { get; set; }
        public virtual ICollection<AnMaterial> AnMaterialIdUserLockNavigation { get; set; }
        public virtual ICollection<AnPhase> AnPhaseIdUserCreateNavigation { get; set; }
        public virtual ICollection<AnPhase> AnPhaseIdUserLastEditNavigation { get; set; }
        public virtual ICollection<AnPhase> AnPhaseIdUserLockNavigation { get; set; }
        public virtual ICollection<AnResource> AnResourceIdUserCreateNavigation { get; set; }
        public virtual ICollection<AnResource> AnResourceIdUserLastEditNavigation { get; set; }
        public virtual ICollection<AnResource> AnResourceIdUserLockNavigation { get; set; }
    }
}
