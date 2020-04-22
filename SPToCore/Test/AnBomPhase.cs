using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class AnBomPhase
    {
        public int IdBomPhase { get; set; }
        public int? IdBom { get; set; }
        public int? IdPhase { get; set; }
        public int? IdCurrency { get; set; }
        public string Progressive { get; set; }
        public string Phase { get; set; }
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

        public virtual AnBom IdBomNavigation { get; set; }
        public virtual AnPhase IdPhaseNavigation { get; set; }
    }
}
