using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class VwFactDocument
    {
        public int IdDocument { get; set; }
        public int? IdEntityType { get; set; }
        public int? IdEntity { get; set; }
        public string EntityCode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FolderPath { get; set; }
        public string FileUrl { get; set; }
        public string FileName { get; set; }
        public string FileNameNoExt { get; set; }
        public string FileExt { get; set; }
        public int? IdUserCreate { get; set; }
        public string UserCreate { get; set; }
        public DateTimeOffset? DateUserCreate { get; set; }
    }
}
