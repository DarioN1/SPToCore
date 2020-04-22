using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class AnPhase
    {
        public AnPhase()
        {
            AnBomPhase = new HashSet<AnBomPhase>();
            AnPhaseMaterial = new HashSet<AnPhaseMaterial>();
        }

        public int IdPhase { get; set; }
        public string Code { get; set; }
        public string Phase { get; set; }
        public int? IdCurrency { get; set; }
        public int? IdPhaseType { get; set; }
        public int? IdSupplier { get; set; }
        public int? IdResourceGroup { get; set; }
        public int? IdResourceTooling { get; set; }
        public decimal? VToolingStartMm { get; set; }
        public decimal? VUntoolingMm { get; set; }
        public decimal? VToolingK { get; set; }
        public int? IdPhaseCalculation { get; set; }
        public decimal? VCycleMm { get; set; }
        public int? IdResource { get; set; }
        public decimal? VK { get; set; }
        public decimal? VSupplierDd { get; set; }
        public decimal? VSupplierCostDd { get; set; }
        public string Note { get; set; }
        public bool? IsEnabled { get; set; }
        public bool? IsDeleted { get; set; }
        public int? IdUserLock { get; set; }
        public DateTimeOffset? DateUserLock { get; set; }
        public int? IdUserCreate { get; set; }
        public DateTimeOffset? DateUserCreate { get; set; }
        public int? IdUserLastEdit { get; set; }
        public DateTimeOffset? DateUserLastEdit { get; set; }

        public virtual MdCurrency IdCurrencyNavigation { get; set; }
        public virtual MdPhaseCalculation IdPhaseCalculationNavigation { get; set; }
        public virtual MdPhaseType IdPhaseTypeNavigation { get; set; }
        public virtual MdResourceGroup IdResourceGroupNavigation { get; set; }
        public virtual AnResource IdResourceNavigation { get; set; }
        public virtual AnResource IdResourceToolingNavigation { get; set; }
        public virtual AnSupplier IdSupplierNavigation { get; set; }
        public virtual AnUser IdUserCreateNavigation { get; set; }
        public virtual AnUser IdUserLastEditNavigation { get; set; }
        public virtual AnUser IdUserLockNavigation { get; set; }
        public virtual ICollection<AnBomPhase> AnBomPhase { get; set; }
        public virtual ICollection<AnPhaseMaterial> AnPhaseMaterial { get; set; }
    }
}
