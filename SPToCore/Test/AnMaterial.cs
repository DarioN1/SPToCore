using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class AnMaterial
    {
        public AnMaterial()
        {
            AnBomMaterial = new HashSet<AnBomMaterial>();
            AnMaterialFormat = new HashSet<AnMaterialFormat>();
            AnPhaseMaterial = new HashSet<AnPhaseMaterial>();
            FactJobLineMaterial = new HashSet<FactJobLineMaterial>();
        }

        public int IdMaterial { get; set; }
        public string Code { get; set; }
        public string Material { get; set; }
        public int? IdMaterialClass { get; set; }
        public int? IdMaterialSector { get; set; }
        public int? IdBom { get; set; }
        public decimal? Height { get; set; }
        public decimal? Width { get; set; }
        public decimal? Lenght { get; set; }
        public decimal? Weight { get; set; }
        public int? IdMaterialType { get; set; }
        public int? IdMaterialShape { get; set; }
        public int? IdMaterialStatus { get; set; }
        public int? IdUnitSelling { get; set; }
        public decimal? VQtyBase { get; set; }
        public decimal? VQtyBox { get; set; }
        public decimal? VQtyMin { get; set; }
        public decimal? VQtyMax { get; set; }
        public decimal? VQtyMulti { get; set; }
        public bool? Metel { get; set; }
        public decimal? VPrice { get; set; }
        public decimal? VPriceLast { get; set; }
        public decimal? VPriceAvg { get; set; }
        public int? IntOrder { get; set; }
        public bool? IsEnabled { get; set; }
        public bool? IsDeleted { get; set; }
        public int? IdUserLock { get; set; }
        public DateTimeOffset? DateUserLock { get; set; }
        public int? IdUserCreate { get; set; }
        public DateTimeOffset? DateUserCreate { get; set; }
        public int? IdUserLastEdit { get; set; }
        public DateTimeOffset? DateUserLastEdit { get; set; }
        public string Ean { get; set; }
        public string Electrocode { get; set; }
        public string Etim { get; set; }
        public string Barcode { get; set; }
        public string BarcodeType { get; set; }
        public int? IdSupplier { get; set; }
        public bool? FlStock { get; set; }

        public virtual AnBom IdBomNavigation { get; set; }
        public virtual MdMaterialClass IdMaterialClassNavigation { get; set; }
        public virtual MdMaterialSector IdMaterialSectorNavigation { get; set; }
        public virtual MdMaterialShape IdMaterialShapeNavigation { get; set; }
        public virtual MdMaterialStatus IdMaterialStatusNavigation { get; set; }
        public virtual MdMaterialType IdMaterialTypeNavigation { get; set; }
        public virtual AnSupplier IdSupplierNavigation { get; set; }
        public virtual MdUnitSelling IdUnitSellingNavigation { get; set; }
        public virtual AnUser IdUserCreateNavigation { get; set; }
        public virtual AnUser IdUserLastEditNavigation { get; set; }
        public virtual AnUser IdUserLockNavigation { get; set; }
        public virtual ICollection<AnBomMaterial> AnBomMaterial { get; set; }
        public virtual ICollection<AnMaterialFormat> AnMaterialFormat { get; set; }
        public virtual ICollection<AnPhaseMaterial> AnPhaseMaterial { get; set; }
        public virtual ICollection<FactJobLineMaterial> FactJobLineMaterial { get; set; }
    }
}
