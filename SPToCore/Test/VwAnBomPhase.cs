using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class VwAnBomPhase
    {
        public int IdBom { get; set; }
        public int IdBomPhase { get; set; }
        public string BomCode { get; set; }
        public string Bom { get; set; }
        public int? IdPhase { get; set; }
        public string Code { get; set; }
        public string Phase { get; set; }
        public string Progressive { get; set; }
        public int? IdCurrency { get; set; }
        public int? IdPhaseType { get; set; }
        public string PhaseTypeCode { get; set; }
        public string PhaseType { get; set; }
        public int? IdSupplier { get; set; }
        public string SupplierCode { get; set; }
        public string Supplier { get; set; }
        public int? IdResourceGroup { get; set; }
        public string ResourceGroupCode { get; set; }
        public string ResourceGroup { get; set; }
        public int? IdResourceTooling { get; set; }
        public string ResourceToolingCode { get; set; }
        public string ResourceTooling { get; set; }
        public decimal? VToolingStartMm { get; set; }
        public decimal? VUntoolingMm { get; set; }
        public decimal? VToolingK { get; set; }
        public int? IdPhaseCalculation { get; set; }
        public string PhaseCalculationCode { get; set; }
        public string PhaseCalculation { get; set; }
        public decimal? VCycleMm { get; set; }
        public int? IdResource { get; set; }
        public string ResourceCode { get; set; }
        public string Resource { get; set; }
        public decimal? VK { get; set; }
        public decimal? VSupplierDd { get; set; }
        public decimal? VSupplierCostDd { get; set; }
        public string Note { get; set; }
    }
}
