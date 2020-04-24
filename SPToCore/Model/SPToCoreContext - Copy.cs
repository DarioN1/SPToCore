
using System;
using System.Data;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SPToCore.Test;

namespace EMGERP_WebApi.Model
{
    public partial class SPToCoreContext : EMGERPContext
    {
        private DbSet<Material_SEARCHResult> Material_SEARCH { get; set; }


        public SPToCoreContext()
        {
        }

        public SPToCoreContext(DbContextOptions<EMGERPContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // No key
            modelBuilder.Query<Material_SEARCHResult>().HasNoKey();


            //Thanks Valecass!!!
            base.OnModelCreating(modelBuilder);
        }



        public async Task<List<Material_SEARCHResult>> Material_SEARCHAsync(int? idUser, int? includeNotClassified, int? idMaterialDest, int? flStock)
        {
            // Initialize Result.  
            List<Material_SEARCHResult> lst = new List<Material_SEARCHResult>();

            try
            {
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser ?? (object)DBNull.Value);
                SqlParameter p_includeNotClassified = new SqlParameter("@includeNotClassified", includeNotClassified ?? (object)DBNull.Value);
                SqlParameter p_idMaterialDest = new SqlParameter("@idMaterialDest", idMaterialDest ?? (object)DBNull.Value);
                SqlParameter p_flStock = new SqlParameter("@flStock", flStock ?? (object)DBNull.Value);


                // Processing.  
                string sqlQuery = $@"EXEC [dbo].[Material_SEARCH] 
 @idUser , 
@includeNotClassified , 
@idMaterialDest , 
@flStock 
";

                lst = await this.Material_SEARCH.FromSqlRaw(sqlQuery, p_idUser, p_includeNotClassified, p_idMaterialDest, p_flStock).ToListAsync();

            }
            catch (Exception ex)
            {
                throw (ex);
            }

            return lst;
        }




        public class Material_SEARCHResult
        {
            public int idMaterial { get; set; }
            public string Code { get; set; }
            public string Material { get; set; }
            public int? idMaterialClass { get; set; }
            public string MaterialClassCode { get; set; }
            public string MaterialClass { get; set; }
            public int? idMaterialSector { get; set; }
            public string MaterialSectorCode { get; set; }
            public string MaterialSector { get; set; }
            public decimal? Height { get; set; }
            public decimal? Width { get; set; }
            public decimal? Lenght { get; set; }
            public decimal? Weight { get; set; }
            public int? idMaterialType { get; set; }
            public string MaterialTypeCode { get; set; }
            public string MaterialType { get; set; }
            public int? idBom { get; set; }
            public string BomCode { get; set; }
            public string Bom { get; set; }
            public int? idMaterialShape { get; set; }
            public string MaterialShapeCode { get; set; }
            public string MaterialShape { get; set; }
            public int? idMaterialStatus { get; set; }
            public string MaterialStatusCode { get; set; }
            public string MaterialStatus { get; set; }
            public bool? Metel { get; set; }
            public int idUnitSelling { get; set; }
            public string UnitSellingCode { get; set; }
            public string UnitSelling { get; set; }
            public int? Decimals { get; set; }
            public decimal? vQtyBase { get; set; }
            public decimal? vQtyBox { get; set; }
            public decimal? vQtyMin { get; set; }
            public decimal? vQtyMax { get; set; }
            public decimal? vQtyMulti { get; set; }
            public decimal? vPrice { get; set; }
            public decimal? vPriceLast { get; set; }
            public decimal? vPriceAvg { get; set; }
            public int? idSupplier { get; set; }
            public string SupplierCode { get; set; }
            public string Supplier { get; set; }
            public string Ean { get; set; }
            public string Electrocode { get; set; }
            public string Etim { get; set; }
            public string Barcode { get; set; }
            public string BarcodeType { get; set; }
            public int? intOrder { get; set; }
            public bool isEnabled { get; set; }
            public bool isDeleted { get; set; }
            public int? idUserLock { get; set; }
            public string UserLock { get; set; }
            public DateTimeOffset? DateUserLock { get; set; }
            public int? idUserCreate { get; set; }
            public string UserCreate { get; set; }
            public DateTimeOffset? DateUserCreate { get; set; }
            public int? idUserLastEdit { get; set; }
            public string UserLastEdit { get; set; }
            public DateTimeOffset? DateUserLastEdit { get; set; }

        }



    }
}
