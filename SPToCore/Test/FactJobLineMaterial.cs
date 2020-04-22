using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class FactJobLineMaterial
    {
        public int IdJobLineMaterial { get; set; }
        public int IdJobLine { get; set; }
        public string Code { get; set; }
        public int IdMaterial { get; set; }
        public decimal VQty { get; set; }
        public int? IntOrder { get; set; }

        public virtual FactJobLine IdJobLineNavigation { get; set; }
        public virtual AnMaterial IdMaterialNavigation { get; set; }
    }
}
