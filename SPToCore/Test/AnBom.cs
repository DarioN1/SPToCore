using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class AnBom
    {
        public AnBom()
        {
            AnBomMaterial = new HashSet<AnBomMaterial>();
            AnBomPhase = new HashSet<AnBomPhase>();
            AnMaterial = new HashSet<AnMaterial>();
        }

        public int IdBom { get; set; }
        public int? IdMaterial { get; set; }
        public string Code { get; set; }
        public string Bom { get; set; }
        public bool? IsEnabled { get; set; }
        public bool? IsDeleted { get; set; }
        public int? IdUserLock { get; set; }
        public DateTimeOffset? DateUserLock { get; set; }
        public int? IdUserCreate { get; set; }
        public DateTimeOffset? DateUserCreate { get; set; }
        public int? IdUserLastEdit { get; set; }
        public DateTimeOffset? DateUserLastEdit { get; set; }

        public virtual ICollection<AnBomMaterial> AnBomMaterial { get; set; }
        public virtual ICollection<AnBomPhase> AnBomPhase { get; set; }
        public virtual ICollection<AnMaterial> AnMaterial { get; set; }
    }
}
