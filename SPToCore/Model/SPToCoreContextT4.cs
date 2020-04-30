using System;
using System.Data;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SPToCore.Model
{
    /*
    public partial class SPToCoreContextT4 : EMGERPContext
    {
        private DbSet<ADMIN_GET_ErrorLogResult> ADMIN_GET_ErrorLog { get; set; }
        private DbSet<ADMIN_GET_LockResult> ADMIN_GET_Lock { get; set; }
        private DbSet<Bom_CHECKResult> Bom_CHECK { get; set; }
        private DbSet<Bom_GETResult> Bom_GET { get; set; }
        private DbSet<Bom_GET_MaterialResult> Bom_GET_Material { get; set; }
        private DbSet<Bom_GET_PhaseResult> Bom_GET_Phase { get; set; }
        private DbSet<Bom_GET_PhaseMaterialResult> Bom_GET_PhaseMaterial { get; set; }
        private DbSet<Customer_CHECKResult> Customer_CHECK { get; set; }
        private DbSet<Customer_GETResult> Customer_GET { get; set; }
        private DbSet<Customer_GET_BusinessPartnerResult> Customer_GET_BusinessPartner { get; set; }
        private DbSet<Customer_GET_ContactResult> Customer_GET_Contact { get; set; }
        private DbSet<Customer_GET_DivisionResult> Customer_GET_Division { get; set; }
        private DbSet<Customer_SEARCHResult> Customer_SEARCH { get; set; }
        private DbSet<CustomerContact_GET_DetailResult> CustomerContact_GET_Detail { get; set; }
        private DbSet<Document_GET_DetailResult> Document_GET_Detail { get; set; }
        private DbSet<Document_SEARCHResult> Document_SEARCH { get; set; }
        private DbSet<Lock_GETResult> Lock_GET { get; set; }
        private DbSet<Material_CHECKResult> Material_CHECK { get; set; }
        private DbSet<Material_CHECK_RecursionResult> Material_CHECK_Recursion { get; set; }
        private DbSet<Material_GETResult> Material_GET { get; set; }
        private DbSet<Material_GET_BomResult> Material_GET_Bom { get; set; }
        private DbSet<Material_GET_MaterialFormatResult> Material_GET_MaterialFormat { get; set; }
        private DbSet<Material_GET_MaterialWarehouseResult> Material_GET_MaterialWarehouse { get; set; }
        private DbSet<Material_GET_USAGE_MaterialResult> Material_GET_USAGE_Material { get; set; }
        private DbSet<Material_SEARCHResult> Material_SEARCH { get; set; }
        private DbSet<MD_GET_CompanySectorResult> MD_GET_CompanySector { get; set; }
        private DbSet<MD_GET_CountryResult> MD_GET_Country { get; set; }
        private DbSet<MD_GET_CultureResult> MD_GET_Culture { get; set; }
        private DbSet<MD_GET_CurrencyResult> MD_GET_Currency { get; set; }
        private DbSet<MD_GET_DivisionResult> MD_GET_Division { get; set; }
        private DbSet<MD_GET_EntityTypeResult> MD_GET_EntityType { get; set; }
        private DbSet<MD_GET_FormulaResult> MD_GET_Formula { get; set; }
        private DbSet<MD_GET_FormulaUmResult> MD_GET_FormulaUm { get; set; }
        private DbSet<MD_GET_IncotermResult> MD_GET_Incoterm { get; set; }
        private DbSet<MD_GET_LanguageResult> MD_GET_Language { get; set; }
        private DbSet<MD_GET_MaterialClassResult> MD_GET_MaterialClass { get; set; }
        private DbSet<MD_GET_MaterialSectorResult> MD_GET_MaterialSector { get; set; }
        private DbSet<MD_GET_MaterialShapeResult> MD_GET_MaterialShape { get; set; }
        private DbSet<MD_GET_MaterialStatusResult> MD_GET_MaterialStatus { get; set; }
        private DbSet<MD_GET_MaterialTypeResult> MD_GET_MaterialType { get; set; }
        private DbSet<MD_GET_PaymentTypeResult> MD_GET_PaymentType { get; set; }
        private DbSet<MD_GET_PhaseCalculationResult> MD_GET_PhaseCalculation { get; set; }
        private DbSet<MD_GET_PhaseTypeResult> MD_GET_PhaseType { get; set; }
        private DbSet<MD_GET_ResourceGroupResult> MD_GET_ResourceGroup { get; set; }
        private DbSet<MD_GET_ResourceTypeResult> MD_GET_ResourceType { get; set; }
        private DbSet<MD_GET_SalesAreaResult> MD_GET_SalesArea { get; set; }
        private DbSet<MD_GET_StockMovementStatusResult> MD_GET_StockMovementStatus { get; set; }
        private DbSet<MD_GET_StockMovementTypeResult> MD_GET_StockMovementType { get; set; }
        private DbSet<MD_GET_SupplierTypeResult> MD_GET_SupplierType { get; set; }
        private DbSet<MD_GET_TimeZoneResult> MD_GET_TimeZone { get; set; }
        private DbSet<MD_GET_UnitMeasureResult> MD_GET_UnitMeasure { get; set; }
        private DbSet<MD_GET_UnitSellingResult> MD_GET_UnitSelling { get; set; }
        private DbSet<MD_GET_WorkDepartmentResult> MD_GET_WorkDepartment { get; set; }
        private DbSet<MD_GET_WorkFunctionResult> MD_GET_WorkFunction { get; set; }
        private DbSet<METEL_PriceList_GET_ALLResult> METEL_PriceList_GET_ALL { get; set; }
        private DbSet<METEL_STG_GET_PriceListResult> METEL_STG_GET_PriceList { get; set; }
        private DbSet<Phase_CHECKResult> Phase_CHECK { get; set; }
        private DbSet<Phase_GETResult> Phase_GET { get; set; }
        private DbSet<Phase_SEARCHResult> Phase_SEARCH { get; set; }
        private DbSet<Resource_CHECKResult> Resource_CHECK { get; set; }
        private DbSet<Resource_GETResult> Resource_GET { get; set; }
        private DbSet<Resource_GET_ResourceGroupResult> Resource_GET_ResourceGroup { get; set; }
        private DbSet<Resource_SEARCHResult> Resource_SEARCH { get; set; }
        private DbSet<Role_GETResult> Role_GET { get; set; }
        private DbSet<StockMovement_CHECKResult> StockMovement_CHECK { get; set; }
        private DbSet<StockMovement_GETResult> StockMovement_GET { get; set; }
        private DbSet<StockMovement_GET_DetailResult> StockMovement_GET_Detail { get; set; }
        private DbSet<StockMovement_SEARCHResult> StockMovement_SEARCH { get; set; }
        private DbSet<Supplier_CHECKResult> Supplier_CHECK { get; set; }
        private DbSet<Supplier_GETResult> Supplier_GET { get; set; }
        private DbSet<Supplier_GET_BusinessPartnerResult> Supplier_GET_BusinessPartner { get; set; }
        private DbSet<Supplier_GET_ContactResult> Supplier_GET_Contact { get; set; }
        private DbSet<Supplier_GET_DivisionResult> Supplier_GET_Division { get; set; }
        private DbSet<Supplier_GET_SupplierTypeResult> Supplier_GET_SupplierType { get; set; }
        private DbSet<Supplier_SEARCHResult> Supplier_SEARCH { get; set; }
        private DbSet<SupplierContact_GET_DetailResult> SupplierContact_GET_Detail { get; set; }
        private DbSet<USER_GET_APP_MenuLeftResult> USER_GET_APP_MenuLeft { get; set; }
        private DbSet<USER_GET_APP_MenuTopResult> USER_GET_APP_MenuTop { get; set; }
        private DbSet<Warehouse_SEARCHResult> Warehouse_SEARCH { get; set; }

        public SPToCoreContextT4()
        {
        }

        public SPToCoreContextT4(DbContextOptions<EMGERPContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // No key            
            modelBuilder.Query<ADMIN_GET_ErrorLogResult>().HasNoKey();
            modelBuilder.Query<ADMIN_GET_LockResult>().HasNoKey();
            modelBuilder.Query<Bom_CHECKResult>().HasNoKey();
            modelBuilder.Query<Bom_GETResult>().HasNoKey();
            modelBuilder.Query<Bom_GET_MaterialResult>().HasNoKey();
            modelBuilder.Query<Bom_GET_PhaseResult>().HasNoKey();
            modelBuilder.Query<Bom_GET_PhaseMaterialResult>().HasNoKey();
            modelBuilder.Query<Customer_CHECKResult>().HasNoKey();
            modelBuilder.Query<Customer_GETResult>().HasNoKey();
            modelBuilder.Query<Customer_GET_BusinessPartnerResult>().HasNoKey();
            modelBuilder.Query<Customer_GET_ContactResult>().HasNoKey();
            modelBuilder.Query<Customer_GET_DivisionResult>().HasNoKey();
            modelBuilder.Query<Customer_SEARCHResult>().HasNoKey();
            modelBuilder.Query<CustomerContact_GET_DetailResult>().HasNoKey();
            modelBuilder.Query<Document_GET_DetailResult>().HasNoKey();
            modelBuilder.Query<Document_SEARCHResult>().HasNoKey();
            modelBuilder.Query<Lock_GETResult>().HasNoKey();
            modelBuilder.Query<Material_CHECKResult>().HasNoKey();
            modelBuilder.Query<Material_CHECK_RecursionResult>().HasNoKey();
            modelBuilder.Query<Material_GETResult>().HasNoKey();
            modelBuilder.Query<Material_GET_BomResult>().HasNoKey();
            modelBuilder.Query<Material_GET_MaterialFormatResult>().HasNoKey();
            modelBuilder.Query<Material_GET_MaterialWarehouseResult>().HasNoKey();
            modelBuilder.Query<Material_GET_USAGE_MaterialResult>().HasNoKey();
            modelBuilder.Query<Material_SEARCHResult>().HasNoKey();
            modelBuilder.Query<MD_GET_CompanySectorResult>().HasNoKey();
            modelBuilder.Query<MD_GET_CountryResult>().HasNoKey();
            modelBuilder.Query<MD_GET_CultureResult>().HasNoKey();
            modelBuilder.Query<MD_GET_CurrencyResult>().HasNoKey();
            modelBuilder.Query<MD_GET_DivisionResult>().HasNoKey();
            modelBuilder.Query<MD_GET_EntityTypeResult>().HasNoKey();
            modelBuilder.Query<MD_GET_FormulaResult>().HasNoKey();
            modelBuilder.Query<MD_GET_FormulaUmResult>().HasNoKey();
            modelBuilder.Query<MD_GET_IncotermResult>().HasNoKey();
            modelBuilder.Query<MD_GET_LanguageResult>().HasNoKey();
            modelBuilder.Query<MD_GET_MaterialClassResult>().HasNoKey();
            modelBuilder.Query<MD_GET_MaterialSectorResult>().HasNoKey();
            modelBuilder.Query<MD_GET_MaterialShapeResult>().HasNoKey();
            modelBuilder.Query<MD_GET_MaterialStatusResult>().HasNoKey();
            modelBuilder.Query<MD_GET_MaterialTypeResult>().HasNoKey();
            modelBuilder.Query<MD_GET_PaymentTypeResult>().HasNoKey();
            modelBuilder.Query<MD_GET_PhaseCalculationResult>().HasNoKey();
            modelBuilder.Query<MD_GET_PhaseTypeResult>().HasNoKey();
            modelBuilder.Query<MD_GET_ResourceGroupResult>().HasNoKey();
            modelBuilder.Query<MD_GET_ResourceTypeResult>().HasNoKey();
            modelBuilder.Query<MD_GET_SalesAreaResult>().HasNoKey();
            modelBuilder.Query<MD_GET_StockMovementStatusResult>().HasNoKey();
            modelBuilder.Query<MD_GET_StockMovementTypeResult>().HasNoKey();
            modelBuilder.Query<MD_GET_SupplierTypeResult>().HasNoKey();
            modelBuilder.Query<MD_GET_TimeZoneResult>().HasNoKey();
            modelBuilder.Query<MD_GET_UnitMeasureResult>().HasNoKey();
            modelBuilder.Query<MD_GET_UnitSellingResult>().HasNoKey();
            modelBuilder.Query<MD_GET_WorkDepartmentResult>().HasNoKey();
            modelBuilder.Query<MD_GET_WorkFunctionResult>().HasNoKey();
            modelBuilder.Query<METEL_PriceList_GET_ALLResult>().HasNoKey();
            modelBuilder.Query<METEL_STG_GET_PriceListResult>().HasNoKey();
            modelBuilder.Query<Phase_CHECKResult>().HasNoKey();
            modelBuilder.Query<Phase_GETResult>().HasNoKey();
            modelBuilder.Query<Phase_SEARCHResult>().HasNoKey();
            modelBuilder.Query<Resource_CHECKResult>().HasNoKey();
            modelBuilder.Query<Resource_GETResult>().HasNoKey();
            modelBuilder.Query<Resource_GET_ResourceGroupResult>().HasNoKey();
            modelBuilder.Query<Resource_SEARCHResult>().HasNoKey();
            modelBuilder.Query<Role_GETResult>().HasNoKey();
            modelBuilder.Query<StockMovement_CHECKResult>().HasNoKey();
            modelBuilder.Query<StockMovement_GETResult>().HasNoKey();
            modelBuilder.Query<StockMovement_GET_DetailResult>().HasNoKey();
            modelBuilder.Query<StockMovement_SEARCHResult>().HasNoKey();
            modelBuilder.Query<Supplier_CHECKResult>().HasNoKey();
            modelBuilder.Query<Supplier_GETResult>().HasNoKey();
            modelBuilder.Query<Supplier_GET_BusinessPartnerResult>().HasNoKey();
            modelBuilder.Query<Supplier_GET_ContactResult>().HasNoKey();
            modelBuilder.Query<Supplier_GET_DivisionResult>().HasNoKey();
            modelBuilder.Query<Supplier_GET_SupplierTypeResult>().HasNoKey();
            modelBuilder.Query<Supplier_SEARCHResult>().HasNoKey();
            modelBuilder.Query<SupplierContact_GET_DetailResult>().HasNoKey();
            modelBuilder.Query<USER_GET_APP_MenuLeftResult>().HasNoKey();
            modelBuilder.Query<USER_GET_APP_MenuTopResult>().HasNoKey();
            modelBuilder.Query<Warehouse_SEARCHResult>().HasNoKey();
            //Thanks Valecass!!!
            base.OnModelCreating(modelBuilder);
        }

        public void ADM_CLEAR_ALL()
        {
            try
            {

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[ADM_CLEAR_ALL] ";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void ADM_DELETE_USER(int? idUser)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[ADM_DELETE_USER] @idUser";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void ADM_INIT_MD()
        {
            try
            {

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[ADM_INIT_MD] ";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void ADM_RESTORE_PROD()
        {
            try
            {

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[ADM_RESTORE_PROD] ";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<ADMIN_GET_ErrorLogResult>> ADMIN_GET_ErrorLogAsync()
        {
            //Initialize Result 
            List<ADMIN_GET_ErrorLogResult> lst = new List<ADMIN_GET_ErrorLogResult>();
            try
            {

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[ADMIN_GET_ErrorLog] ";

                //Output Data
                lst = await this.ADMIN_GET_ErrorLog.FromSqlRaw(sqlQuery).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<ADMIN_GET_LockResult>> ADMIN_GET_LockAsync()
        {
            //Initialize Result 
            List<ADMIN_GET_LockResult> lst = new List<ADMIN_GET_LockResult>();
            try
            {

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[ADMIN_GET_Lock] ";

                //Output Data
                lst = await this.ADMIN_GET_Lock.FromSqlRaw(sqlQuery).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void ADMIN_Unlock(int? idUser, int? idEntityType, int? idEntity)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idEntityType = new SqlParameter("@idEntityType", idEntityType.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idEntity = new SqlParameter("@idEntity", idEntity.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[ADMIN_Unlock] @idUser, @idEntityType, @idEntity";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Bom_ADD_Material(int? idUser, int? idBom, string Progressive, int? idMaterial, int? idUnitSelling, decimal? vQty, decimal? vQtyBase, decimal? vQtyScrap, ref int? idBomMaterial)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBom = new SqlParameter("@idBom", idBom.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Progressive = new SqlParameter("@Progressive", Progressive.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idUnitSelling = new SqlParameter("@idUnitSelling", idUnitSelling.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vQty = new SqlParameter("@vQty", vQty.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vQtyBase = new SqlParameter("@vQtyBase", vQtyBase.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vQtyScrap = new SqlParameter("@vQtyScrap", vQtyScrap.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBomMaterial = new SqlParameter("@idBomMaterial", idBomMaterial.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Bom_ADD_Material] @idUser, @idBom, @Progressive, @idMaterial, @idUnitSelling, @vQty, @vQtyBase, @vQtyScrap, @idBomMaterial OUTPUT";


                //Output Params
                idBomMaterial = (int?)p_idBomMaterial.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Bom_ADD_Phase(int? idUser, int? idBom, int? idPhase, int? idCurrency, string Progressive, string Phase, int? idPhaseType, int? idSupplier, int? idResourceGroup, int? idResourceTooling, decimal? vToolingStart_mm, decimal? vUntooling_mm, decimal? vToolingK, int? idPhaseCalculation, decimal? vCycle_mm, int? idResource, decimal? vK, decimal? vSupplier_DD, decimal? vSupplierCost_DD, string Note, ref int? idBomPhase)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBom = new SqlParameter("@idBom", idBom.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idPhase = new SqlParameter("@idPhase", idPhase.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCurrency = new SqlParameter("@idCurrency", idCurrency.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Progressive = new SqlParameter("@Progressive", Progressive.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Phase = new SqlParameter("@Phase", Phase.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idPhaseType = new SqlParameter("@idPhaseType", idPhaseType.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResourceGroup = new SqlParameter("@idResourceGroup", idResourceGroup.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResourceTooling = new SqlParameter("@idResourceTooling", idResourceTooling.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vToolingStart_mm = new SqlParameter("@vToolingStart_mm", vToolingStart_mm.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vUntooling_mm = new SqlParameter("@vUntooling_mm", vUntooling_mm.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vToolingK = new SqlParameter("@vToolingK", vToolingK.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idPhaseCalculation = new SqlParameter("@idPhaseCalculation", idPhaseCalculation.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vCycle_mm = new SqlParameter("@vCycle_mm", vCycle_mm.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResource = new SqlParameter("@idResource", idResource.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vK = new SqlParameter("@vK", vK.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vSupplier_DD = new SqlParameter("@vSupplier_DD", vSupplier_DD.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vSupplierCost_DD = new SqlParameter("@vSupplierCost_DD", vSupplierCost_DD.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Note = new SqlParameter("@Note", Note.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBomPhase = new SqlParameter("@idBomPhase", idBomPhase.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Bom_ADD_Phase] @idUser, @idBom, @idPhase, @idCurrency, @Progressive, @Phase, @idPhaseType, @idSupplier, @idResourceGroup, @idResourceTooling, @vToolingStart_mm, @vUntooling_mm, @vToolingK, @idPhaseCalculation, @vCycle_mm, @idResource, @vK, @vSupplier_DD, @vSupplierCost_DD, @Note, @idBomPhase OUTPUT";


                //Output Params
                idBomPhase = (int?)p_idBomPhase.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Bom_ADD_PhaseMaterial(int? idUser, int? idBom, int? idBomPhase, int? idBomMaterial, ref int? idBomPhaseMaterial)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBom = new SqlParameter("@idBom", idBom.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBomPhase = new SqlParameter("@idBomPhase", idBomPhase.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBomMaterial = new SqlParameter("@idBomMaterial", idBomMaterial.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBomPhaseMaterial = new SqlParameter("@idBomPhaseMaterial", idBomPhaseMaterial.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Bom_ADD_PhaseMaterial] @idUser, @idBom, @idBomPhase, @idBomMaterial, @idBomPhaseMaterial OUTPUT";


                //Output Params
                idBomPhaseMaterial = (int?)p_idBomPhaseMaterial.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<Bom_CHECKResult>> Bom_CHECKAsync(int? idUser, int? idBom)
        {
            //Initialize Result 
            List<Bom_CHECKResult> lst = new List<Bom_CHECKResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBom = new SqlParameter("@idBom", idBom.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Bom_CHECK] @idUser, @idBom";

                //Output Data
                lst = await this.Bom_CHECK.FromSqlRaw(sqlQuery, p_idUser, p_idBom).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void Bom_CLEAR(int? idUser, int? idBom)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBom = new SqlParameter("@idBom", idBom.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Bom_CLEAR] @idUser, @idBom";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Bom_CLONE(int? idUser, int? idBom, string Code, string Bom, ref int? idBomOut)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBom = new SqlParameter("@idBom", idBom.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Code = new SqlParameter("@Code", Code.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Bom = new SqlParameter("@Bom", Bom.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBomOut = new SqlParameter("@idBomOut", idBomOut.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Bom_CLONE] @idUser, @idBom, @Code, @Bom, @idBomOut OUTPUT";


                //Output Params
                idBomOut = (int?)p_idBomOut.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Bom_DEL(int? idUser, int? idBom)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBom = new SqlParameter("@idBom", idBom.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Bom_DEL] @idUser, @idBom";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<Bom_GETResult>> Bom_GETAsync(int? idUser, int? idBom)
        {
            //Initialize Result 
            List<Bom_GETResult> lst = new List<Bom_GETResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBom = new SqlParameter("@idBom", idBom.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Bom_GET] @idUser, @idBom";

                //Output Data
                lst = await this.Bom_GET.FromSqlRaw(sqlQuery, p_idUser, p_idBom).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Bom_GET_MaterialResult>> Bom_GET_MaterialAsync(int? idUser, int? idBom)
        {
            //Initialize Result 
            List<Bom_GET_MaterialResult> lst = new List<Bom_GET_MaterialResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBom = new SqlParameter("@idBom", idBom.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Bom_GET_Material] @idUser, @idBom";

                //Output Data
                lst = await this.Bom_GET_Material.FromSqlRaw(sqlQuery, p_idUser, p_idBom).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Bom_GET_PhaseResult>> Bom_GET_PhaseAsync(int? idUser, int? idBom)
        {
            //Initialize Result 
            List<Bom_GET_PhaseResult> lst = new List<Bom_GET_PhaseResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBom = new SqlParameter("@idBom", idBom.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Bom_GET_Phase] @idUser, @idBom";

                //Output Data
                lst = await this.Bom_GET_Phase.FromSqlRaw(sqlQuery, p_idUser, p_idBom).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Bom_GET_PhaseMaterialResult>> Bom_GET_PhaseMaterialAsync(int? idUser, int? idBom)
        {
            //Initialize Result 
            List<Bom_GET_PhaseMaterialResult> lst = new List<Bom_GET_PhaseMaterialResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBom = new SqlParameter("@idBom", idBom.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Bom_GET_PhaseMaterial] @idUser, @idBom";

                //Output Data
                lst = await this.Bom_GET_PhaseMaterial.FromSqlRaw(sqlQuery, p_idUser, p_idBom).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void Bom_INITIALIZE(int? idUser, string Code, string Bom, int? idMaterial, ref int? idBom)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Code = new SqlParameter("@Code", Code.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Bom = new SqlParameter("@Bom", Bom.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBom = new SqlParameter("@idBom", idBom.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Bom_INITIALIZE] @idUser, @Code, @Bom, @idMaterial, @idBom OUTPUT";


                //Output Params
                idBom = (int?)p_idBom.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Bom_LOCK(int? idUser, int? idBom)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBom = new SqlParameter("@idBom", idBom.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Bom_LOCK] @idUser, @idBom";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Bom_UNLOCK(int? idUser, int? idBom)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBom = new SqlParameter("@idBom", idBom.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Bom_UNLOCK] @idUser, @idBom";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Bom_UPD_Header(int? idUser, int? idBom, string Bom, bool? isEnabled)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBom = new SqlParameter("@idBom", idBom.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Bom = new SqlParameter("@Bom", Bom.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isEnabled = new SqlParameter("@isEnabled", isEnabled.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Bom_UPD_Header] @idUser, @idBom, @Bom, @isEnabled";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Customer_ADD_Contact(int? idUser, int? idCustomer, string Title, string FirstName, string LastName, int? idWorkFunction, int? idWorkDepartment, bool? isDecisionMaker, string Tel1, string Mob1, string Email1, ref int? idContact)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCustomer = new SqlParameter("@idCustomer", idCustomer.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Title = new SqlParameter("@Title", Title.ToString() ?? (object)DBNull.Value);
                SqlParameter p_FirstName = new SqlParameter("@FirstName", FirstName.ToString() ?? (object)DBNull.Value);
                SqlParameter p_LastName = new SqlParameter("@LastName", LastName.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idWorkFunction = new SqlParameter("@idWorkFunction", idWorkFunction.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idWorkDepartment = new SqlParameter("@idWorkDepartment", idWorkDepartment.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isDecisionMaker = new SqlParameter("@isDecisionMaker", isDecisionMaker.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Tel1 = new SqlParameter("@Tel1", Tel1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Mob1 = new SqlParameter("@Mob1", Mob1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Email1 = new SqlParameter("@Email1", Email1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idContact = new SqlParameter("@idContact", idContact.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Customer_ADD_Contact] @idUser, @idCustomer, @Title, @FirstName, @LastName, @idWorkFunction, @idWorkDepartment, @isDecisionMaker, @Tel1, @Mob1, @Email1, @idContact OUTPUT";


                //Output Params
                idContact = (int?)p_idContact.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Customer_ADD_Division(int? idUser, int? idCustomer, int? idDivision)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCustomer = new SqlParameter("@idCustomer", idCustomer.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idDivision = new SqlParameter("@idDivision", idDivision.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Customer_ADD_Division] @idUser, @idCustomer, @idDivision";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Customer_ADD_UPD_BusinessPartner(ref int? idCustomerBusinessPartner, string ACT, string BusinessPartnerTypeCode, int? idCustomer, string BusinessName, string VAT, string FiscalCode, int? idCountry, string City, string Address, string ZIP, string Province, string TEL1, string TEL2, string MOB1, string MOB2, string Fax1, string Fax2, string Email1, string Email2, bool? isDeleted, string Ref1, string Ref2)
        {
            try
            {
                // Parameters
                SqlParameter p_idCustomerBusinessPartner = new SqlParameter("@idCustomerBusinessPartner", idCustomerBusinessPartner.ToString() ?? (object)DBNull.Value);
                SqlParameter p_ACT = new SqlParameter("@ACT", ACT.ToString() ?? (object)DBNull.Value);
                SqlParameter p_BusinessPartnerTypeCode = new SqlParameter("@BusinessPartnerTypeCode", BusinessPartnerTypeCode.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCustomer = new SqlParameter("@idCustomer", idCustomer.ToString() ?? (object)DBNull.Value);
                SqlParameter p_BusinessName = new SqlParameter("@BusinessName", BusinessName.ToString() ?? (object)DBNull.Value);
                SqlParameter p_VAT = new SqlParameter("@VAT", VAT.ToString() ?? (object)DBNull.Value);
                SqlParameter p_FiscalCode = new SqlParameter("@FiscalCode", FiscalCode.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCountry = new SqlParameter("@idCountry", idCountry.ToString() ?? (object)DBNull.Value);
                SqlParameter p_City = new SqlParameter("@City", City.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Address = new SqlParameter("@Address", Address.ToString() ?? (object)DBNull.Value);
                SqlParameter p_ZIP = new SqlParameter("@ZIP", ZIP.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Province = new SqlParameter("@Province", Province.ToString() ?? (object)DBNull.Value);
                SqlParameter p_TEL1 = new SqlParameter("@TEL1", TEL1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_TEL2 = new SqlParameter("@TEL2", TEL2.ToString() ?? (object)DBNull.Value);
                SqlParameter p_MOB1 = new SqlParameter("@MOB1", MOB1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_MOB2 = new SqlParameter("@MOB2", MOB2.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Fax1 = new SqlParameter("@Fax1", Fax1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Fax2 = new SqlParameter("@Fax2", Fax2.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Email1 = new SqlParameter("@Email1", Email1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Email2 = new SqlParameter("@Email2", Email2.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isDeleted = new SqlParameter("@isDeleted", isDeleted.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Ref1 = new SqlParameter("@Ref1", Ref1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Ref2 = new SqlParameter("@Ref2", Ref2.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Customer_ADD_UPD_BusinessPartner] @idCustomerBusinessPartner OUTPUT, @ACT, @BusinessPartnerTypeCode, @idCustomer, @BusinessName, @VAT, @FiscalCode, @idCountry, @City, @Address, @ZIP, @Province, @TEL1, @TEL2, @MOB1, @MOB2, @Fax1, @Fax2, @Email1, @Email2, @isDeleted, @Ref1, @Ref2";


                //Output Params
                idCustomerBusinessPartner = (int?)p_idCustomerBusinessPartner.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<Customer_CHECKResult>> Customer_CHECKAsync(int? idUser, int? idCustomer)
        {
            //Initialize Result 
            List<Customer_CHECKResult> lst = new List<Customer_CHECKResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCustomer = new SqlParameter("@idCustomer", idCustomer.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Customer_CHECK] @idUser, @idCustomer";

                //Output Data
                lst = await this.Customer_CHECK.FromSqlRaw(sqlQuery, p_idUser, p_idCustomer).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void Customer_CLEAR(int? idCustomer, int? idUserLastEdit)
        {
            try
            {
                // Parameters
                SqlParameter p_idCustomer = new SqlParameter("@idCustomer", idCustomer.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idUserLastEdit = new SqlParameter("@idUserLastEdit", idUserLastEdit.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Customer_CLEAR] @idCustomer, @idUserLastEdit";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Customer_DEL(int? idCustomer, int? idUserLastEdit)
        {
            try
            {
                // Parameters
                SqlParameter p_idCustomer = new SqlParameter("@idCustomer", idCustomer.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idUserLastEdit = new SqlParameter("@idUserLastEdit", idUserLastEdit.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Customer_DEL] @idCustomer, @idUserLastEdit";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Customer_DEL_BusinessPartner(int? idUser, int? idCustomer, int? idCustomerBusinessPartner)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCustomer = new SqlParameter("@idCustomer", idCustomer.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCustomerBusinessPartner = new SqlParameter("@idCustomerBusinessPartner", idCustomerBusinessPartner.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Customer_DEL_BusinessPartner] @idUser, @idCustomer, @idCustomerBusinessPartner";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Customer_DEL_Contact(int? idUser, int? idCustomer, int? idContact)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCustomer = new SqlParameter("@idCustomer", idCustomer.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idContact = new SqlParameter("@idContact", idContact.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Customer_DEL_Contact] @idUser, @idCustomer, @idContact";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<Customer_GETResult>> Customer_GETAsync(int? idUser, int? idCustomer)
        {
            //Initialize Result 
            List<Customer_GETResult> lst = new List<Customer_GETResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCustomer = new SqlParameter("@idCustomer", idCustomer.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Customer_GET] @idUser, @idCustomer";

                //Output Data
                lst = await this.Customer_GET.FromSqlRaw(sqlQuery, p_idUser, p_idCustomer).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Customer_GET_BusinessPartnerResult>> Customer_GET_BusinessPartnerAsync(int? idUser, int? idCustomer, string CodeBusinessPartner)
        {
            //Initialize Result 
            List<Customer_GET_BusinessPartnerResult> lst = new List<Customer_GET_BusinessPartnerResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCustomer = new SqlParameter("@idCustomer", idCustomer.ToString() ?? (object)DBNull.Value);
                SqlParameter p_CodeBusinessPartner = new SqlParameter("@CodeBusinessPartner", CodeBusinessPartner.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Customer_GET_BusinessPartner] @idUser, @idCustomer, @CodeBusinessPartner";

                //Output Data
                lst = await this.Customer_GET_BusinessPartner.FromSqlRaw(sqlQuery, p_idUser, p_idCustomer, p_CodeBusinessPartner).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Customer_GET_ContactResult>> Customer_GET_ContactAsync(int? idUser, int? idCustomer)
        {
            //Initialize Result 
            List<Customer_GET_ContactResult> lst = new List<Customer_GET_ContactResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCustomer = new SqlParameter("@idCustomer", idCustomer.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Customer_GET_Contact] @idUser, @idCustomer";

                //Output Data
                lst = await this.Customer_GET_Contact.FromSqlRaw(sqlQuery, p_idUser, p_idCustomer).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Customer_GET_DivisionResult>> Customer_GET_DivisionAsync(int? idUser, int? idCustomer)
        {
            //Initialize Result 
            List<Customer_GET_DivisionResult> lst = new List<Customer_GET_DivisionResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCustomer = new SqlParameter("@idCustomer", idCustomer.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Customer_GET_Division] @idUser, @idCustomer";

                //Output Data
                lst = await this.Customer_GET_Division.FromSqlRaw(sqlQuery, p_idUser, p_idCustomer).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void Customer_INITIALIZE(int? idUser, string BusinessName, string VAT, string FiscalCode, int? idCountry, int? idLead, ref int? idCustomer, ref string CodeCustomer)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_BusinessName = new SqlParameter("@BusinessName", BusinessName.ToString() ?? (object)DBNull.Value);
                SqlParameter p_VAT = new SqlParameter("@VAT", VAT.ToString() ?? (object)DBNull.Value);
                SqlParameter p_FiscalCode = new SqlParameter("@FiscalCode", FiscalCode.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCountry = new SqlParameter("@idCountry", idCountry.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idLead = new SqlParameter("@idLead", idLead.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCustomer = new SqlParameter("@idCustomer", idCustomer.ToString() ?? (object)DBNull.Value);
                SqlParameter p_CodeCustomer = new SqlParameter("@CodeCustomer", CodeCustomer.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Customer_INITIALIZE] @idUser, @BusinessName, @VAT, @FiscalCode, @idCountry, @idLead, @idCustomer OUTPUT, @CodeCustomer OUTPUT";


                //Output Params
                idCustomer = (int?)p_idCustomer.Value;
                CodeCustomer = (string)p_CodeCustomer.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Customer_LOCK(int? idUser, int? idCustomer)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCustomer = new SqlParameter("@idCustomer", idCustomer.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Customer_LOCK] @idUser, @idCustomer";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Customer_RECOVER(int? idCustomer, int? idUserLastEdit)
        {
            try
            {
                // Parameters
                SqlParameter p_idCustomer = new SqlParameter("@idCustomer", idCustomer.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idUserLastEdit = new SqlParameter("@idUserLastEdit", idUserLastEdit.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Customer_RECOVER] @idCustomer, @idUserLastEdit";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<Customer_SEARCHResult>> Customer_SEARCHAsync(int? idUser, int? flStock)
        {
            //Initialize Result 
            List<Customer_SEARCHResult> lst = new List<Customer_SEARCHResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_flStock = new SqlParameter("@flStock", flStock.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Customer_SEARCH] @idUser, @flStock";

                //Output Data
                lst = await this.Customer_SEARCH.FromSqlRaw(sqlQuery, p_idUser, p_flStock).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void Customer_UNLOCK(int? idUser, int? idCustomer)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCustomer = new SqlParameter("@idCustomer", idCustomer.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Customer_UNLOCK] @idUser, @idCustomer";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Customer_UPD(int? idCustomer, string BusinessName, string VAT, string FiscalCode, string City, string Address, string ZIP, int? idCountry, string Province, string TEL1, string TEL2, string MOB1, string MOB2, string Fax1, string Fax2, string Email1, string Email2, int? idUserLastEdit, bool? isInternalCustomer, int? idCompanySector, int? idPaymentType)
        {
            try
            {
                // Parameters
                SqlParameter p_idCustomer = new SqlParameter("@idCustomer", idCustomer.ToString() ?? (object)DBNull.Value);
                SqlParameter p_BusinessName = new SqlParameter("@BusinessName", BusinessName.ToString() ?? (object)DBNull.Value);
                SqlParameter p_VAT = new SqlParameter("@VAT", VAT.ToString() ?? (object)DBNull.Value);
                SqlParameter p_FiscalCode = new SqlParameter("@FiscalCode", FiscalCode.ToString() ?? (object)DBNull.Value);
                SqlParameter p_City = new SqlParameter("@City", City.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Address = new SqlParameter("@Address", Address.ToString() ?? (object)DBNull.Value);
                SqlParameter p_ZIP = new SqlParameter("@ZIP", ZIP.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCountry = new SqlParameter("@idCountry", idCountry.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Province = new SqlParameter("@Province", Province.ToString() ?? (object)DBNull.Value);
                SqlParameter p_TEL1 = new SqlParameter("@TEL1", TEL1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_TEL2 = new SqlParameter("@TEL2", TEL2.ToString() ?? (object)DBNull.Value);
                SqlParameter p_MOB1 = new SqlParameter("@MOB1", MOB1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_MOB2 = new SqlParameter("@MOB2", MOB2.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Fax1 = new SqlParameter("@Fax1", Fax1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Fax2 = new SqlParameter("@Fax2", Fax2.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Email1 = new SqlParameter("@Email1", Email1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Email2 = new SqlParameter("@Email2", Email2.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idUserLastEdit = new SqlParameter("@idUserLastEdit", idUserLastEdit.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isInternalCustomer = new SqlParameter("@isInternalCustomer", isInternalCustomer.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCompanySector = new SqlParameter("@idCompanySector", idCompanySector.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idPaymentType = new SqlParameter("@idPaymentType", idPaymentType.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Customer_UPD] @idCustomer, @BusinessName, @VAT, @FiscalCode, @City, @Address, @ZIP, @idCountry, @Province, @TEL1, @TEL2, @MOB1, @MOB2, @Fax1, @Fax2, @Email1, @Email2, @idUserLastEdit, @isInternalCustomer, @idCompanySector, @idPaymentType";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Customer_UPD_Contact(int? idUser, int? idCustomer, int? idContact, string Title, string FirstName, string LastName, int? idWorkFunction, int? idWorkDepartment, bool? isDecisionMaker, string Tel1, string Mob1, string Email1, bool? isDefault)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCustomer = new SqlParameter("@idCustomer", idCustomer.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idContact = new SqlParameter("@idContact", idContact.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Title = new SqlParameter("@Title", Title.ToString() ?? (object)DBNull.Value);
                SqlParameter p_FirstName = new SqlParameter("@FirstName", FirstName.ToString() ?? (object)DBNull.Value);
                SqlParameter p_LastName = new SqlParameter("@LastName", LastName.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idWorkFunction = new SqlParameter("@idWorkFunction", idWorkFunction.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idWorkDepartment = new SqlParameter("@idWorkDepartment", idWorkDepartment.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isDecisionMaker = new SqlParameter("@isDecisionMaker", isDecisionMaker.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Tel1 = new SqlParameter("@Tel1", Tel1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Mob1 = new SqlParameter("@Mob1", Mob1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Email1 = new SqlParameter("@Email1", Email1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isDefault = new SqlParameter("@isDefault", isDefault.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Customer_UPD_Contact] @idUser, @idCustomer, @idContact, @Title, @FirstName, @LastName, @idWorkFunction, @idWorkDepartment, @isDecisionMaker, @Tel1, @Mob1, @Email1, @isDefault";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<CustomerContact_GET_DetailResult>> CustomerContact_GET_DetailAsync(int? idUser, int? idCustomer, int? idCustomerContact)
        {
            //Initialize Result 
            List<CustomerContact_GET_DetailResult> lst = new List<CustomerContact_GET_DetailResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCustomer = new SqlParameter("@idCustomer", idCustomer.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCustomerContact = new SqlParameter("@idCustomerContact", idCustomerContact.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[CustomerContact_GET_Detail] @idUser, @idCustomer, @idCustomerContact";

                //Output Data
                lst = await this.CustomerContact_GET_Detail.FromSqlRaw(sqlQuery, p_idUser, p_idCustomer, p_idCustomerContact).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void Document_ADD(int? idUser, string EntityCode, int? idEntity, string Name, string Description, string FolderPath, string FileUrl, string FileName, string FileName_NoExt, string FileExt, ref int? idDocument)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_EntityCode = new SqlParameter("@EntityCode", EntityCode.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idEntity = new SqlParameter("@idEntity", idEntity.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Name = new SqlParameter("@Name", Name.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Description = new SqlParameter("@Description", Description.ToString() ?? (object)DBNull.Value);
                SqlParameter p_FolderPath = new SqlParameter("@FolderPath", FolderPath.ToString() ?? (object)DBNull.Value);
                SqlParameter p_FileUrl = new SqlParameter("@FileUrl", FileUrl.ToString() ?? (object)DBNull.Value);
                SqlParameter p_FileName = new SqlParameter("@FileName", FileName.ToString() ?? (object)DBNull.Value);
                SqlParameter p_FileName_NoExt = new SqlParameter("@FileName_NoExt", FileName_NoExt.ToString() ?? (object)DBNull.Value);
                SqlParameter p_FileExt = new SqlParameter("@FileExt", FileExt.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idDocument = new SqlParameter("@idDocument", idDocument.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Document_ADD] @idUser, @EntityCode, @idEntity, @Name, @Description, @FolderPath, @FileUrl, @FileName, @FileName_NoExt, @FileExt, @idDocument OUTPUT";


                //Output Params
                idDocument = (int?)p_idDocument.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Document_DEL(int? idUser, int? idDocument)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idDocument = new SqlParameter("@idDocument", idDocument.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Document_DEL] @idUser, @idDocument";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<Document_GET_DetailResult>> Document_GET_DetailAsync(int? idUser, int? idDocument)
        {
            //Initialize Result 
            List<Document_GET_DetailResult> lst = new List<Document_GET_DetailResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idDocument = new SqlParameter("@idDocument", idDocument.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Document_GET_Detail] @idUser, @idDocument";

                //Output Data
                lst = await this.Document_GET_Detail.FromSqlRaw(sqlQuery, p_idUser, p_idDocument).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Document_SEARCHResult>> Document_SEARCHAsync(int? idUser, int? idEntityType, int? idEntity)
        {
            //Initialize Result 
            List<Document_SEARCHResult> lst = new List<Document_SEARCHResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idEntityType = new SqlParameter("@idEntityType", idEntityType.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idEntity = new SqlParameter("@idEntity", idEntity.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Document_SEARCH] @idUser, @idEntityType, @idEntity";

                //Output Data
                lst = await this.Document_SEARCH.FromSqlRaw(sqlQuery, p_idUser, p_idEntityType, p_idEntity).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Lock_GETResult>> Lock_GETAsync(int? idUser)
        {
            //Initialize Result 
            List<Lock_GETResult> lst = new List<Lock_GETResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Lock_GET] @idUser";

                //Output Data
                lst = await this.Lock_GET.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void Material_ADD_MaterialFormat(int? idUser, int? idMaterial, int? idUnitSelling, int? Decimals, decimal? vQtyBase, decimal? vQtyBox, decimal? vQtyMin, decimal? vQtyMax, decimal? vQtyMulti, decimal? vPriceWhosaler, decimal? vPriceCustomer, ref int? idMaterialFormat)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idUnitSelling = new SqlParameter("@idUnitSelling", idUnitSelling.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Decimals = new SqlParameter("@Decimals", Decimals.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vQtyBase = new SqlParameter("@vQtyBase", vQtyBase.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vQtyBox = new SqlParameter("@vQtyBox", vQtyBox.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vQtyMin = new SqlParameter("@vQtyMin", vQtyMin.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vQtyMax = new SqlParameter("@vQtyMax", vQtyMax.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vQtyMulti = new SqlParameter("@vQtyMulti", vQtyMulti.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vPriceWhosaler = new SqlParameter("@vPriceWhosaler", vPriceWhosaler.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vPriceCustomer = new SqlParameter("@vPriceCustomer", vPriceCustomer.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterialFormat = new SqlParameter("@idMaterialFormat", idMaterialFormat.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Material_ADD_MaterialFormat] @idUser, @idMaterial, @idUnitSelling, @Decimals, @vQtyBase, @vQtyBox, @vQtyMin, @vQtyMax, @vQtyMulti, @vPriceWhosaler, @vPriceCustomer, @idMaterialFormat OUTPUT";


                //Output Params
                idMaterialFormat = (int?)p_idMaterialFormat.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<Material_CHECKResult>> Material_CHECKAsync(int? idUser, int? idMaterial)
        {
            //Initialize Result 
            List<Material_CHECKResult> lst = new List<Material_CHECKResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Material_CHECK] @idUser, @idMaterial";

                //Output Data
                lst = await this.Material_CHECK.FromSqlRaw(sqlQuery, p_idUser, p_idMaterial).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Material_CHECK_RecursionResult>> Material_CHECK_RecursionAsync(int? idUser, int? idMaterial)
        {
            //Initialize Result 
            List<Material_CHECK_RecursionResult> lst = new List<Material_CHECK_RecursionResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Material_CHECK_Recursion] @idUser, @idMaterial";

                //Output Data
                lst = await this.Material_CHECK_Recursion.FromSqlRaw(sqlQuery, p_idUser, p_idMaterial).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void Material_CLEAR(int? idUser, int? idMaterial)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Material_CLEAR] @idUser, @idMaterial";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Material_CLEAR_MaterialFormat(int? idUser, int? idMaterial)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Material_CLEAR_MaterialFormat] @idUser, @idMaterial";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Material_CLONE(int? idUser, int? idMaterial, string Code, string Material, ref int? idMaterialOut)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Code = new SqlParameter("@Code", Code.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Material = new SqlParameter("@Material", Material.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterialOut = new SqlParameter("@idMaterialOut", idMaterialOut.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Material_CLONE] @idUser, @idMaterial, @Code, @Material, @idMaterialOut OUTPUT";


                //Output Params
                idMaterialOut = (int?)p_idMaterialOut.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Material_DEL(int? idUser, int? idMaterial)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Material_DEL] @idUser, @idMaterial";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<Material_GETResult>> Material_GETAsync(int? idUser, int? idMaterial)
        {
            //Initialize Result 
            List<Material_GETResult> lst = new List<Material_GETResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Material_GET] @idUser, @idMaterial";

                //Output Data
                lst = await this.Material_GET.FromSqlRaw(sqlQuery, p_idUser, p_idMaterial).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Material_GET_BomResult>> Material_GET_BomAsync(int? idUser, int? idMaterial, bool? includeDisabled, bool? includeDeleted)
        {
            //Initialize Result 
            List<Material_GET_BomResult> lst = new List<Material_GET_BomResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);
                SqlParameter p_includeDisabled = new SqlParameter("@includeDisabled", includeDisabled.ToString() ?? (object)DBNull.Value);
                SqlParameter p_includeDeleted = new SqlParameter("@includeDeleted", includeDeleted.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Material_GET_Bom] @idUser, @idMaterial, @includeDisabled, @includeDeleted";

                //Output Data
                lst = await this.Material_GET_Bom.FromSqlRaw(sqlQuery, p_idUser, p_idMaterial, p_includeDisabled, p_includeDeleted).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Material_GET_MaterialFormatResult>> Material_GET_MaterialFormatAsync(int? idUser, int? idMaterial)
        {
            //Initialize Result 
            List<Material_GET_MaterialFormatResult> lst = new List<Material_GET_MaterialFormatResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Material_GET_MaterialFormat] @idUser, @idMaterial";

                //Output Data
                lst = await this.Material_GET_MaterialFormat.FromSqlRaw(sqlQuery, p_idUser, p_idMaterial).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Material_GET_MaterialWarehouseResult>> Material_GET_MaterialWarehouseAsync(int? idUser, int? idMaterial)
        {
            //Initialize Result 
            List<Material_GET_MaterialWarehouseResult> lst = new List<Material_GET_MaterialWarehouseResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Material_GET_MaterialWarehouse] @idUser, @idMaterial";

                //Output Data
                lst = await this.Material_GET_MaterialWarehouse.FromSqlRaw(sqlQuery, p_idUser, p_idMaterial).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Material_GET_USAGE_MaterialResult>> Material_GET_USAGE_MaterialAsync(int? idUser, int? idMaterial)
        {
            //Initialize Result 
            List<Material_GET_USAGE_MaterialResult> lst = new List<Material_GET_USAGE_MaterialResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Material_GET_USAGE_Material] @idUser, @idMaterial";

                //Output Data
                lst = await this.Material_GET_USAGE_Material.FromSqlRaw(sqlQuery, p_idUser, p_idMaterial).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void Material_INITIALIZE(int? idUser, string Code, string Material, int? idMaterialClass, int? idUnitSelling, ref int? idMaterial)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Code = new SqlParameter("@Code", Code.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Material = new SqlParameter("@Material", Material.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterialClass = new SqlParameter("@idMaterialClass", idMaterialClass.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idUnitSelling = new SqlParameter("@idUnitSelling", idUnitSelling.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Material_INITIALIZE] @idUser, @Code, @Material, @idMaterialClass, @idUnitSelling, @idMaterial OUTPUT";


                //Output Params
                idMaterial = (int?)p_idMaterial.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Material_LOCK(int? idUser, int? idMaterial)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Material_LOCK] @idUser, @idMaterial";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<Material_SEARCHResult>> Material_SEARCHAsync(int? idUser, int? includeNotClassified, int? idMaterialDest, int? flStock)
        {
            //Initialize Result 
            List<Material_SEARCHResult> lst = new List<Material_SEARCHResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_includeNotClassified = new SqlParameter("@includeNotClassified", includeNotClassified.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterialDest = new SqlParameter("@idMaterialDest", idMaterialDest.ToString() ?? (object)DBNull.Value);
                SqlParameter p_flStock = new SqlParameter("@flStock", flStock.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Material_SEARCH] @idUser, @includeNotClassified, @idMaterialDest, @flStock";

                //Output Data
                lst = await this.Material_SEARCH.FromSqlRaw(sqlQuery, p_idUser, p_includeNotClassified, p_idMaterialDest, p_flStock).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void Material_SET_Bom(int? idUser, int? idMaterial, int? idBom)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBom = new SqlParameter("@idBom", idBom.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Material_SET_Bom] @idUser, @idMaterial, @idBom";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Material_UNLOCK(int? idUser, int? idMaterial)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Material_UNLOCK] @idUser, @idMaterial";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Material_UPD_Header(int? idUser, int? idMaterial, int? idBom, string Material, int? idMaterialClass, int? idMaterialSector, decimal? Height, decimal? Width, decimal? Lenght, decimal? Weight, int? idMaterialType, int? idMaterialShape, int? idMaterialStatus, decimal? vQtyBase, decimal? vQtyBox, decimal? vQtyMin, decimal? vQtyMax, decimal? vQtyMulti, decimal? vPrice, string Ean, string Electrocode, string Etim, string Barcode, string BarcodeType, int? idSupplier, bool? isEnabled, string Note)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idBom = new SqlParameter("@idBom", idBom.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Material = new SqlParameter("@Material", Material.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterialClass = new SqlParameter("@idMaterialClass", idMaterialClass.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterialSector = new SqlParameter("@idMaterialSector", idMaterialSector.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Height = new SqlParameter("@Height", Height.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Width = new SqlParameter("@Width", Width.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Lenght = new SqlParameter("@Lenght", Lenght.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Weight = new SqlParameter("@Weight", Weight.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterialType = new SqlParameter("@idMaterialType", idMaterialType.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterialShape = new SqlParameter("@idMaterialShape", idMaterialShape.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterialStatus = new SqlParameter("@idMaterialStatus", idMaterialStatus.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vQtyBase = new SqlParameter("@vQtyBase", vQtyBase.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vQtyBox = new SqlParameter("@vQtyBox", vQtyBox.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vQtyMin = new SqlParameter("@vQtyMin", vQtyMin.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vQtyMax = new SqlParameter("@vQtyMax", vQtyMax.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vQtyMulti = new SqlParameter("@vQtyMulti", vQtyMulti.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vPrice = new SqlParameter("@vPrice", vPrice.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Ean = new SqlParameter("@Ean", Ean.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Electrocode = new SqlParameter("@Electrocode", Electrocode.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Etim = new SqlParameter("@Etim", Etim.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Barcode = new SqlParameter("@Barcode", Barcode.ToString() ?? (object)DBNull.Value);
                SqlParameter p_BarcodeType = new SqlParameter("@BarcodeType", BarcodeType.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isEnabled = new SqlParameter("@isEnabled", isEnabled.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Note = new SqlParameter("@Note", Note.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Material_UPD_Header] @idUser, @idMaterial, @idBom, @Material, @idMaterialClass, @idMaterialSector, @Height, @Width, @Lenght, @Weight, @idMaterialType, @idMaterialShape, @idMaterialStatus, @vQtyBase, @vQtyBox, @vQtyMin, @vQtyMax, @vQtyMulti, @vPrice, @Ean, @Electrocode, @Etim, @Barcode, @BarcodeType, @idSupplier, @isEnabled, @Note";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void MD_ADD_CompanySector(int? idUser, string Code, string CompanySector, int? intOrder, ref int? idNew)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Code = new SqlParameter("@Code", Code.ToString() ?? (object)DBNull.Value);
                SqlParameter p_CompanySector = new SqlParameter("@CompanySector", CompanySector.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intOrder = new SqlParameter("@intOrder", intOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idNew = new SqlParameter("@idNew", idNew.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_ADD_CompanySector] @idUser, @Code, @CompanySector, @intOrder, @idNew OUTPUT";


                //Output Params
                idNew = (int?)p_idNew.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void MD_ADD_Division(int? idUser, string Code, string Division, int? intOrder, ref int? idNew)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Code = new SqlParameter("@Code", Code.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Division = new SqlParameter("@Division", Division.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intOrder = new SqlParameter("@intOrder", intOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idNew = new SqlParameter("@idNew", idNew.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_ADD_Division] @idUser, @Code, @Division, @intOrder, @idNew OUTPUT";


                //Output Params
                idNew = (int?)p_idNew.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void MD_ADD_MaterialSector(int? idUser, string Code, string MaterialSector, int? intOrder, ref int? idNew)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Code = new SqlParameter("@Code", Code.ToString() ?? (object)DBNull.Value);
                SqlParameter p_MaterialSector = new SqlParameter("@MaterialSector", MaterialSector.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intOrder = new SqlParameter("@intOrder", intOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idNew = new SqlParameter("@idNew", idNew.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_ADD_MaterialSector] @idUser, @Code, @MaterialSector, @intOrder, @idNew OUTPUT";


                //Output Params
                idNew = (int?)p_idNew.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void MD_ADD_MaterialShape(int? idUser, string Code, string MaterialShape, int? intOrder, decimal? d1, decimal? d2, decimal? d3, int? idDimensionFormulaUm, int? idFormula, decimal? Area, int? idAreaFormulaUm, ref int? idNew)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Code = new SqlParameter("@Code", Code.ToString() ?? (object)DBNull.Value);
                SqlParameter p_MaterialShape = new SqlParameter("@MaterialShape", MaterialShape.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intOrder = new SqlParameter("@intOrder", intOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_d1 = new SqlParameter("@d1", d1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_d2 = new SqlParameter("@d2", d2.ToString() ?? (object)DBNull.Value);
                SqlParameter p_d3 = new SqlParameter("@d3", d3.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idDimensionFormulaUm = new SqlParameter("@idDimensionFormulaUm", idDimensionFormulaUm.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idFormula = new SqlParameter("@idFormula", idFormula.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Area = new SqlParameter("@Area", Area.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idAreaFormulaUm = new SqlParameter("@idAreaFormulaUm", idAreaFormulaUm.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idNew = new SqlParameter("@idNew", idNew.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_ADD_MaterialShape] @idUser, @Code, @MaterialShape, @intOrder, @d1, @d2, @d3, @idDimensionFormulaUm, @idFormula, @Area, @idAreaFormulaUm, @idNew OUTPUT";


                //Output Params
                idNew = (int?)p_idNew.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void MD_ADD_MaterialType(int? idUser, string Code, string MaterialType, decimal? SpecificWeight, int? intOrder, ref int? idNew)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Code = new SqlParameter("@Code", Code.ToString() ?? (object)DBNull.Value);
                SqlParameter p_MaterialType = new SqlParameter("@MaterialType", MaterialType.ToString() ?? (object)DBNull.Value);
                SqlParameter p_SpecificWeight = new SqlParameter("@SpecificWeight", SpecificWeight.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intOrder = new SqlParameter("@intOrder", intOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idNew = new SqlParameter("@idNew", idNew.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_ADD_MaterialType] @idUser, @Code, @MaterialType, @SpecificWeight, @intOrder, @idNew OUTPUT";


                //Output Params
                idNew = (int?)p_idNew.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void MD_ADD_PaymentType(int? idUser, string Code, string PaymentType, int? intOrder, ref int? idNew)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Code = new SqlParameter("@Code", Code.ToString() ?? (object)DBNull.Value);
                SqlParameter p_PaymentType = new SqlParameter("@PaymentType", PaymentType.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intOrder = new SqlParameter("@intOrder", intOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idNew = new SqlParameter("@idNew", idNew.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_ADD_PaymentType] @idUser, @Code, @PaymentType, @intOrder, @idNew OUTPUT";


                //Output Params
                idNew = (int?)p_idNew.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void MD_ADD_ResourceGroup(int? idUser, string Code, string ResourceGroup, int? intOrder, ref int? idNew)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Code = new SqlParameter("@Code", Code.ToString() ?? (object)DBNull.Value);
                SqlParameter p_ResourceGroup = new SqlParameter("@ResourceGroup", ResourceGroup.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intOrder = new SqlParameter("@intOrder", intOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idNew = new SqlParameter("@idNew", idNew.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_ADD_ResourceGroup] @idUser, @Code, @ResourceGroup, @intOrder, @idNew OUTPUT";


                //Output Params
                idNew = (int?)p_idNew.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void MD_ADD_ResourceType(int? idUser, string Code, string ResourceType, int? intOrder, ref int? idNew)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Code = new SqlParameter("@Code", Code.ToString() ?? (object)DBNull.Value);
                SqlParameter p_ResourceType = new SqlParameter("@ResourceType", ResourceType.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intOrder = new SqlParameter("@intOrder", intOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idNew = new SqlParameter("@idNew", idNew.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_ADD_ResourceType] @idUser, @Code, @ResourceType, @intOrder, @idNew OUTPUT";


                //Output Params
                idNew = (int?)p_idNew.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void MD_ADD_WorkDepartment(int? idUser, string Code, string WorkDepartment, int? intOrder, ref int? idNew)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Code = new SqlParameter("@Code", Code.ToString() ?? (object)DBNull.Value);
                SqlParameter p_WorkDepartment = new SqlParameter("@WorkDepartment", WorkDepartment.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intOrder = new SqlParameter("@intOrder", intOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idNew = new SqlParameter("@idNew", idNew.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_ADD_WorkDepartment] @idUser, @Code, @WorkDepartment, @intOrder, @idNew OUTPUT";


                //Output Params
                idNew = (int?)p_idNew.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void MD_ADD_WorkFunction(int? idUser, string Code, string WorkFunction, int? intOrder, ref int? idNew)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Code = new SqlParameter("@Code", Code.ToString() ?? (object)DBNull.Value);
                SqlParameter p_WorkFunction = new SqlParameter("@WorkFunction", WorkFunction.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intOrder = new SqlParameter("@intOrder", intOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idNew = new SqlParameter("@idNew", idNew.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_ADD_WorkFunction] @idUser, @Code, @WorkFunction, @intOrder, @idNew OUTPUT";


                //Output Params
                idNew = (int?)p_idNew.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<MD_GET_CompanySectorResult>> MD_GET_CompanySectorAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_CompanySectorResult> lst = new List<MD_GET_CompanySectorResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_CompanySector] @idUser";

                //Output Data
                lst = await this.MD_GET_CompanySector.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_CountryResult>> MD_GET_CountryAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_CountryResult> lst = new List<MD_GET_CountryResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_Country] @idUser";

                //Output Data
                lst = await this.MD_GET_Country.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_CultureResult>> MD_GET_CultureAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_CultureResult> lst = new List<MD_GET_CultureResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_Culture] @idUser";

                //Output Data
                lst = await this.MD_GET_Culture.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_CurrencyResult>> MD_GET_CurrencyAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_CurrencyResult> lst = new List<MD_GET_CurrencyResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_Currency] @idUser";

                //Output Data
                lst = await this.MD_GET_Currency.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_DivisionResult>> MD_GET_DivisionAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_DivisionResult> lst = new List<MD_GET_DivisionResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_Division] @idUser";

                //Output Data
                lst = await this.MD_GET_Division.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_EntityTypeResult>> MD_GET_EntityTypeAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_EntityTypeResult> lst = new List<MD_GET_EntityTypeResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_EntityType] @idUser";

                //Output Data
                lst = await this.MD_GET_EntityType.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_FormulaResult>> MD_GET_FormulaAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_FormulaResult> lst = new List<MD_GET_FormulaResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_Formula] @idUser";

                //Output Data
                lst = await this.MD_GET_Formula.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_FormulaUmResult>> MD_GET_FormulaUmAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_FormulaUmResult> lst = new List<MD_GET_FormulaUmResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_FormulaUm] @idUser";

                //Output Data
                lst = await this.MD_GET_FormulaUm.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_IncotermResult>> MD_GET_IncotermAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_IncotermResult> lst = new List<MD_GET_IncotermResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_Incoterm] @idUser";

                //Output Data
                lst = await this.MD_GET_Incoterm.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_LanguageResult>> MD_GET_LanguageAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_LanguageResult> lst = new List<MD_GET_LanguageResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_Language] @idUser";

                //Output Data
                lst = await this.MD_GET_Language.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_MaterialClassResult>> MD_GET_MaterialClassAsync(int? idUser, int? idMaterialDest)
        {
            //Initialize Result 
            List<MD_GET_MaterialClassResult> lst = new List<MD_GET_MaterialClassResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterialDest = new SqlParameter("@idMaterialDest", idMaterialDest.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_MaterialClass] @idUser, @idMaterialDest";

                //Output Data
                lst = await this.MD_GET_MaterialClass.FromSqlRaw(sqlQuery, p_idUser, p_idMaterialDest).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_MaterialSectorResult>> MD_GET_MaterialSectorAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_MaterialSectorResult> lst = new List<MD_GET_MaterialSectorResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_MaterialSector] @idUser";

                //Output Data
                lst = await this.MD_GET_MaterialSector.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_MaterialShapeResult>> MD_GET_MaterialShapeAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_MaterialShapeResult> lst = new List<MD_GET_MaterialShapeResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_MaterialShape] @idUser";

                //Output Data
                lst = await this.MD_GET_MaterialShape.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_MaterialStatusResult>> MD_GET_MaterialStatusAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_MaterialStatusResult> lst = new List<MD_GET_MaterialStatusResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_MaterialStatus] @idUser";

                //Output Data
                lst = await this.MD_GET_MaterialStatus.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_MaterialTypeResult>> MD_GET_MaterialTypeAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_MaterialTypeResult> lst = new List<MD_GET_MaterialTypeResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_MaterialType] @idUser";

                //Output Data
                lst = await this.MD_GET_MaterialType.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_PaymentTypeResult>> MD_GET_PaymentTypeAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_PaymentTypeResult> lst = new List<MD_GET_PaymentTypeResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_PaymentType] @idUser";

                //Output Data
                lst = await this.MD_GET_PaymentType.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_PhaseCalculationResult>> MD_GET_PhaseCalculationAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_PhaseCalculationResult> lst = new List<MD_GET_PhaseCalculationResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_PhaseCalculation] @idUser";

                //Output Data
                lst = await this.MD_GET_PhaseCalculation.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_PhaseTypeResult>> MD_GET_PhaseTypeAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_PhaseTypeResult> lst = new List<MD_GET_PhaseTypeResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_PhaseType] @idUser";

                //Output Data
                lst = await this.MD_GET_PhaseType.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_ResourceGroupResult>> MD_GET_ResourceGroupAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_ResourceGroupResult> lst = new List<MD_GET_ResourceGroupResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_ResourceGroup] @idUser";

                //Output Data
                lst = await this.MD_GET_ResourceGroup.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_ResourceTypeResult>> MD_GET_ResourceTypeAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_ResourceTypeResult> lst = new List<MD_GET_ResourceTypeResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_ResourceType] @idUser";

                //Output Data
                lst = await this.MD_GET_ResourceType.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_SalesAreaResult>> MD_GET_SalesAreaAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_SalesAreaResult> lst = new List<MD_GET_SalesAreaResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_SalesArea] @idUser";

                //Output Data
                lst = await this.MD_GET_SalesArea.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_StockMovementStatusResult>> MD_GET_StockMovementStatusAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_StockMovementStatusResult> lst = new List<MD_GET_StockMovementStatusResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_StockMovementStatus] @idUser";

                //Output Data
                lst = await this.MD_GET_StockMovementStatus.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_StockMovementTypeResult>> MD_GET_StockMovementTypeAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_StockMovementTypeResult> lst = new List<MD_GET_StockMovementTypeResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_StockMovementType] @idUser";

                //Output Data
                lst = await this.MD_GET_StockMovementType.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_SupplierTypeResult>> MD_GET_SupplierTypeAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_SupplierTypeResult> lst = new List<MD_GET_SupplierTypeResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_SupplierType] @idUser";

                //Output Data
                lst = await this.MD_GET_SupplierType.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_TimeZoneResult>> MD_GET_TimeZoneAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_TimeZoneResult> lst = new List<MD_GET_TimeZoneResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_TimeZone] @idUser";

                //Output Data
                lst = await this.MD_GET_TimeZone.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_UnitMeasureResult>> MD_GET_UnitMeasureAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_UnitMeasureResult> lst = new List<MD_GET_UnitMeasureResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_UnitMeasure] @idUser";

                //Output Data
                lst = await this.MD_GET_UnitMeasure.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_UnitSellingResult>> MD_GET_UnitSellingAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_UnitSellingResult> lst = new List<MD_GET_UnitSellingResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_UnitSelling] @idUser";

                //Output Data
                lst = await this.MD_GET_UnitSelling.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_WorkDepartmentResult>> MD_GET_WorkDepartmentAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_WorkDepartmentResult> lst = new List<MD_GET_WorkDepartmentResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_WorkDepartment] @idUser";

                //Output Data
                lst = await this.MD_GET_WorkDepartment.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<MD_GET_WorkFunctionResult>> MD_GET_WorkFunctionAsync(int? idUser)
        {
            //Initialize Result 
            List<MD_GET_WorkFunctionResult> lst = new List<MD_GET_WorkFunctionResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_GET_WorkFunction] @idUser";

                //Output Data
                lst = await this.MD_GET_WorkFunction.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void MD_UPD_CompanySector(int? idUser, int? idCompanySector, string CompanySector, int? intOrder, bool? isEnabled)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCompanySector = new SqlParameter("@idCompanySector", idCompanySector.ToString() ?? (object)DBNull.Value);
                SqlParameter p_CompanySector = new SqlParameter("@CompanySector", CompanySector.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intOrder = new SqlParameter("@intOrder", intOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isEnabled = new SqlParameter("@isEnabled", isEnabled.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_UPD_CompanySector] @idUser, @idCompanySector, @CompanySector, @intOrder, @isEnabled";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void MD_UPD_Division(int? idUser, int? idDivision, string Division, int? intOrder, bool? isEnabled)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idDivision = new SqlParameter("@idDivision", idDivision.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Division = new SqlParameter("@Division", Division.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intOrder = new SqlParameter("@intOrder", intOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isEnabled = new SqlParameter("@isEnabled", isEnabled.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_UPD_Division] @idUser, @idDivision, @Division, @intOrder, @isEnabled";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void MD_UPD_MaterialSector(int? idUser, int? idMaterialSector, string MaterialSector, int? intOrder, bool? isEnabled)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterialSector = new SqlParameter("@idMaterialSector", idMaterialSector.ToString() ?? (object)DBNull.Value);
                SqlParameter p_MaterialSector = new SqlParameter("@MaterialSector", MaterialSector.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intOrder = new SqlParameter("@intOrder", intOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isEnabled = new SqlParameter("@isEnabled", isEnabled.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_UPD_MaterialSector] @idUser, @idMaterialSector, @MaterialSector, @intOrder, @isEnabled";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void MD_UPD_MaterialShape(int? idUser, int? idMaterialShape, string MaterialShape, int? intOrder, bool? isEnabled, decimal? d1, decimal? d2, decimal? d3, int? idDimensionFormulaUm, int? idFormula, decimal? Area, int? idAreaFormulaUm, ref int? idNew)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterialShape = new SqlParameter("@idMaterialShape", idMaterialShape.ToString() ?? (object)DBNull.Value);
                SqlParameter p_MaterialShape = new SqlParameter("@MaterialShape", MaterialShape.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intOrder = new SqlParameter("@intOrder", intOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isEnabled = new SqlParameter("@isEnabled", isEnabled.ToString() ?? (object)DBNull.Value);
                SqlParameter p_d1 = new SqlParameter("@d1", d1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_d2 = new SqlParameter("@d2", d2.ToString() ?? (object)DBNull.Value);
                SqlParameter p_d3 = new SqlParameter("@d3", d3.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idDimensionFormulaUm = new SqlParameter("@idDimensionFormulaUm", idDimensionFormulaUm.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idFormula = new SqlParameter("@idFormula", idFormula.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Area = new SqlParameter("@Area", Area.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idAreaFormulaUm = new SqlParameter("@idAreaFormulaUm", idAreaFormulaUm.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idNew = new SqlParameter("@idNew", idNew.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_UPD_MaterialShape] @idUser, @idMaterialShape, @MaterialShape, @intOrder, @isEnabled, @d1, @d2, @d3, @idDimensionFormulaUm, @idFormula, @Area, @idAreaFormulaUm, @idNew OUTPUT";


                //Output Params
                idNew = (int?)p_idNew.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void MD_UPD_MaterialType(int? idUser, int? idMaterialType, string MaterialType, decimal? SpecificWeight, int? intOrder, bool? isEnabled)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterialType = new SqlParameter("@idMaterialType", idMaterialType.ToString() ?? (object)DBNull.Value);
                SqlParameter p_MaterialType = new SqlParameter("@MaterialType", MaterialType.ToString() ?? (object)DBNull.Value);
                SqlParameter p_SpecificWeight = new SqlParameter("@SpecificWeight", SpecificWeight.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intOrder = new SqlParameter("@intOrder", intOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isEnabled = new SqlParameter("@isEnabled", isEnabled.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_UPD_MaterialType] @idUser, @idMaterialType, @MaterialType, @SpecificWeight, @intOrder, @isEnabled";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void MD_UPD_PaymentType(int? idUser, int? idPaymentType, string PaymentType, int? intOrder, bool? isEnabled)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idPaymentType = new SqlParameter("@idPaymentType", idPaymentType.ToString() ?? (object)DBNull.Value);
                SqlParameter p_PaymentType = new SqlParameter("@PaymentType", PaymentType.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intOrder = new SqlParameter("@intOrder", intOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isEnabled = new SqlParameter("@isEnabled", isEnabled.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_UPD_PaymentType] @idUser, @idPaymentType, @PaymentType, @intOrder, @isEnabled";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void MD_UPD_ResourceGroup(int? idUser, int? idResourceGroup, string ResourceGroup, int? intOrder, bool? isEnabled)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResourceGroup = new SqlParameter("@idResourceGroup", idResourceGroup.ToString() ?? (object)DBNull.Value);
                SqlParameter p_ResourceGroup = new SqlParameter("@ResourceGroup", ResourceGroup.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intOrder = new SqlParameter("@intOrder", intOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isEnabled = new SqlParameter("@isEnabled", isEnabled.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_UPD_ResourceGroup] @idUser, @idResourceGroup, @ResourceGroup, @intOrder, @isEnabled";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void MD_UPD_ResourceType(int? idUser, int? idResourceType, string ResourceType, int? intOrder, bool? isEnabled)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResourceType = new SqlParameter("@idResourceType", idResourceType.ToString() ?? (object)DBNull.Value);
                SqlParameter p_ResourceType = new SqlParameter("@ResourceType", ResourceType.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intOrder = new SqlParameter("@intOrder", intOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isEnabled = new SqlParameter("@isEnabled", isEnabled.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_UPD_ResourceType] @idUser, @idResourceType, @ResourceType, @intOrder, @isEnabled";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void MD_UPD_WorkDepartment(int? idUser, int? idWorkDepartment, string WorkDepartment, int? intOrder, bool? isEnabled)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idWorkDepartment = new SqlParameter("@idWorkDepartment", idWorkDepartment.ToString() ?? (object)DBNull.Value);
                SqlParameter p_WorkDepartment = new SqlParameter("@WorkDepartment", WorkDepartment.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intOrder = new SqlParameter("@intOrder", intOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isEnabled = new SqlParameter("@isEnabled", isEnabled.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_UPD_WorkDepartment] @idUser, @idWorkDepartment, @WorkDepartment, @intOrder, @isEnabled";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void MD_UPD_WorkFunction(int? idUser, int? idWorkFunction, string WorkFunction, int? intOrder, bool? isEnabled)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idWorkFunction = new SqlParameter("@idWorkFunction", idWorkFunction.ToString() ?? (object)DBNull.Value);
                SqlParameter p_WorkFunction = new SqlParameter("@WorkFunction", WorkFunction.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intOrder = new SqlParameter("@intOrder", intOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isEnabled = new SqlParameter("@isEnabled", isEnabled.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[MD_UPD_WorkFunction] @idUser, @idWorkFunction, @WorkFunction, @intOrder, @isEnabled";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<METEL_PriceList_GET_ALLResult>> METEL_PriceList_GET_ALLAsync(int? idUser)
        {
            //Initialize Result 
            List<METEL_PriceList_GET_ALLResult> lst = new List<METEL_PriceList_GET_ALLResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[METEL_PriceList_GET_ALL] @idUser";

                //Output Data
                lst = await this.METEL_PriceList_GET_ALL.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<METEL_STG_GET_PriceListResult>> METEL_STG_GET_PriceListAsync(int? idUser)
        {
            //Initialize Result 
            List<METEL_STG_GET_PriceListResult> lst = new List<METEL_STG_GET_PriceListResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[METEL_STG_GET_PriceList] @idUser";

                //Output Data
                lst = await this.METEL_STG_GET_PriceList.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void METEL_SYNC(int? idUser)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[METEL_SYNC] @idUser";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<Phase_CHECKResult>> Phase_CHECKAsync(int? idUser, int? idPhase)
        {
            //Initialize Result 
            List<Phase_CHECKResult> lst = new List<Phase_CHECKResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idPhase = new SqlParameter("@idPhase", idPhase.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Phase_CHECK] @idUser, @idPhase";

                //Output Data
                lst = await this.Phase_CHECK.FromSqlRaw(sqlQuery, p_idUser, p_idPhase).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void Phase_CLEAR(int? idUser, int? idPhase)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idPhase = new SqlParameter("@idPhase", idPhase.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Phase_CLEAR] @idUser, @idPhase";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Phase_CLONE(int? idUser, int? idPhase, string Code, string Phase, ref int? idPhaseOut)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idPhase = new SqlParameter("@idPhase", idPhase.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Code = new SqlParameter("@Code", Code.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Phase = new SqlParameter("@Phase", Phase.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idPhaseOut = new SqlParameter("@idPhaseOut", idPhaseOut.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Phase_CLONE] @idUser, @idPhase, @Code, @Phase, @idPhaseOut OUTPUT";


                //Output Params
                idPhaseOut = (int?)p_idPhaseOut.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Phase_DEL(int? idUser, int? idPhase)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idPhase = new SqlParameter("@idPhase", idPhase.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Phase_DEL] @idUser, @idPhase";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<Phase_GETResult>> Phase_GETAsync(int? idUser, int? idPhase)
        {
            //Initialize Result 
            List<Phase_GETResult> lst = new List<Phase_GETResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idPhase = new SqlParameter("@idPhase", idPhase.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Phase_GET] @idUser, @idPhase";

                //Output Data
                lst = await this.Phase_GET.FromSqlRaw(sqlQuery, p_idUser, p_idPhase).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void Phase_INITIALIZE(int? idUser, string Code, string Phase, ref int? idPhase)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Code = new SqlParameter("@Code", Code.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Phase = new SqlParameter("@Phase", Phase.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idPhase = new SqlParameter("@idPhase", idPhase.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Phase_INITIALIZE] @idUser, @Code, @Phase, @idPhase OUTPUT";


                //Output Params
                idPhase = (int?)p_idPhase.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Phase_LOCK(int? idUser, int? idPhase)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idPhase = new SqlParameter("@idPhase", idPhase.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Phase_LOCK] @idUser, @idPhase";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<Phase_SEARCHResult>> Phase_SEARCHAsync(int? idUser)
        {
            //Initialize Result 
            List<Phase_SEARCHResult> lst = new List<Phase_SEARCHResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Phase_SEARCH] @idUser";

                //Output Data
                lst = await this.Phase_SEARCH.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void Phase_UNLOCK(int? idUser, int? idPhase)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idPhase = new SqlParameter("@idPhase", idPhase.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Phase_UNLOCK] @idUser, @idPhase";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Phase_UPD_Header(int? idUser, int? idPhase, string Phase, int? idPhaseType, int? idSupplier, int? idResourceGroup, int? idResourceTooling, decimal? vToolingStart_mm, decimal? vUntooling_mm, decimal? vToolingK, int? idPhaseCalculation, decimal? vCycle_mm, int? idResource, decimal? vK, decimal? vSupplier_DD, decimal? vSupplierCost_DD, string Note, bool? isEnabled, bool? isDeleted)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idPhase = new SqlParameter("@idPhase", idPhase.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Phase = new SqlParameter("@Phase", Phase.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idPhaseType = new SqlParameter("@idPhaseType", idPhaseType.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResourceGroup = new SqlParameter("@idResourceGroup", idResourceGroup.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResourceTooling = new SqlParameter("@idResourceTooling", idResourceTooling.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vToolingStart_mm = new SqlParameter("@vToolingStart_mm", vToolingStart_mm.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vUntooling_mm = new SqlParameter("@vUntooling_mm", vUntooling_mm.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vToolingK = new SqlParameter("@vToolingK", vToolingK.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idPhaseCalculation = new SqlParameter("@idPhaseCalculation", idPhaseCalculation.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vCycle_mm = new SqlParameter("@vCycle_mm", vCycle_mm.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResource = new SqlParameter("@idResource", idResource.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vK = new SqlParameter("@vK", vK.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vSupplier_DD = new SqlParameter("@vSupplier_DD", vSupplier_DD.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vSupplierCost_DD = new SqlParameter("@vSupplierCost_DD", vSupplierCost_DD.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Note = new SqlParameter("@Note", Note.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isEnabled = new SqlParameter("@isEnabled", isEnabled.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isDeleted = new SqlParameter("@isDeleted", isDeleted.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Phase_UPD_Header] @idUser, @idPhase, @Phase, @idPhaseType, @idSupplier, @idResourceGroup, @idResourceTooling, @vToolingStart_mm, @vUntooling_mm, @vToolingK, @idPhaseCalculation, @vCycle_mm, @idResource, @vK, @vSupplier_DD, @vSupplierCost_DD, @Note, @isEnabled, @isDeleted";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Resource_ADD_ResourceGroup(int? idUser, int? idResource, int? idResourceGroup, ref int? idRef)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResource = new SqlParameter("@idResource", idResource.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResourceGroup = new SqlParameter("@idResourceGroup", idResourceGroup.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idRef = new SqlParameter("@idRef", idRef.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Resource_ADD_ResourceGroup] @idUser, @idResource, @idResourceGroup, @idRef OUTPUT";


                //Output Params
                idRef = (int?)p_idRef.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<Resource_CHECKResult>> Resource_CHECKAsync(int? idUser, int? idResource)
        {
            //Initialize Result 
            List<Resource_CHECKResult> lst = new List<Resource_CHECKResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResource = new SqlParameter("@idResource", idResource.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Resource_CHECK] @idUser, @idResource";

                //Output Data
                lst = await this.Resource_CHECK.FromSqlRaw(sqlQuery, p_idUser, p_idResource).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void Resource_CLEAR(int? idUser, int? idResource)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResource = new SqlParameter("@idResource", idResource.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Resource_CLEAR] @idUser, @idResource";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Resource_CLONE(int? idUser, int? idResource, string Code, string Resource, ref int? idResourceOut)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResource = new SqlParameter("@idResource", idResource.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Code = new SqlParameter("@Code", Code.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Resource = new SqlParameter("@Resource", Resource.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResourceOut = new SqlParameter("@idResourceOut", idResourceOut.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Resource_CLONE] @idUser, @idResource, @Code, @Resource, @idResourceOut OUTPUT";


                //Output Params
                idResourceOut = (int?)p_idResourceOut.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Resource_DEL(int? idUser, int? idResource)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResource = new SqlParameter("@idResource", idResource.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Resource_DEL] @idUser, @idResource";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<Resource_GETResult>> Resource_GETAsync(int? idUser, int? idResource)
        {
            //Initialize Result 
            List<Resource_GETResult> lst = new List<Resource_GETResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResource = new SqlParameter("@idResource", idResource.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Resource_GET] @idUser, @idResource";

                //Output Data
                lst = await this.Resource_GET.FromSqlRaw(sqlQuery, p_idUser, p_idResource).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Resource_GET_ResourceGroupResult>> Resource_GET_ResourceGroupAsync(int? idUser, int? idResource, bool? includeDisabled, bool? includeDeleted)
        {
            //Initialize Result 
            List<Resource_GET_ResourceGroupResult> lst = new List<Resource_GET_ResourceGroupResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResource = new SqlParameter("@idResource", idResource.ToString() ?? (object)DBNull.Value);
                SqlParameter p_includeDisabled = new SqlParameter("@includeDisabled", includeDisabled.ToString() ?? (object)DBNull.Value);
                SqlParameter p_includeDeleted = new SqlParameter("@includeDeleted", includeDeleted.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Resource_GET_ResourceGroup] @idUser, @idResource, @includeDisabled, @includeDeleted";

                //Output Data
                lst = await this.Resource_GET_ResourceGroup.FromSqlRaw(sqlQuery, p_idUser, p_idResource, p_includeDisabled, p_includeDeleted).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void Resource_INITIALIZE(int? idUser, string Code, string Resource, int? idResourceType, ref int? idResource)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Code = new SqlParameter("@Code", Code.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Resource = new SqlParameter("@Resource", Resource.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResourceType = new SqlParameter("@idResourceType", idResourceType.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResource = new SqlParameter("@idResource", idResource.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Resource_INITIALIZE] @idUser, @Code, @Resource, @idResourceType, @idResource OUTPUT";


                //Output Params
                idResource = (int?)p_idResource.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Resource_LOCK(int? idUser, int? idResource)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResource = new SqlParameter("@idResource", idResource.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Resource_LOCK] @idUser, @idResource";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<Resource_SEARCHResult>> Resource_SEARCHAsync(int? idUser)
        {
            //Initialize Result 
            List<Resource_SEARCHResult> lst = new List<Resource_SEARCHResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Resource_SEARCH] @idUser";

                //Output Data
                lst = await this.Resource_SEARCH.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void Resource_UNLOCK(int? idUser, int? idResource)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResource = new SqlParameter("@idResource", idResource.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Resource_UNLOCK] @idUser, @idResource";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Resource_UPD_Header(int? idUser, int? idResource, string Resource, int? idResourceType, int? idResourceStatus, decimal? vCostH, bool? isEnabled)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResource = new SqlParameter("@idResource", idResource.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Resource = new SqlParameter("@Resource", Resource.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResourceType = new SqlParameter("@idResourceType", idResourceType.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idResourceStatus = new SqlParameter("@idResourceStatus", idResourceStatus.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vCostH = new SqlParameter("@vCostH", vCostH.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isEnabled = new SqlParameter("@isEnabled", isEnabled.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Resource_UPD_Header] @idUser, @idResource, @Resource, @idResourceType, @idResourceStatus, @vCostH, @isEnabled";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<Role_GETResult>> Role_GETAsync(int? idUser)
        {
            //Initialize Result 
            List<Role_GETResult> lst = new List<Role_GETResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Role_GET] @idUser";

                //Output Data
                lst = await this.Role_GET.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void STG_IMPORT_INVENTO_JOB()
        {
            try
            {

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[STG_IMPORT_INVENTO_JOB] ";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void STG_METEL_Clear()
        {
            try
            {

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[STG_METEL_Clear] ";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void STG_METEL_MATERIAL_Add(string SiglaMarchio, string CodiceProdottoAzienda, string CodiceEAN, string DescrizioneProdotto, string QuantitaCartone, string QuantitaMultiplaOrdinazione, string QuantitaMinimaOrdinazione, string QuantitaMassimaOrdinazione, string LeadTime, string PrezzoRivenditore, string PrezzoPubblico, string MoltiplicatorePrezzo, string CodiceValuta, string UnitaDiMisura, string ProdottoComposto, string StatoProdotto, string DataUltimaVariazione, string FamigliaSconto, string FamigliaStatistica, string CodiceElectrocod, string CodiceEtim, string CodiceBarcode, string QualificatoreCodiceBarcode)
        {
            try
            {
                // Parameters
                SqlParameter p_SiglaMarchio = new SqlParameter("@SiglaMarchio", SiglaMarchio.ToString() ?? (object)DBNull.Value);
                SqlParameter p_CodiceProdottoAzienda = new SqlParameter("@CodiceProdottoAzienda", CodiceProdottoAzienda.ToString() ?? (object)DBNull.Value);
                SqlParameter p_CodiceEAN = new SqlParameter("@CodiceEAN", CodiceEAN.ToString() ?? (object)DBNull.Value);
                SqlParameter p_DescrizioneProdotto = new SqlParameter("@DescrizioneProdotto", DescrizioneProdotto.ToString() ?? (object)DBNull.Value);
                SqlParameter p_QuantitaCartone = new SqlParameter("@QuantitaCartone", QuantitaCartone.ToString() ?? (object)DBNull.Value);
                SqlParameter p_QuantitaMultiplaOrdinazione = new SqlParameter("@QuantitaMultiplaOrdinazione", QuantitaMultiplaOrdinazione.ToString() ?? (object)DBNull.Value);
                SqlParameter p_QuantitaMinimaOrdinazione = new SqlParameter("@QuantitaMinimaOrdinazione", QuantitaMinimaOrdinazione.ToString() ?? (object)DBNull.Value);
                SqlParameter p_QuantitaMassimaOrdinazione = new SqlParameter("@QuantitaMassimaOrdinazione", QuantitaMassimaOrdinazione.ToString() ?? (object)DBNull.Value);
                SqlParameter p_LeadTime = new SqlParameter("@LeadTime", LeadTime.ToString() ?? (object)DBNull.Value);
                SqlParameter p_PrezzoRivenditore = new SqlParameter("@PrezzoRivenditore", PrezzoRivenditore.ToString() ?? (object)DBNull.Value);
                SqlParameter p_PrezzoPubblico = new SqlParameter("@PrezzoPubblico", PrezzoPubblico.ToString() ?? (object)DBNull.Value);
                SqlParameter p_MoltiplicatorePrezzo = new SqlParameter("@MoltiplicatorePrezzo", MoltiplicatorePrezzo.ToString() ?? (object)DBNull.Value);
                SqlParameter p_CodiceValuta = new SqlParameter("@CodiceValuta", CodiceValuta.ToString() ?? (object)DBNull.Value);
                SqlParameter p_UnitaDiMisura = new SqlParameter("@UnitaDiMisura", UnitaDiMisura.ToString() ?? (object)DBNull.Value);
                SqlParameter p_ProdottoComposto = new SqlParameter("@ProdottoComposto", ProdottoComposto.ToString() ?? (object)DBNull.Value);
                SqlParameter p_StatoProdotto = new SqlParameter("@StatoProdotto", StatoProdotto.ToString() ?? (object)DBNull.Value);
                SqlParameter p_DataUltimaVariazione = new SqlParameter("@DataUltimaVariazione", DataUltimaVariazione.ToString() ?? (object)DBNull.Value);
                SqlParameter p_FamigliaSconto = new SqlParameter("@FamigliaSconto", FamigliaSconto.ToString() ?? (object)DBNull.Value);
                SqlParameter p_FamigliaStatistica = new SqlParameter("@FamigliaStatistica", FamigliaStatistica.ToString() ?? (object)DBNull.Value);
                SqlParameter p_CodiceElectrocod = new SqlParameter("@CodiceElectrocod", CodiceElectrocod.ToString() ?? (object)DBNull.Value);
                SqlParameter p_CodiceEtim = new SqlParameter("@CodiceEtim", CodiceEtim.ToString() ?? (object)DBNull.Value);
                SqlParameter p_CodiceBarcode = new SqlParameter("@CodiceBarcode", CodiceBarcode.ToString() ?? (object)DBNull.Value);
                SqlParameter p_QualificatoreCodiceBarcode = new SqlParameter("@QualificatoreCodiceBarcode", QualificatoreCodiceBarcode.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[STG_METEL_MATERIAL_Add] @SiglaMarchio, @CodiceProdottoAzienda, @CodiceEAN, @DescrizioneProdotto, @QuantitaCartone, @QuantitaMultiplaOrdinazione, @QuantitaMinimaOrdinazione, @QuantitaMassimaOrdinazione, @LeadTime, @PrezzoRivenditore, @PrezzoPubblico, @MoltiplicatorePrezzo, @CodiceValuta, @UnitaDiMisura, @ProdottoComposto, @StatoProdotto, @DataUltimaVariazione, @FamigliaSconto, @FamigliaStatistica, @CodiceElectrocod, @CodiceEtim, @CodiceBarcode, @QualificatoreCodiceBarcode";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void STG_METEL_PRICE_LIST_Add(string IdentificazioneTracciato, string SiglaAzienda, string PartitaIVA, string NumeroListinoPrezzi, string DecorrenzaListinoPrezzi, string DataUltimaVariazioneImmissione, string DescrizioneListinoPrezzi, string Filler1, string VersioneTracciatoListinoPrezzi, string DataDecorrenzaListinoGrossista, string Isopartita, string Filler2)
        {
            try
            {
                // Parameters
                SqlParameter p_IdentificazioneTracciato = new SqlParameter("@IdentificazioneTracciato", IdentificazioneTracciato.ToString() ?? (object)DBNull.Value);
                SqlParameter p_SiglaAzienda = new SqlParameter("@SiglaAzienda", SiglaAzienda.ToString() ?? (object)DBNull.Value);
                SqlParameter p_PartitaIVA = new SqlParameter("@PartitaIVA", PartitaIVA.ToString() ?? (object)DBNull.Value);
                SqlParameter p_NumeroListinoPrezzi = new SqlParameter("@NumeroListinoPrezzi", NumeroListinoPrezzi.ToString() ?? (object)DBNull.Value);
                SqlParameter p_DecorrenzaListinoPrezzi = new SqlParameter("@DecorrenzaListinoPrezzi", DecorrenzaListinoPrezzi.ToString() ?? (object)DBNull.Value);
                SqlParameter p_DataUltimaVariazioneImmissione = new SqlParameter("@DataUltimaVariazioneImmissione", DataUltimaVariazioneImmissione.ToString() ?? (object)DBNull.Value);
                SqlParameter p_DescrizioneListinoPrezzi = new SqlParameter("@DescrizioneListinoPrezzi", DescrizioneListinoPrezzi.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Filler1 = new SqlParameter("@Filler1", Filler1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_VersioneTracciatoListinoPrezzi = new SqlParameter("@VersioneTracciatoListinoPrezzi", VersioneTracciatoListinoPrezzi.ToString() ?? (object)DBNull.Value);
                SqlParameter p_DataDecorrenzaListinoGrossista = new SqlParameter("@DataDecorrenzaListinoGrossista", DataDecorrenzaListinoGrossista.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Isopartita = new SqlParameter("@Isopartita", Isopartita.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Filler2 = new SqlParameter("@Filler2", Filler2.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[STG_METEL_PRICE_LIST_Add] @IdentificazioneTracciato, @SiglaAzienda, @PartitaIVA, @NumeroListinoPrezzi, @DecorrenzaListinoPrezzi, @DataUltimaVariazioneImmissione, @DescrizioneListinoPrezzi, @Filler1, @VersioneTracciatoListinoPrezzi, @DataDecorrenzaListinoGrossista, @Isopartita, @Filler2";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Stock_CALCULATE(int? idUser, int? idStockMovement)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idStockMovement = new SqlParameter("@idStockMovement", idStockMovement.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Stock_CALCULATE] @idUser, @idStockMovement";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void StockMovement_ADD_Detail(int? idUser, int? idStockMovement, string Progressive, int? idMaterial, int? idUnitSelling, decimal? vQty, decimal? vAmountTot, ref int? idStockMovementDetailOut)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idStockMovement = new SqlParameter("@idStockMovement", idStockMovement.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Progressive = new SqlParameter("@Progressive", Progressive.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idUnitSelling = new SqlParameter("@idUnitSelling", idUnitSelling.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vQty = new SqlParameter("@vQty", vQty.ToString() ?? (object)DBNull.Value);
                SqlParameter p_vAmountTot = new SqlParameter("@vAmountTot", vAmountTot.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idStockMovementDetailOut = new SqlParameter("@idStockMovementDetailOut", idStockMovementDetailOut.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[StockMovement_ADD_Detail] @idUser, @idStockMovement, @Progressive, @idMaterial, @idUnitSelling, @vQty, @vAmountTot, @idStockMovementDetailOut OUTPUT";


                //Output Params
                idStockMovementDetailOut = (int?)p_idStockMovementDetailOut.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<StockMovement_CHECKResult>> StockMovement_CHECKAsync(int? idUser, int? idStockMovement)
        {
            //Initialize Result 
            List<StockMovement_CHECKResult> lst = new List<StockMovement_CHECKResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idStockMovement = new SqlParameter("@idStockMovement", idStockMovement.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[StockMovement_CHECK] @idUser, @idStockMovement";

                //Output Data
                lst = await this.StockMovement_CHECK.FromSqlRaw(sqlQuery, p_idUser, p_idStockMovement).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void StockMovement_CLEAR(int? idUser, int? idStockMovement)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idStockMovement = new SqlParameter("@idStockMovement", idStockMovement.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[StockMovement_CLEAR] @idUser, @idStockMovement";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void StockMovement_DEL(int? idUser, int? idStockMovement)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idStockMovement = new SqlParameter("@idStockMovement", idStockMovement.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[StockMovement_DEL] @idUser, @idStockMovement";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<StockMovement_GETResult>> StockMovement_GETAsync(int? idUser, int? idStockMovement)
        {
            //Initialize Result 
            List<StockMovement_GETResult> lst = new List<StockMovement_GETResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idStockMovement = new SqlParameter("@idStockMovement", idStockMovement.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[StockMovement_GET] @idUser, @idStockMovement";

                //Output Data
                lst = await this.StockMovement_GET.FromSqlRaw(sqlQuery, p_idUser, p_idStockMovement).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<StockMovement_GET_DetailResult>> StockMovement_GET_DetailAsync(int? idUser, int? idStockMovement)
        {
            //Initialize Result 
            List<StockMovement_GET_DetailResult> lst = new List<StockMovement_GET_DetailResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idStockMovement = new SqlParameter("@idStockMovement", idStockMovement.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[StockMovement_GET_Detail] @idUser, @idStockMovement";

                //Output Data
                lst = await this.StockMovement_GET_Detail.FromSqlRaw(sqlQuery, p_idUser, p_idStockMovement).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void StockMovement_INITIALIZE(int? idUser, int? idStockMovementType, DateTime? DateStockMovement, ref int? idStockMovement, ref string Code)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idStockMovementType = new SqlParameter("@idStockMovementType", idStockMovementType.ToString() ?? (object)DBNull.Value);
                SqlParameter p_DateStockMovement = new SqlParameter("@DateStockMovement", DateStockMovement.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idStockMovement = new SqlParameter("@idStockMovement", idStockMovement.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Code = new SqlParameter("@Code", Code.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[StockMovement_INITIALIZE] @idUser, @idStockMovementType, @DateStockMovement, @idStockMovement OUTPUT, @Code OUTPUT";


                //Output Params
                idStockMovement = (int?)p_idStockMovement.Value;
                Code = (string)p_Code.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void StockMovement_LOCK(int? idUser, int? idStockMovement)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idStockMovement = new SqlParameter("@idStockMovement", idStockMovement.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[StockMovement_LOCK] @idUser, @idStockMovement";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<StockMovement_SEARCHResult>> StockMovement_SEARCHAsync(int? idUser, int? intDateStockMovementStart, int? intDateStockMovementEnd, int? idMaterial, int? idStockMovementType, int? idStockMovementStatus, int? idCustomer, int? idSupplier, int? idJob, string PurchaseOrder, string SalesOrder)
        {
            //Initialize Result 
            List<StockMovement_SEARCHResult> lst = new List<StockMovement_SEARCHResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intDateStockMovementStart = new SqlParameter("@intDateStockMovementStart", intDateStockMovementStart.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intDateStockMovementEnd = new SqlParameter("@intDateStockMovementEnd", intDateStockMovementEnd.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial = new SqlParameter("@idMaterial", idMaterial.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idStockMovementType = new SqlParameter("@idStockMovementType", idStockMovementType.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idStockMovementStatus = new SqlParameter("@idStockMovementStatus", idStockMovementStatus.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCustomer = new SqlParameter("@idCustomer", idCustomer.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idJob = new SqlParameter("@idJob", idJob.ToString() ?? (object)DBNull.Value);
                SqlParameter p_PurchaseOrder = new SqlParameter("@PurchaseOrder", PurchaseOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_SalesOrder = new SqlParameter("@SalesOrder", SalesOrder.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[StockMovement_SEARCH] @idUser, @intDateStockMovementStart, @intDateStockMovementEnd, @idMaterial, @idStockMovementType, @idStockMovementStatus, @idCustomer, @idSupplier, @idJob, @PurchaseOrder, @SalesOrder";

                //Output Data
                lst = await this.StockMovement_SEARCH.FromSqlRaw(sqlQuery, p_idUser, p_intDateStockMovementStart, p_intDateStockMovementEnd, p_idMaterial, p_idStockMovementType, p_idStockMovementStatus, p_idCustomer, p_idSupplier, p_idJob, p_PurchaseOrder, p_SalesOrder).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void StockMovement_SEARCH_TEST(int? idUser, int? intDateDocumentStart, int? intDateDocumentEnd, string idStockMovementType_List, string idMaterial_List, string idSupplier_List, string idCustomer_List, string Job, string PurchaseOrder)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intDateDocumentStart = new SqlParameter("@intDateDocumentStart", intDateDocumentStart.ToString() ?? (object)DBNull.Value);
                SqlParameter p_intDateDocumentEnd = new SqlParameter("@intDateDocumentEnd", intDateDocumentEnd.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idStockMovementType_List = new SqlParameter("@idStockMovementType_List", idStockMovementType_List.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idMaterial_List = new SqlParameter("@idMaterial_List", idMaterial_List.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier_List = new SqlParameter("@idSupplier_List", idSupplier_List.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCustomer_List = new SqlParameter("@idCustomer_List", idCustomer_List.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Job = new SqlParameter("@Job", Job.ToString() ?? (object)DBNull.Value);
                SqlParameter p_PurchaseOrder = new SqlParameter("@PurchaseOrder", PurchaseOrder.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[StockMovement_SEARCH_TEST] @idUser, @intDateDocumentStart, @intDateDocumentEnd, @idStockMovementType_List, @idMaterial_List, @idSupplier_List, @idCustomer_List, @Job, @PurchaseOrder";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void StockMovement_UNLOCK(int? idUser, int? idStockMovement)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idStockMovement = new SqlParameter("@idStockMovement", idStockMovement.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[StockMovement_UNLOCK] @idUser, @idStockMovement";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void StockMovement_UPD_Header(int? idUser, int? idStockMovement, int? idStockMovementStatus, int? idWarehouseSource, int? idWarehouseDest, int? idCurrency, int? idSupplier, int? idCustomer, int? idJob, string PurchaseOrder, string SalesOrder)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idStockMovement = new SqlParameter("@idStockMovement", idStockMovement.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idStockMovementStatus = new SqlParameter("@idStockMovementStatus", idStockMovementStatus.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idWarehouseSource = new SqlParameter("@idWarehouseSource", idWarehouseSource.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idWarehouseDest = new SqlParameter("@idWarehouseDest", idWarehouseDest.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCurrency = new SqlParameter("@idCurrency", idCurrency.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCustomer = new SqlParameter("@idCustomer", idCustomer.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idJob = new SqlParameter("@idJob", idJob.ToString() ?? (object)DBNull.Value);
                SqlParameter p_PurchaseOrder = new SqlParameter("@PurchaseOrder", PurchaseOrder.ToString() ?? (object)DBNull.Value);
                SqlParameter p_SalesOrder = new SqlParameter("@SalesOrder", SalesOrder.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[StockMovement_UPD_Header] @idUser, @idStockMovement, @idStockMovementStatus, @idWarehouseSource, @idWarehouseDest, @idCurrency, @idSupplier, @idCustomer, @idJob, @PurchaseOrder, @SalesOrder";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Supplier_ADD_Contact(int? idUser, int? idSupplier, string Title, string FirstName, string LastName, int? idWorkFunction, int? idWorkDepartment, bool? isDecisionMaker, string Tel1, string Mob1, string Email1, ref int? idContact)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Title = new SqlParameter("@Title", Title.ToString() ?? (object)DBNull.Value);
                SqlParameter p_FirstName = new SqlParameter("@FirstName", FirstName.ToString() ?? (object)DBNull.Value);
                SqlParameter p_LastName = new SqlParameter("@LastName", LastName.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idWorkFunction = new SqlParameter("@idWorkFunction", idWorkFunction.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idWorkDepartment = new SqlParameter("@idWorkDepartment", idWorkDepartment.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isDecisionMaker = new SqlParameter("@isDecisionMaker", isDecisionMaker.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Tel1 = new SqlParameter("@Tel1", Tel1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Mob1 = new SqlParameter("@Mob1", Mob1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Email1 = new SqlParameter("@Email1", Email1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idContact = new SqlParameter("@idContact", idContact.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Supplier_ADD_Contact] @idUser, @idSupplier, @Title, @FirstName, @LastName, @idWorkFunction, @idWorkDepartment, @isDecisionMaker, @Tel1, @Mob1, @Email1, @idContact OUTPUT";


                //Output Params
                idContact = (int?)p_idContact.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Supplier_ADD_Division(int? idUser, int? idSupplier, int? idDivision)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idDivision = new SqlParameter("@idDivision", idDivision.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Supplier_ADD_Division] @idUser, @idSupplier, @idDivision";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Supplier_ADD_SupplierType(int? idUser, int? idSupplier, int? idSupplierType)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplierType = new SqlParameter("@idSupplierType", idSupplierType.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Supplier_ADD_SupplierType] @idUser, @idSupplier, @idSupplierType";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Supplier_ADD_UPD_BusinessPartner(ref int? idSupplierBusinessPartner, string ACT, string BusinessPartnerTypeCode, int? idSupplier, string BusinessName, string VAT, string FiscalCode, int? idCountry, string City, string Address, string ZIP, string Province, string TEL1, string TEL2, string MOB1, string MOB2, string Fax1, string Fax2, string Email1, string Email2, bool? isDeleted, string Ref1, string Ref2)
        {
            try
            {
                // Parameters
                SqlParameter p_idSupplierBusinessPartner = new SqlParameter("@idSupplierBusinessPartner", idSupplierBusinessPartner.ToString() ?? (object)DBNull.Value);
                SqlParameter p_ACT = new SqlParameter("@ACT", ACT.ToString() ?? (object)DBNull.Value);
                SqlParameter p_BusinessPartnerTypeCode = new SqlParameter("@BusinessPartnerTypeCode", BusinessPartnerTypeCode.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);
                SqlParameter p_BusinessName = new SqlParameter("@BusinessName", BusinessName.ToString() ?? (object)DBNull.Value);
                SqlParameter p_VAT = new SqlParameter("@VAT", VAT.ToString() ?? (object)DBNull.Value);
                SqlParameter p_FiscalCode = new SqlParameter("@FiscalCode", FiscalCode.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCountry = new SqlParameter("@idCountry", idCountry.ToString() ?? (object)DBNull.Value);
                SqlParameter p_City = new SqlParameter("@City", City.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Address = new SqlParameter("@Address", Address.ToString() ?? (object)DBNull.Value);
                SqlParameter p_ZIP = new SqlParameter("@ZIP", ZIP.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Province = new SqlParameter("@Province", Province.ToString() ?? (object)DBNull.Value);
                SqlParameter p_TEL1 = new SqlParameter("@TEL1", TEL1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_TEL2 = new SqlParameter("@TEL2", TEL2.ToString() ?? (object)DBNull.Value);
                SqlParameter p_MOB1 = new SqlParameter("@MOB1", MOB1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_MOB2 = new SqlParameter("@MOB2", MOB2.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Fax1 = new SqlParameter("@Fax1", Fax1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Fax2 = new SqlParameter("@Fax2", Fax2.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Email1 = new SqlParameter("@Email1", Email1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Email2 = new SqlParameter("@Email2", Email2.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isDeleted = new SqlParameter("@isDeleted", isDeleted.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Ref1 = new SqlParameter("@Ref1", Ref1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Ref2 = new SqlParameter("@Ref2", Ref2.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Supplier_ADD_UPD_BusinessPartner] @idSupplierBusinessPartner OUTPUT, @ACT, @BusinessPartnerTypeCode, @idSupplier, @BusinessName, @VAT, @FiscalCode, @idCountry, @City, @Address, @ZIP, @Province, @TEL1, @TEL2, @MOB1, @MOB2, @Fax1, @Fax2, @Email1, @Email2, @isDeleted, @Ref1, @Ref2";


                //Output Params
                idSupplierBusinessPartner = (int?)p_idSupplierBusinessPartner.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<Supplier_CHECKResult>> Supplier_CHECKAsync(int? idUser, int? idSupplier)
        {
            //Initialize Result 
            List<Supplier_CHECKResult> lst = new List<Supplier_CHECKResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Supplier_CHECK] @idUser, @idSupplier";

                //Output Data
                lst = await this.Supplier_CHECK.FromSqlRaw(sqlQuery, p_idUser, p_idSupplier).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void Supplier_CLEAR(int? idSupplier, int? idUserLastEdit)
        {
            try
            {
                // Parameters
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idUserLastEdit = new SqlParameter("@idUserLastEdit", idUserLastEdit.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Supplier_CLEAR] @idSupplier, @idUserLastEdit";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Supplier_DEL(int? idSupplier, int? idUserLastEdit)
        {
            try
            {
                // Parameters
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idUserLastEdit = new SqlParameter("@idUserLastEdit", idUserLastEdit.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Supplier_DEL] @idSupplier, @idUserLastEdit";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Supplier_DEL_BusinessPartner(int? idUser, int? idSupplier, int? idSupplierBusinessPartner)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplierBusinessPartner = new SqlParameter("@idSupplierBusinessPartner", idSupplierBusinessPartner.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Supplier_DEL_BusinessPartner] @idUser, @idSupplier, @idSupplierBusinessPartner";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Supplier_DEL_Contact(int? idUser, int? idSupplier, int? idContact)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idContact = new SqlParameter("@idContact", idContact.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Supplier_DEL_Contact] @idUser, @idSupplier, @idContact";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<Supplier_GETResult>> Supplier_GETAsync(int? idUser, int? idSupplier)
        {
            //Initialize Result 
            List<Supplier_GETResult> lst = new List<Supplier_GETResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Supplier_GET] @idUser, @idSupplier";

                //Output Data
                lst = await this.Supplier_GET.FromSqlRaw(sqlQuery, p_idUser, p_idSupplier).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Supplier_GET_BusinessPartnerResult>> Supplier_GET_BusinessPartnerAsync(int? idUser, int? idSupplier, string CodeBusinessPartner)
        {
            //Initialize Result 
            List<Supplier_GET_BusinessPartnerResult> lst = new List<Supplier_GET_BusinessPartnerResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);
                SqlParameter p_CodeBusinessPartner = new SqlParameter("@CodeBusinessPartner", CodeBusinessPartner.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Supplier_GET_BusinessPartner] @idUser, @idSupplier, @CodeBusinessPartner";

                //Output Data
                lst = await this.Supplier_GET_BusinessPartner.FromSqlRaw(sqlQuery, p_idUser, p_idSupplier, p_CodeBusinessPartner).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Supplier_GET_ContactResult>> Supplier_GET_ContactAsync(int? idUser, int? idSupplier)
        {
            //Initialize Result 
            List<Supplier_GET_ContactResult> lst = new List<Supplier_GET_ContactResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Supplier_GET_Contact] @idUser, @idSupplier";

                //Output Data
                lst = await this.Supplier_GET_Contact.FromSqlRaw(sqlQuery, p_idUser, p_idSupplier).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Supplier_GET_DivisionResult>> Supplier_GET_DivisionAsync(int? idUser, int? idSupplier)
        {
            //Initialize Result 
            List<Supplier_GET_DivisionResult> lst = new List<Supplier_GET_DivisionResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Supplier_GET_Division] @idUser, @idSupplier";

                //Output Data
                lst = await this.Supplier_GET_Division.FromSqlRaw(sqlQuery, p_idUser, p_idSupplier).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<Supplier_GET_SupplierTypeResult>> Supplier_GET_SupplierTypeAsync(int? idUser, int? idSupplier)
        {
            //Initialize Result 
            List<Supplier_GET_SupplierTypeResult> lst = new List<Supplier_GET_SupplierTypeResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Supplier_GET_SupplierType] @idUser, @idSupplier";

                //Output Data
                lst = await this.Supplier_GET_SupplierType.FromSqlRaw(sqlQuery, p_idUser, p_idSupplier).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void Supplier_INITIALIZE(int? idUser, string BusinessName, string VAT, string FiscalCode, int? idCountry, int? idLead, ref int? idSupplier, ref string CodeSupplier)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_BusinessName = new SqlParameter("@BusinessName", BusinessName.ToString() ?? (object)DBNull.Value);
                SqlParameter p_VAT = new SqlParameter("@VAT", VAT.ToString() ?? (object)DBNull.Value);
                SqlParameter p_FiscalCode = new SqlParameter("@FiscalCode", FiscalCode.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCountry = new SqlParameter("@idCountry", idCountry.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idLead = new SqlParameter("@idLead", idLead.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);
                SqlParameter p_CodeSupplier = new SqlParameter("@CodeSupplier", CodeSupplier.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Supplier_INITIALIZE] @idUser, @BusinessName, @VAT, @FiscalCode, @idCountry, @idLead, @idSupplier OUTPUT, @CodeSupplier OUTPUT";


                //Output Params
                idSupplier = (int?)p_idSupplier.Value;
                CodeSupplier = (string)p_CodeSupplier.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Supplier_LOCK(int? idUser, int? idSupplier)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Supplier_LOCK] @idUser, @idSupplier";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Supplier_RECOVER(int? idSupplier, int? idUserLastEdit)
        {
            try
            {
                // Parameters
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idUserLastEdit = new SqlParameter("@idUserLastEdit", idUserLastEdit.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Supplier_RECOVER] @idSupplier, @idUserLastEdit";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<Supplier_SEARCHResult>> Supplier_SEARCHAsync(int? idUser, int? flStock)
        {
            //Initialize Result 
            List<Supplier_SEARCHResult> lst = new List<Supplier_SEARCHResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_flStock = new SqlParameter("@flStock", flStock.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Supplier_SEARCH] @idUser, @flStock";

                //Output Data
                lst = await this.Supplier_SEARCH.FromSqlRaw(sqlQuery, p_idUser, p_flStock).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void Supplier_UNLOCK(int? idUser, int? idSupplier)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Supplier_UNLOCK] @idUser, @idSupplier";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Supplier_UPD(int? idSupplier, string BusinessName, string VAT, string FiscalCode, string City, string Address, string ZIP, int? idCountry, string Province, string TEL1, string TEL2, string MOB1, string MOB2, string Fax1, string Fax2, string Email1, string Email2, int? idUserLastEdit, bool? isInternalSupplier, int? idCompanySector, int? idPaymentType, string MetelCompanyCode)
        {
            try
            {
                // Parameters
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);
                SqlParameter p_BusinessName = new SqlParameter("@BusinessName", BusinessName.ToString() ?? (object)DBNull.Value);
                SqlParameter p_VAT = new SqlParameter("@VAT", VAT.ToString() ?? (object)DBNull.Value);
                SqlParameter p_FiscalCode = new SqlParameter("@FiscalCode", FiscalCode.ToString() ?? (object)DBNull.Value);
                SqlParameter p_City = new SqlParameter("@City", City.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Address = new SqlParameter("@Address", Address.ToString() ?? (object)DBNull.Value);
                SqlParameter p_ZIP = new SqlParameter("@ZIP", ZIP.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCountry = new SqlParameter("@idCountry", idCountry.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Province = new SqlParameter("@Province", Province.ToString() ?? (object)DBNull.Value);
                SqlParameter p_TEL1 = new SqlParameter("@TEL1", TEL1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_TEL2 = new SqlParameter("@TEL2", TEL2.ToString() ?? (object)DBNull.Value);
                SqlParameter p_MOB1 = new SqlParameter("@MOB1", MOB1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_MOB2 = new SqlParameter("@MOB2", MOB2.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Fax1 = new SqlParameter("@Fax1", Fax1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Fax2 = new SqlParameter("@Fax2", Fax2.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Email1 = new SqlParameter("@Email1", Email1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Email2 = new SqlParameter("@Email2", Email2.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idUserLastEdit = new SqlParameter("@idUserLastEdit", idUserLastEdit.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isInternalSupplier = new SqlParameter("@isInternalSupplier", isInternalSupplier.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCompanySector = new SqlParameter("@idCompanySector", idCompanySector.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idPaymentType = new SqlParameter("@idPaymentType", idPaymentType.ToString() ?? (object)DBNull.Value);
                SqlParameter p_MetelCompanyCode = new SqlParameter("@MetelCompanyCode", MetelCompanyCode.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Supplier_UPD] @idSupplier, @BusinessName, @VAT, @FiscalCode, @City, @Address, @ZIP, @idCountry, @Province, @TEL1, @TEL2, @MOB1, @MOB2, @Fax1, @Fax2, @Email1, @Email2, @idUserLastEdit, @isInternalSupplier, @idCompanySector, @idPaymentType, @MetelCompanyCode";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void Supplier_UPD_Contact(int? idUser, int? idSupplier, int? idContact, string Title, string FirstName, string LastName, int? idWorkFunction, int? idWorkDepartment, bool? isDecisionMaker, string Tel1, string Mob1, string Email1, bool? isDefault)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idContact = new SqlParameter("@idContact", idContact.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Title = new SqlParameter("@Title", Title.ToString() ?? (object)DBNull.Value);
                SqlParameter p_FirstName = new SqlParameter("@FirstName", FirstName.ToString() ?? (object)DBNull.Value);
                SqlParameter p_LastName = new SqlParameter("@LastName", LastName.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idWorkFunction = new SqlParameter("@idWorkFunction", idWorkFunction.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idWorkDepartment = new SqlParameter("@idWorkDepartment", idWorkDepartment.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isDecisionMaker = new SqlParameter("@isDecisionMaker", isDecisionMaker.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Tel1 = new SqlParameter("@Tel1", Tel1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Mob1 = new SqlParameter("@Mob1", Mob1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_Email1 = new SqlParameter("@Email1", Email1.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isDefault = new SqlParameter("@isDefault", isDefault.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Supplier_UPD_Contact] @idUser, @idSupplier, @idContact, @Title, @FirstName, @LastName, @idWorkFunction, @idWorkDepartment, @isDecisionMaker, @Tel1, @Mob1, @Email1, @isDefault";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<SupplierContact_GET_DetailResult>> SupplierContact_GET_DetailAsync(int? idUser, int? idSupplier, int? idSupplierContact)
        {
            //Initialize Result 
            List<SupplierContact_GET_DetailResult> lst = new List<SupplierContact_GET_DetailResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplier = new SqlParameter("@idSupplier", idSupplier.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSupplierContact = new SqlParameter("@idSupplierContact", idSupplierContact.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[SupplierContact_GET_Detail] @idUser, @idSupplier, @idSupplierContact";

                //Output Data
                lst = await this.SupplierContact_GET_Detail.FromSqlRaw(sqlQuery, p_idUser, p_idSupplier, p_idSupplierContact).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void SYS_INITIALIZE_MENU()
        {
            try
            {

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[SYS_INITIALIZE_MENU] ";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<USER_GET_APP_MenuLeftResult>> USER_GET_APP_MenuLeftAsync(int? idUser)
        {
            //Initialize Result 
            List<USER_GET_APP_MenuLeftResult> lst = new List<USER_GET_APP_MenuLeftResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[USER_GET_APP_MenuLeft] @idUser";

                //Output Data
                lst = await this.USER_GET_APP_MenuLeft.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public async Task<List<USER_GET_APP_MenuTopResult>> USER_GET_APP_MenuTopAsync(int? idUser)
        {
            //Initialize Result 
            List<USER_GET_APP_MenuTopResult> lst = new List<USER_GET_APP_MenuTopResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[USER_GET_APP_MenuTop] @idUser";

                //Output Data
                lst = await this.USER_GET_APP_MenuTop.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }

        public void USER_Initialize(string id, ref int? idUser)
        {
            try
            {
                // Parameters
                SqlParameter p_id = new SqlParameter("@id", id.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[USER_Initialize] @id, @idUser OUTPUT";


                //Output Params
                idUser = (int?)p_idUser.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public void USER_UPD_Profile(int? idUser, int? idSalesArea, int? idLanguage, int? idCulture, int? idCurrency, bool? isActive, int? idUserTimeZone)
        {
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idSalesArea = new SqlParameter("@idSalesArea", idSalesArea.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idLanguage = new SqlParameter("@idLanguage", idLanguage.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCulture = new SqlParameter("@idCulture", idCulture.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idCurrency = new SqlParameter("@idCurrency", idCurrency.ToString() ?? (object)DBNull.Value);
                SqlParameter p_isActive = new SqlParameter("@isActive", isActive.ToString() ?? (object)DBNull.Value);
                SqlParameter p_idUserTimeZone = new SqlParameter("@idUserTimeZone", idUserTimeZone.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[USER_UPD_Profile] @idUser, @idSalesArea, @idLanguage, @idCulture, @idCurrency, @isActive, @idUserTimeZone";

            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
        }

        public async Task<List<Warehouse_SEARCHResult>> Warehouse_SEARCHAsync(int? idUser)
        {
            //Initialize Result 
            List<Warehouse_SEARCHResult> lst = new List<Warehouse_SEARCHResult>();
            try
            {
                // Parameters
                SqlParameter p_idUser = new SqlParameter("@idUser", idUser.ToString() ?? (object)DBNull.Value);

                // Processing 
                string sqlQuery = $@"EXEC [dbo].[Warehouse_SEARCH] @idUser";

                //Output Data
                lst = await this.Warehouse_SEARCH.FromSqlRaw(sqlQuery, p_idUser).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //Return
            return lst;
        }


        public class ADMIN_GET_ErrorLogResult
        {
            public int Id { get; set; }
            public DateTime Date { get; set; }
            public string WebApiMethod { get; set; }
            public string JsonPayload { get; set; }
            public string Level { get; set; }
            public string Logger { get; set; }
            public string Message { get; set; }
            public string Exception { get; set; }
        }
        public class ADMIN_GET_LockResult
        {
            public int id { get; set; }
            public string Code { get; set; }
            public int idEntityType { get; set; }
            public string EntityCode { get; set; }
            public string Entity { get; set; }
            public string EntityTxt { get; set; }
            public int? idUserLock { get; set; }
            public string UserLock { get; set; }
            public DateTimeOffset? DateUserLock { get; set; }
        }
        public class Bom_CHECKResult
        {
            public string Action { get; set; }
            public bool? Check { get; set; }
            public string RCODE { get; set; }
            public string Message { get; set; }
            public int? idUserLock { get; set; }
            public string UserLock { get; set; }
        }
        public class Bom_GETResult
        {
            public int idBom { get; set; }
            public int? idMaterial { get; set; }
            public string Code { get; set; }
            public string Bom { get; set; }
            public string MaterialCode { get; set; }
            public string Material { get; set; }
            public bool? isEnabled { get; set; }
            public bool? isDeleted { get; set; }
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
        public class Bom_GET_MaterialResult
        {
            public int idBomMaterial { get; set; }
            public int? idBom { get; set; }
            public string Progressive { get; set; }
            public int? idMaterial { get; set; }
            public string MaterialCode { get; set; }
            public string Material { get; set; }
            public int? idUnitSelling { get; set; }
            public string UnitSellingCode { get; set; }
            public string UnitSelling { get; set; }
            public decimal? vQty { get; set; }
            public decimal? vQtyBase { get; set; }
            public decimal? vQtyScrap { get; set; }
            public decimal? vQtyBaseScrap { get; set; }
            public int idBomComponent { get; set; }
            public string BomCodeComponent { get; set; }
        }
        public class Bom_GET_PhaseResult
        {
            public int idBom { get; set; }
            public int idBomPhase { get; set; }
            public string BomCode { get; set; }
            public string Bom { get; set; }
            public int? idPhase { get; set; }
            public string Progressive { get; set; }
            public string Code { get; set; }
            public string Phase { get; set; }
            public int? idCurrency { get; set; }
            public int? idPhaseType { get; set; }
            public string PhaseTypeCode { get; set; }
            public string PhaseType { get; set; }
            public int? idSupplier { get; set; }
            public string SupplierCode { get; set; }
            public string Supplier { get; set; }
            public int? idResourceGroup { get; set; }
            public string ResourceGroupCode { get; set; }
            public string ResourceGroup { get; set; }
            public int? idResourceTooling { get; set; }
            public string ResourceToolingCode { get; set; }
            public string ResourceTooling { get; set; }
            public decimal? vToolingStart_mm { get; set; }
            public decimal? vUntooling_mm { get; set; }
            public decimal? vToolingK { get; set; }
            public int? idPhaseCalculation { get; set; }
            public string PhaseCalculationCode { get; set; }
            public string PhaseCalculation { get; set; }
            public decimal? vCycle_mm { get; set; }
            public int? idResource { get; set; }
            public string ResourceCode { get; set; }
            public string Resource { get; set; }
            public decimal? vK { get; set; }
            public decimal? vSupplier_DD { get; set; }
            public decimal? vSupplierCost_DD { get; set; }
            public string Note { get; set; }
        }
        public class Bom_GET_PhaseMaterialResult
        {
            public int idBomPhaseMaterial { get; set; }
            public int? idBom { get; set; }
            public int? idBomPhase { get; set; }
            public int? idBomMaterial { get; set; }
            public string BomCode { get; set; }
            public string Bom { get; set; }
            public int idMaterial { get; set; }
            public string MaterialCode { get; set; }
            public string Material { get; set; }
            public int? idMaterialClass { get; set; }
            public string MaterialClassCode { get; set; }
            public string MaterialClass { get; set; }
            public int idUnitSelling { get; set; }
            public string UnitSellingCode { get; set; }
            public string UnitSelling { get; set; }
            public int idPhase { get; set; }
            public string PhaseCode { get; set; }
            public string Phase { get; set; }
        }
        public class Customer_CHECKResult
        {
            public string Action { get; set; }
            public bool? Check { get; set; }
            public string RCODE { get; set; }
            public string Message { get; set; }
            public int? idUserLock { get; set; }
            public string UserLock { get; set; }
        }
        public class Customer_GETResult
        {
            public int idCustomer { get; set; }
            public string Code { get; set; }
            public string BusinessName { get; set; }
            public string VAT { get; set; }
            public string FiscalCode { get; set; }
            public string City { get; set; }
            public string Address { get; set; }
            public string ZIP { get; set; }
            public int? idCountry { get; set; }
            public string Country { get; set; }
            public string Province { get; set; }
            public string Tel1 { get; set; }
            public string Tel2 { get; set; }
            public string Mob1 { get; set; }
            public string Mob2 { get; set; }
            public string Fax1 { get; set; }
            public string Fax2 { get; set; }
            public string Email1 { get; set; }
            public string Email2 { get; set; }
            public int? idUserCreate { get; set; }
            public string UserCreate { get; set; }
            public int? idUserLastEdit { get; set; }
            public string UserLastEdit { get; set; }
            public DateTimeOffset? DateLoad { get; set; }
            public DateTimeOffset? DateLastEdit { get; set; }
            public bool isDeleted { get; set; }
            public bool? allowEdit { get; set; }
            public bool? isInternalCustomer { get; set; }
            public int? idCompanySector { get; set; }
            public string CompanySectorCode { get; set; }
            public string CompanySector { get; set; }
            public int? idPaymentType { get; set; }
            public string PaymentTypeCode { get; set; }
            public string PaymentType { get; set; }
            public string AddressFull { get; set; }
            public string AddressFullFormatted { get; set; }
            public string AddressFullHTML { get; set; }
            public decimal? Latitude { get; set; }
            public decimal? Longitude { get; set; }
            public int? idLead { get; set; }
            public int? idUserLock { get; set; }
            public string UserLock { get; set; }
            public DateTimeOffset? DateUserLock { get; set; }
            public bool? flStock { get; set; }
        }
        public class Customer_GET_BusinessPartnerResult
        {
            public int idBusinessPartnerType { get; set; }
            public string BusinessPartnerTypeCode { get; set; }
            public string BusinessPartnerType { get; set; }
            public int idCustomerBusinessPartner { get; set; }
            public int idCustomer { get; set; }
            public string BusinessName { get; set; }
            public string VAT { get; set; }
            public string FiscalCode { get; set; }
            public int? idCountry { get; set; }
            public string Alpha2 { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
            public string Address { get; set; }
            public string ZIP { get; set; }
            public string Province { get; set; }
            public string Tel1 { get; set; }
            public string Tel2 { get; set; }
            public string Mob1 { get; set; }
            public string Mob2 { get; set; }
            public string Fax1 { get; set; }
            public string Fax2 { get; set; }
            public string Email1 { get; set; }
            public string Email2 { get; set; }
            public bool? isDeleted { get; set; }
            public string Ref1 { get; set; }
            public string Ref2 { get; set; }
            public string AddressFull { get; set; }
        }
        public class Customer_GET_ContactResult
        {
            public int idCustomerContact { get; set; }
            public int? idCustomer { get; set; }
            public string Title { get; set; }
            public string BusinessName { get; set; }
            public string FullName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int? idWorkFunction { get; set; }
            public string WorkFunction { get; set; }
            public int? idWorkDepartment { get; set; }
            public string WorkDepartment { get; set; }
            public bool? isDecisionMaker { get; set; }
            public string Tel1 { get; set; }
            public string Tel2 { get; set; }
            public string Mob1 { get; set; }
            public string Mob2 { get; set; }
            public string Email1 { get; set; }
            public string Email2 { get; set; }
            public int? idUserCreate { get; set; }
            public int? idUserLastEdit { get; set; }
            public DateTime? DateLoad { get; set; }
            public DateTime? DateLastEdit { get; set; }
            public bool? isDeleted { get; set; }
            public bool? isDefault { get; set; }
        }
        public class Customer_GET_DivisionResult
        {
            public int idCustomer { get; set; }
            public int idDivision { get; set; }
            public string Code { get; set; }
            public string Division { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class Customer_SEARCHResult
        {
            public int? idCustomer { get; set; }
            public string Code { get; set; }
            public string BusinessName { get; set; }
            public string VAT { get; set; }
            public string FiscalCode { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
            public string Province { get; set; }
            public string UserLock { get; set; }
            public int? idUserLock { get; set; }
            public int? idCustomerContact { get; set; }
            public string ContactFullName { get; set; }
            public string ContactPhone { get; set; }
            public string DivisionFull { get; set; }
            public bool? isDeleted { get; set; }
        }
        public class CustomerContact_GET_DetailResult
        {
            public int idCustomerContact { get; set; }
            public int? idCustomer { get; set; }
            public string Title { get; set; }
            public string BusinessName { get; set; }
            public string FullName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int? idWorkFunction { get; set; }
            public string WorkFunction { get; set; }
            public bool? isDecisionMaker { get; set; }
            public string Tel1 { get; set; }
            public string Tel2 { get; set; }
            public string Mob1 { get; set; }
            public string Mob2 { get; set; }
            public string Email1 { get; set; }
            public string Email2 { get; set; }
            public int? idUserCreate { get; set; }
            public int? idUserLastEdit { get; set; }
            public DateTimeOffset? DateLoad { get; set; }
            public DateTimeOffset? DateLastEdit { get; set; }
            public bool? isDeleted { get; set; }
        }
        public class Document_GET_DetailResult
        {
            public int idDocument { get; set; }
            public int? idEntityType { get; set; }
            public int? idEntity { get; set; }
            public string EntityCode { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string FolderPath { get; set; }
            public string FileUrl { get; set; }
            public string FileName { get; set; }
            public string FileName_NoExt { get; set; }
            public string FileExt { get; set; }
            public int? idUserCreate { get; set; }
            public string UserCreate { get; set; }
            public DateTimeOffset? DateUserCreate { get; set; }
        }
        public class Document_SEARCHResult
        {
            public int idDocument { get; set; }
            public int? idEntityType { get; set; }
            public int? idEntity { get; set; }
            public string EntityCode { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public string FolderPath { get; set; }
            public string FileUrl { get; set; }
            public string FileName { get; set; }
            public string FileName_NoExt { get; set; }
            public string FileExt { get; set; }
            public int? idUserCreate { get; set; }
            public string UserCreate { get; set; }
            public DateTimeOffset? DateUserCreate { get; set; }
        }
        public class Lock_GETResult
        {
            public string EntityCode { get; set; }
            public int id { get; set; }
            public string Code { get; set; }
            public string Name { get; set; }
            public int? idUserLock { get; set; }
            public string UserFull { get; set; }
            public DateTimeOffset? DateUserLock { get; set; }
        }
        public class Material_CHECKResult
        {
            public string Action { get; set; }
            public bool? Check { get; set; }
            public string RCODE { get; set; }
            public string Message { get; set; }
            public int? idUserLock { get; set; }
            public string UserLock { get; set; }
        }
        public class Material_CHECK_RecursionResult
        {
            public string Matrix { get; set; }
            public string MatrixCode { get; set; }
        }
        public class Material_GETResult
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
            public bool? flStock { get; set; }
            public string Note { get; set; }
            public int? isUsed { get; set; }
        }
        public class Material_GET_BomResult
        {
            public int idBom { get; set; }
            public int? idMaterial { get; set; }
            public string Code { get; set; }
            public string Bom { get; set; }
            public bool? isEnabled { get; set; }
            public bool? isDeleted { get; set; }
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
        public class Material_GET_MaterialFormatResult
        {
            public int idMaterialFormat { get; set; }
            public int idMaterial { get; set; }
            public int idUnitSelling { get; set; }
            public string UnitSellingCode { get; set; }
            public string UnitSelling { get; set; }
            public int? Decimals { get; set; }
            public decimal? vQtyBase { get; set; }
            public decimal? vQtyBox { get; set; }
            public decimal? vQtyMin { get; set; }
            public decimal? vQtyMax { get; set; }
            public decimal? vQtyMulti { get; set; }
            public decimal? vPriceWhosaler { get; set; }
            public decimal? vPriceCustomer { get; set; }
        }
        public class Material_GET_MaterialWarehouseResult
        {
            public int idMaterial { get; set; }
            public int idWarehouse { get; set; }
            public decimal? vQtyStock { get; set; }
            public string WarehouseCode { get; set; }
            public string Warehouse { get; set; }
            public int? idCustomer { get; set; }
            public string CustomerCode { get; set; }
            public string Customer { get; set; }
            public int? idSupplier { get; set; }
            public string SupplierCode { get; set; }
            public string Supplier { get; set; }
        }
        public class Material_GET_USAGE_MaterialResult
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
            public bool? flStock { get; set; }
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
        public class MD_GET_CompanySectorResult
        {
            public int idCompanySector { get; set; }
            public string Code { get; set; }
            public string CompanySector { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_CountryResult
        {
            public int idCountry { get; set; }
            public string Name { get; set; }
            public string Alpha2 { get; set; }
            public string Alpha3 { get; set; }
            public string Code { get; set; }
            public string iso_3166_2 { get; set; }
            public string region { get; set; }
            public string subRegion { get; set; }
            public string intermediateRegion { get; set; }
            public string regionCode { get; set; }
            public string subRegionCode { get; set; }
            public string intermediateRegionCode { get; set; }
        }
        public class MD_GET_CultureResult
        {
            public int idCulture { get; set; }
            public string Code { get; set; }
            public string Culture { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_CurrencyResult
        {
            public int idCurrency { get; set; }
            public string Code { get; set; }
            public string Currency { get; set; }
            public int? Dec { get; set; }
            public string Symbol { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_DivisionResult
        {
            public int idDivision { get; set; }
            public string Code { get; set; }
            public string Division { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_EntityTypeResult
        {
            public int idEntityType { get; set; }
            public string Code { get; set; }
            public string EntityType { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_FormulaResult
        {
            public int idFormula { get; set; }
            public string Code { get; set; }
            public string Formula { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_FormulaUmResult
        {
            public int idFormulaUm { get; set; }
            public string Code { get; set; }
            public string FormulaUm { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_IncotermResult
        {
            public int idIncoterm { get; set; }
            public string Code { get; set; }
            public string Incoterm { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_LanguageResult
        {
            public int idLanguage { get; set; }
            public string Code { get; set; }
            public string Language { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_MaterialClassResult
        {
            public int idMaterialClass { get; set; }
            public string Code { get; set; }
            public string MaterialClass { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_MaterialSectorResult
        {
            public int idMaterialSector { get; set; }
            public string Code { get; set; }
            public string MaterialSector { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_MaterialShapeResult
        {
            public int idMaterialShape { get; set; }
            public string Code { get; set; }
            public string MaterialShape { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
            public decimal? d1 { get; set; }
            public decimal? d2 { get; set; }
            public decimal? d3 { get; set; }
            public int? idDimensionFormulaUm { get; set; }
            public string DimensionFormulaUmCode { get; set; }
            public string DimensionFormulaUm { get; set; }
            public int? idFormula { get; set; }
            public string FormulaCode { get; set; }
            public string Formula { get; set; }
            public decimal? Area { get; set; }
            public int? idAreaFormulaUm { get; set; }
            public string AreaFormulaUmCode { get; set; }
            public int? AreaFormulaUm { get; set; }
        }
        public class MD_GET_MaterialStatusResult
        {
            public int idMaterialStatus { get; set; }
            public string Code { get; set; }
            public string MaterialStatus { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_MaterialTypeResult
        {
            public int idMaterialType { get; set; }
            public string Code { get; set; }
            public string MaterialType { get; set; }
            public decimal? SpecificWeight { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_PaymentTypeResult
        {
            public int idPaymentType { get; set; }
            public string Code { get; set; }
            public string PaymentType { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_PhaseCalculationResult
        {
            public int idPhaseCalculation { get; set; }
            public string Code { get; set; }
            public string PhaseCalculation { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_PhaseTypeResult
        {
            public int idPhaseType { get; set; }
            public string Code { get; set; }
            public string PhaseType { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_ResourceGroupResult
        {
            public int idResourceGroup { get; set; }
            public string Code { get; set; }
            public string ResourceGroup { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_ResourceTypeResult
        {
            public int idResourceType { get; set; }
            public string Code { get; set; }
            public string ResourceType { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_SalesAreaResult
        {
            public int idSalesArea { get; set; }
            public string Code { get; set; }
            public string SalesArea { get; set; }
            public string Description { get; set; }
            public bool? isEnabled { get; set; }
            public int? intOrder { get; set; }
            public string DocSignature { get; set; }
        }
        public class MD_GET_StockMovementStatusResult
        {
            public int idStockMovementStatus { get; set; }
            public string Code { get; set; }
            public string StockMovementStatus { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_StockMovementTypeResult
        {
            public int idStockMovementType { get; set; }
            public string Code { get; set; }
            public string StockMovementType { get; set; }
            public int? Sign { get; set; }
            public int? idStockMovementReverse { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_SupplierTypeResult
        {
            public int idSupplierType { get; set; }
            public string Code { get; set; }
            public string SupplierType { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_TimeZoneResult
        {
            public int idTimeZone { get; set; }
            public string id { get; set; }
            public string DisplayName { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_UnitMeasureResult
        {
            public int idUnitMeasure { get; set; }
            public string Code { get; set; }
            public string UnitMeasure { get; set; }
            public int? Decimals { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_UnitSellingResult
        {
            public int idUnitSelling { get; set; }
            public string Code { get; set; }
            public string UnitSelling { get; set; }
            public int? Decimals { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_WorkDepartmentResult
        {
            public int idWorkDepartment { get; set; }
            public string Code { get; set; }
            public string WorkDepartment { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class MD_GET_WorkFunctionResult
        {
            public int idWorkFunction { get; set; }
            public string Code { get; set; }
            public string WorkFunction { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class METEL_PriceList_GET_ALLResult
        {
            public int idMetelPriceList { get; set; }
            public int? idSupplier { get; set; }
            public string BusinessName { get; set; }
            public string SupplierCode { get; set; }
            public string PriceList { get; set; }
            public string CompanyCode { get; set; }
            public string VAT { get; set; }
            public string Number { get; set; }
            public DateTime? DateStart { get; set; }
            public DateTime? DateLastChange { get; set; }
            public string Version { get; set; }
            public DateTime? DateStartWholesaler { get; set; }
            public string Batch { get; set; }
            public DateTimeOffset? DateLastImport { get; set; }
            public int? idUserLastEdit { get; set; }
        }
        public class METEL_STG_GET_PriceListResult
        {
            public string IdentificazioneTracciato { get; set; }
            public string SiglaAzienda { get; set; }
            public string PartitaIVA { get; set; }
            public string NumeroListinoPrezzi { get; set; }
            public string DecorrenzaListinoPrezzi { get; set; }
            public string DataUltimaVariazioneImmissione { get; set; }
            public string DescrizioneListinoPrezzi { get; set; }
            public string Filler1 { get; set; }
            public string VersioneTracciatoListinoPrezzi { get; set; }
            public string DataDecorrenzaListinoGrossista { get; set; }
            public string Isopartita { get; set; }
            public string Filler2 { get; set; }
            public int? idSupplier { get; set; }
            public string BusinessName { get; set; }
            public string SupplierCode { get; set; }
            public int? MaterialCount { get; set; }
        }
        public class Phase_CHECKResult
        {
            public string Action { get; set; }
            public bool? Check { get; set; }
            public string RCODE { get; set; }
            public string Message { get; set; }
            public int? idUserLock { get; set; }
            public string UserLock { get; set; }
        }
        public class Phase_GETResult
        {
            public int idPhase { get; set; }
            public string Code { get; set; }
            public string Phase { get; set; }
            public int? idCurrency { get; set; }
            public int? idPhaseType { get; set; }
            public string PhaseTypeCode { get; set; }
            public string PhaseType { get; set; }
            public int? idSupplier { get; set; }
            public string SupplierCode { get; set; }
            public string Supplier { get; set; }
            public int? idResourceGroup { get; set; }
            public string ResourceGroupCode { get; set; }
            public string ResourceGroup { get; set; }
            public int? idResourceTooling { get; set; }
            public string ResourceToolingCode { get; set; }
            public string ResourceTooling { get; set; }
            public decimal? vToolingStart_mm { get; set; }
            public decimal? vUntooling_mm { get; set; }
            public decimal? vToolingK { get; set; }
            public int? idPhaseCalculation { get; set; }
            public string PhaseCalculationCode { get; set; }
            public string PhaseCalculation { get; set; }
            public decimal? vCycle_mm { get; set; }
            public int? idResource { get; set; }
            public string ResourceCode { get; set; }
            public string Resource { get; set; }
            public decimal? vK { get; set; }
            public decimal? vSupplier_DD { get; set; }
            public decimal? vSupplierCost_DD { get; set; }
            public string Note { get; set; }
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
        public class Phase_SEARCHResult
        {
            public int idPhase { get; set; }
            public string Code { get; set; }
            public string Phase { get; set; }
            public int? idCurrency { get; set; }
            public int? idPhaseType { get; set; }
            public string PhaseTypeCode { get; set; }
            public string PhaseType { get; set; }
            public int? idSupplier { get; set; }
            public string SupplierCode { get; set; }
            public string Supplier { get; set; }
            public int? idResourceGroup { get; set; }
            public string ResourceGroupCode { get; set; }
            public string ResourceGroup { get; set; }
            public int? idResourceTooling { get; set; }
            public string ResourceToolingCode { get; set; }
            public string ResourceTooling { get; set; }
            public decimal? vToolingStart_mm { get; set; }
            public decimal? vUntooling_mm { get; set; }
            public decimal? vToolingK { get; set; }
            public int? idPhaseCalculation { get; set; }
            public string PhaseCalculationCode { get; set; }
            public string PhaseCalculation { get; set; }
            public decimal? vCycle_mm { get; set; }
            public int? idResource { get; set; }
            public string ResourceCode { get; set; }
            public string Resource { get; set; }
            public decimal? vK { get; set; }
            public decimal? vSupplier_DD { get; set; }
            public decimal? vSupplierCost_DD { get; set; }
            public string Note { get; set; }
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
        public class Resource_CHECKResult
        {
            public string Action { get; set; }
            public bool? Check { get; set; }
            public string RCODE { get; set; }
            public string Message { get; set; }
            public int? idUserLock { get; set; }
            public string UserLock { get; set; }
        }
        public class Resource_GETResult
        {
            public int idResource { get; set; }
            public string Code { get; set; }
            public string Resource { get; set; }
            public decimal? vCostH { get; set; }
            public int? idResourceType { get; set; }
            public string ResourceTypeCode { get; set; }
            public string ResourceType { get; set; }
            public int? idResourceStatus { get; set; }
            public string ResourceStatusCode { get; set; }
            public string ResourceStatus { get; set; }
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
        public class Resource_GET_ResourceGroupResult
        {
            public int idRow { get; set; }
            public int idResource { get; set; }
            public int idResourceGroup { get; set; }
            public string ResourceCode { get; set; }
            public string ResourceGroup { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class Resource_SEARCHResult
        {
            public int idResource { get; set; }
            public string Code { get; set; }
            public string Resource { get; set; }
            public decimal? vCostH { get; set; }
            public int? idResourceType { get; set; }
            public string ResourceTypeCode { get; set; }
            public string ResourceType { get; set; }
            public int? idResourceStatus { get; set; }
            public string ResourceStatusCode { get; set; }
            public string ResourceStatus { get; set; }
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
        public class Role_GETResult
        {
            public string idRole { get; set; }
            public string RoleName { get; set; }
        }
        public class StockMovement_CHECKResult
        {
            public string Action { get; set; }
            public bool? Check { get; set; }
            public string RCODE { get; set; }
            public string Message { get; set; }
            public int? idUserLock { get; set; }
            public string UserLock { get; set; }
        }
        public class StockMovement_GETResult
        {
            public int idStockMovement { get; set; }
            public string Code { get; set; }
            public int? idStockMovementType { get; set; }
            public string StockMovementTypeCode { get; set; }
            public string StockMovementType { get; set; }
            public int? idStockMovementStatus { get; set; }
            public string StockMovementStatusCode { get; set; }
            public string StockMovementStatus { get; set; }
            public int? idWarehouseSource { get; set; }
            public string WarehouseSourceCode { get; set; }
            public string WarehouseSource { get; set; }
            public int? idWarehouseDest { get; set; }
            public string WarehouseDestCode { get; set; }
            public string WarehouseDest { get; set; }
            public int? idCurrency { get; set; }
            public string CurrencyCode { get; set; }
            public int? idSupplier { get; set; }
            public string SupplierCode { get; set; }
            public string Supplier { get; set; }
            public int? idCustomer { get; set; }
            public string CustomerCode { get; set; }
            public string Customer { get; set; }
            public int? idJob { get; set; }
            public string JobCode { get; set; }
            public string Job { get; set; }
            public string PurchaseOrder { get; set; }
            public string SalesOrder { get; set; }
            public decimal? vMovementAmount { get; set; }
            public DateTime? DateStockMovement { get; set; }
            public int? intDateStockMovement { get; set; }
            public DateTimeOffset? DateLoad { get; set; }
            public int? intDateLoad { get; set; }
            public bool? isDeleted { get; set; }
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
        public class StockMovement_GET_DetailResult
        {
            public int idStockMovement { get; set; }
            public string Code { get; set; }
            public DateTime? DateStockMovement { get; set; }
            public int? intDateStockMovement { get; set; }
            public DateTimeOffset? DateLoad { get; set; }
            public int? intDateLoad { get; set; }
            public int? idStockMovementType { get; set; }
            public string StockMovementTypeCode { get; set; }
            public string StockMovementType { get; set; }
            public int? Sign { get; set; }
            public int? idStockMovementStatus { get; set; }
            public string StockMovementStatusCode { get; set; }
            public string StockMovementStatus { get; set; }
            public string WarehouseSourceCode { get; set; }
            public string WarehouseSource { get; set; }
            public int? idWarehouseDest { get; set; }
            public string WarehouseDestCode { get; set; }
            public string WarehouseDest { get; set; }
            public int? idUserCreate { get; set; }
            public string Progressive { get; set; }
            public int? idMaterial { get; set; }
            public string MaterialCode { get; set; }
            public string Material { get; set; }
            public int? idUnitSelling { get; set; }
            public string UnitSellingCode { get; set; }
            public string UnitSelling { get; set; }
            public decimal? vQty { get; set; }
            public decimal? vAmountUnit { get; set; }
            public decimal? vAmountTot { get; set; }
            public decimal? vQtyBase { get; set; }
            public decimal? vAmountBaseUnit { get; set; }
            public decimal? vAmountBaseTot { get; set; }
            public int? idSupplier { get; set; }
            public string SupplierCode { get; set; }
            public string Supplier { get; set; }
            public int? idCustomer { get; set; }
            public string CustomerCode { get; set; }
            public string Customer { get; set; }
            public int? idJob { get; set; }
            public string JobCode { get; set; }
            public string Job { get; set; }
            public string PurchaseOrder { get; set; }
            public string SalesOrder { get; set; }
        }
        public class StockMovement_SEARCHResult
        {
            public int idStockMovement { get; set; }
            public string Code { get; set; }
            public DateTime? DateStockMovement { get; set; }
            public int? intDateStockMovement { get; set; }
            public DateTimeOffset? DateLoad { get; set; }
            public int? intDateLoad { get; set; }
            public int? idStockMovementType { get; set; }
            public string StockMovementTypeCode { get; set; }
            public string StockMovementType { get; set; }
            public int? Sign { get; set; }
            public int? idStockMovementStatus { get; set; }
            public string StockMovementStatusCode { get; set; }
            public string StockMovementStatus { get; set; }
            public string WarehouseSourceCode { get; set; }
            public string WarehouseSource { get; set; }
            public int? idWarehouseDest { get; set; }
            public string WarehouseDestCode { get; set; }
            public string WarehouseDest { get; set; }
            public int? idUserCreate { get; set; }
            public string Progressive { get; set; }
            public int? idMaterial { get; set; }
            public string MaterialCode { get; set; }
            public string Material { get; set; }
            public int? idUnitSelling { get; set; }
            public string UnitSellingCode { get; set; }
            public string UnitSelling { get; set; }
            public int? Decimals { get; set; }
            public decimal? vQty { get; set; }
            public decimal? vAmountUnit { get; set; }
            public decimal? vAmountTot { get; set; }
            public decimal? vQtyBase { get; set; }
            public decimal? vAmountBaseUnit { get; set; }
            public decimal? vAmountBaseTot { get; set; }
            public int? idSupplier { get; set; }
            public string SupplierCode { get; set; }
            public string Supplier { get; set; }
            public int? idCustomer { get; set; }
            public string CustomerCode { get; set; }
            public string Customer { get; set; }
            public int? idJob { get; set; }
            public string JobCode { get; set; }
            public string Job { get; set; }
            public string PurchaseOrder { get; set; }
            public string SalesOrder { get; set; }
        }
        public class Supplier_CHECKResult
        {
            public string Action { get; set; }
            public bool? Check { get; set; }
            public string RCODE { get; set; }
            public string Message { get; set; }
            public int? idUserLock { get; set; }
            public string UserLock { get; set; }
        }
        public class Supplier_GETResult
        {
            public int idSupplier { get; set; }
            public string Code { get; set; }
            public string BusinessName { get; set; }
            public string VAT { get; set; }
            public string FiscalCode { get; set; }
            public string City { get; set; }
            public string Address { get; set; }
            public string ZIP { get; set; }
            public int? idCountry { get; set; }
            public string Country { get; set; }
            public string Province { get; set; }
            public string Tel1 { get; set; }
            public string Tel2 { get; set; }
            public string Mob1 { get; set; }
            public string Mob2 { get; set; }
            public string Fax1 { get; set; }
            public string Fax2 { get; set; }
            public string Email1 { get; set; }
            public string Email2 { get; set; }
            public int? idUserCreate { get; set; }
            public string UserCreate { get; set; }
            public int? idUserLastEdit { get; set; }
            public string UserLastEdit { get; set; }
            public DateTimeOffset? DateLoad { get; set; }
            public DateTimeOffset? DateLastEdit { get; set; }
            public bool isDeleted { get; set; }
            public bool? allowEdit { get; set; }
            public bool? isInternalSupplier { get; set; }
            public int? idCompanySector { get; set; }
            public string CompanySectorCode { get; set; }
            public string CompanySector { get; set; }
            public int? idPaymentType { get; set; }
            public string PaymentTypeCode { get; set; }
            public string PaymentType { get; set; }
            public string AddressFull { get; set; }
            public string AddressFullFormatted { get; set; }
            public string AddressFullHTML { get; set; }
            public decimal? Latitude { get; set; }
            public decimal? Longitude { get; set; }
            public int? idLead { get; set; }
            public int? idUserLock { get; set; }
            public string UserLock { get; set; }
            public DateTimeOffset? DateUserLock { get; set; }
            public string MetelCompanyCode { get; set; }
            public bool? flStock { get; set; }
        }
        public class Supplier_GET_BusinessPartnerResult
        {
            public int idBusinessPartnerType { get; set; }
            public string BusinessPartnerTypeCode { get; set; }
            public string BusinessPartnerType { get; set; }
            public int idSupplierBusinessPartner { get; set; }
            public int idSupplier { get; set; }
            public string BusinessName { get; set; }
            public string VAT { get; set; }
            public string FiscalCode { get; set; }
            public int? idCountry { get; set; }
            public string Alpha2 { get; set; }
            public string Country { get; set; }
            public string City { get; set; }
            public string Address { get; set; }
            public string ZIP { get; set; }
            public string Province { get; set; }
            public string Tel1 { get; set; }
            public string Tel2 { get; set; }
            public string Mob1 { get; set; }
            public string Mob2 { get; set; }
            public string Fax1 { get; set; }
            public string Fax2 { get; set; }
            public string Email1 { get; set; }
            public string Email2 { get; set; }
            public bool? isDeleted { get; set; }
            public string Ref1 { get; set; }
            public string Ref2 { get; set; }
            public string AddressFull { get; set; }
        }
        public class Supplier_GET_ContactResult
        {
            public int idSupplierContact { get; set; }
            public int? idSupplier { get; set; }
            public string Title { get; set; }
            public string BusinessName { get; set; }
            public string FullName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int? idWorkFunction { get; set; }
            public string WorkFunction { get; set; }
            public int? idWorkDepartment { get; set; }
            public string WorkDepartment { get; set; }
            public bool? isDecisionMaker { get; set; }
            public string Tel1 { get; set; }
            public string Tel2 { get; set; }
            public string Mob1 { get; set; }
            public string Mob2 { get; set; }
            public string Email1 { get; set; }
            public string Email2 { get; set; }
            public int? idUserCreate { get; set; }
            public int? idUserLastEdit { get; set; }
            public DateTime? DateLoad { get; set; }
            public DateTime? DateLastEdit { get; set; }
            public bool? isDeleted { get; set; }
            public bool? isDefault { get; set; }
        }
        public class Supplier_GET_DivisionResult
        {
            public int idSupplier { get; set; }
            public int idDivision { get; set; }
            public string Code { get; set; }
            public string Division { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class Supplier_GET_SupplierTypeResult
        {
            public int idSupplier { get; set; }
            public int idSupplierType { get; set; }
            public string Code { get; set; }
            public string SupplierType { get; set; }
            public int? intOrder { get; set; }
            public bool? isEnabled { get; set; }
        }
        public class Supplier_SEARCHResult
        {
            public int? idSupplier { get; set; }
            public string Code { get; set; }
            public string BusinessName { get; set; }
            public string VAT { get; set; }
            public string FiscalCode { get; set; }
            public string City { get; set; }
            public string Country { get; set; }
            public string Province { get; set; }
            public string UserLock { get; set; }
            public int? idUserLock { get; set; }
            public int? idSupplierContact { get; set; }
            public string ContactFullName { get; set; }
            public string ContactPhone { get; set; }
            public string DivisionFull { get; set; }
            public bool? isDeleted { get; set; }
        }
        public class SupplierContact_GET_DetailResult
        {
            public int idSupplierContact { get; set; }
            public int? idSupplier { get; set; }
            public string Title { get; set; }
            public string BusinessName { get; set; }
            public string FullName { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int? idWorkFunction { get; set; }
            public string WorkFunction { get; set; }
            public bool? isDecisionMaker { get; set; }
            public string Tel1 { get; set; }
            public string Tel2 { get; set; }
            public string Mob1 { get; set; }
            public string Mob2 { get; set; }
            public string Email1 { get; set; }
            public string Email2 { get; set; }
            public int? idUserCreate { get; set; }
            public int? idUserLastEdit { get; set; }
            public DateTimeOffset? DateLoad { get; set; }
            public DateTimeOffset? DateLastEdit { get; set; }
            public bool? isDeleted { get; set; }
        }
        public class USER_GET_APP_MenuLeftResult
        {
            public int idMenuItem { get; set; }
            public string Code { get; set; }
            public string Title { get; set; }
            public string Icon { get; set; }
            public string Link { get; set; }
            public string Action { get; set; }
            public bool? Home { get; set; }
            public bool? Group { get; set; }
            public string PathMatch { get; set; }
            public string Target { get; set; }
            public int? idMenuItemParent { get; set; }
            public int? intOrder { get; set; }
        }
        public class USER_GET_APP_MenuTopResult
        {
            public int idMenuItem { get; set; }
            public string Code { get; set; }
            public string Title { get; set; }
            public string Icon { get; set; }
            public string Link { get; set; }
            public string Action { get; set; }
            public bool? Home { get; set; }
            public bool? Group { get; set; }
            public string PathMatch { get; set; }
            public string Target { get; set; }
            public int? idMenuItemParent { get; set; }
            public int? intOrder { get; set; }
        }
        public class Warehouse_SEARCHResult
        {
            public int idWarehouse { get; set; }
            public string Code { get; set; }
            public string Warehouse { get; set; }
            public int? idCustomer { get; set; }
            public string CustomerCode { get; set; }
            public string Customer { get; set; }
            public int? idSupplier { get; set; }
            public string SupplierCode { get; set; }
            public string Supplier { get; set; }
        }
    }
    */
}