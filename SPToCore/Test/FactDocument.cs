using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class FactDocument
    {
        public int IdDocument { get; set; }
        public int? IdEntityType { get; set; }
        public int? IdEntity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FolderPath { get; set; }
        public string FileUrl { get; set; }
        public string FileName { get; set; }
        public string FileNameNoExt { get; set; }
        public string FileExt { get; set; }
        public int? IdUserCreate { get; set; }
        public DateTimeOffset? DateUserCreate { get; set; }

        public virtual MdEntityType IdEntityTypeNavigation { get; set; }
    }
}
