using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class AnPhaseMaterial
    {
        public int IdPhaseMaterial { get; set; }
        public int? IdPhase { get; set; }
        public int? IdMaterial { get; set; }
        public int? IdUnitSelling { get; set; }
        public decimal? VQty { get; set; }
        public decimal? VQtyBase { get; set; }

        public virtual AnMaterial IdMaterialNavigation { get; set; }
        public virtual AnPhase IdPhaseNavigation { get; set; }
    }
}
