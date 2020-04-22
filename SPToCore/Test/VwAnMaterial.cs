using System;
using System.Collections.Generic;

namespace SPToCore.Test
{
    public partial class VwAnMaterial
    {
        public int IdMaterial { get; set; }
        public string Code { get; set; }
        public string Material { get; set; }
        public int? IdMaterialClass { get; set; }
        public string MaterialClassCode { get; set; }
        public string MaterialClass { get; set; }
        public int? IdMaterialSector { get; set; }
        public string MaterialSectorCode { get; set; }
        public string MaterialSector { get; set; }
        public decimal? Height { get; set; }
        public decimal? Width { get; set; }
        public decimal? Lenght { get; set; }
        public decimal? Weight { get; set; }
        public int? IdMaterialType { get; set; }
        public string MaterialTypeCode { get; set; }
        public string MaterialType { get; set; }
        public int? IdBom { get; set; }
        public string BomCode { get; set; }
        public string Bom { get; set; }
        public int? IdMaterialShape { get; set; }
        public string MaterialShapeCode { get; set; }
        public string MaterialShape { get; set; }
        public int? IdMaterialStatus { get; set; }
        public string MaterialStatusCode { get; set; }
        public string MaterialStatus { get; set; }
        public bool? Metel { get; set; }
        public int IdUnitSelling { get; set; }
        public string UnitSellingCode { get; set; }
        public string UnitSelling { get; set; }
        public int? Decimals { get; set; }
        public decimal? VQtyBase { get; set; }
        public decimal? VQtyBox { get; set; }
        public decimal? VQtyMin { get; set; }
        public decimal? VQtyMax { get; set; }
        public decimal? VQtyMulti { get; set; }
        public decimal? VPrice { get; set; }
        public decimal? VPriceLast { get; set; }
        public decimal? VPriceAvg { get; set; }
        public int? IdSupplier { get; set; }
        public string SupplierCode { get; set; }
        public string Supplier { get; set; }
        public string Ean { get; set; }
        public string Electrocode { get; set; }
        public string Etim { get; set; }
        public string Barcode { get; set; }
        public string BarcodeType { get; set; }
        public int? IntOrder { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
        public int? IdUserLock { get; set; }
        public string UserLock { get; set; }
        public DateTimeOffset? DateUserLock { get; set; }
        public int? IdUserCreate { get; set; }
        public string UserCreate { get; set; }
        public DateTimeOffset? DateUserCreate { get; set; }
        public int? IdUserLastEdit { get; set; }
        public string UserLastEdit { get; set; }
        public DateTimeOffset? DateUserLastEdit { get; set; }
        public bool? FlStock { get; set; }
    }
}
