using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SPToCore.Test
{
    public partial class EMGERPContext : DbContext
    {
        public EMGERPContext()
        {
        }

        public EMGERPContext(DbContextOptions<EMGERPContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AnBom> AnBom { get; set; }
        public virtual DbSet<AnBomMaterial> AnBomMaterial { get; set; }
        public virtual DbSet<AnBomPhase> AnBomPhase { get; set; }
        public virtual DbSet<AnBomPhaseMaterial> AnBomPhaseMaterial { get; set; }
        public virtual DbSet<AnCustomer> AnCustomer { get; set; }
        public virtual DbSet<AnCustomerBusinessPartner> AnCustomerBusinessPartner { get; set; }
        public virtual DbSet<AnCustomerContact> AnCustomerContact { get; set; }
        public virtual DbSet<AnCustomerDivision> AnCustomerDivision { get; set; }
        public virtual DbSet<AnMaterial> AnMaterial { get; set; }
        public virtual DbSet<AnMaterialFormat> AnMaterialFormat { get; set; }
        public virtual DbSet<AnMaterialWarehouse> AnMaterialWarehouse { get; set; }
        public virtual DbSet<AnMetelPriceList> AnMetelPriceList { get; set; }
        public virtual DbSet<AnPhase> AnPhase { get; set; }
        public virtual DbSet<AnPhaseMaterial> AnPhaseMaterial { get; set; }
        public virtual DbSet<AnResource> AnResource { get; set; }
        public virtual DbSet<AnResourceGroup> AnResourceGroup { get; set; }
        public virtual DbSet<AnSupplier> AnSupplier { get; set; }
        public virtual DbSet<AnSupplierBusinessPartner> AnSupplierBusinessPartner { get; set; }
        public virtual DbSet<AnSupplierContact> AnSupplierContact { get; set; }
        public virtual DbSet<AnSupplierDivision> AnSupplierDivision { get; set; }
        public virtual DbSet<AnSupplierType> AnSupplierType { get; set; }
        public virtual DbSet<AnUser> AnUser { get; set; }
        public virtual DbSet<AnWarehouse> AnWarehouse { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUserRoles> AspNetUserRoles { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<DistintaScorpionCsv> DistintaScorpionCsv { get; set; }
        public virtual DbSet<FactDocument> FactDocument { get; set; }
        public virtual DbSet<FactJobHeader> FactJobHeader { get; set; }
        public virtual DbSet<FactJobLine> FactJobLine { get; set; }
        public virtual DbSet<FactJobLineMaterial> FactJobLineMaterial { get; set; }
        public virtual DbSet<FactStockMovementDetail> FactStockMovementDetail { get; set; }
        public virtual DbSet<FactStockMovementHeader> FactStockMovementHeader { get; set; }
        public virtual DbSet<Log4Net> Log4Net { get; set; }
        public virtual DbSet<MdBusinessPartnerType> MdBusinessPartnerType { get; set; }
        public virtual DbSet<MdCompanySector> MdCompanySector { get; set; }
        public virtual DbSet<MdCountry> MdCountry { get; set; }
        public virtual DbSet<MdCulture> MdCulture { get; set; }
        public virtual DbSet<MdCurrency> MdCurrency { get; set; }
        public virtual DbSet<MdDivision> MdDivision { get; set; }
        public virtual DbSet<MdEntityType> MdEntityType { get; set; }
        public virtual DbSet<MdFormula> MdFormula { get; set; }
        public virtual DbSet<MdFormulaUm> MdFormulaUm { get; set; }
        public virtual DbSet<MdIncoterm> MdIncoterm { get; set; }
        public virtual DbSet<MdIncotermTsl> MdIncotermTsl { get; set; }
        public virtual DbSet<MdJobStatus> MdJobStatus { get; set; }
        public virtual DbSet<MdJobType> MdJobType { get; set; }
        public virtual DbSet<MdLanguage> MdLanguage { get; set; }
        public virtual DbSet<MdMaterialClass> MdMaterialClass { get; set; }
        public virtual DbSet<MdMaterialFormatOld> MdMaterialFormatOld { get; set; }
        public virtual DbSet<MdMaterialSector> MdMaterialSector { get; set; }
        public virtual DbSet<MdMaterialShape> MdMaterialShape { get; set; }
        public virtual DbSet<MdMaterialStatus> MdMaterialStatus { get; set; }
        public virtual DbSet<MdMaterialType> MdMaterialType { get; set; }
        public virtual DbSet<MdPaymentType> MdPaymentType { get; set; }
        public virtual DbSet<MdPaymentTypeTsl> MdPaymentTypeTsl { get; set; }
        public virtual DbSet<MdPhaseCalculation> MdPhaseCalculation { get; set; }
        public virtual DbSet<MdPhaseType> MdPhaseType { get; set; }
        public virtual DbSet<MdResourceGroup> MdResourceGroup { get; set; }
        public virtual DbSet<MdResourceStatus> MdResourceStatus { get; set; }
        public virtual DbSet<MdResourceType> MdResourceType { get; set; }
        public virtual DbSet<MdSalesArea> MdSalesArea { get; set; }
        public virtual DbSet<MdStockMovementStatus> MdStockMovementStatus { get; set; }
        public virtual DbSet<MdStockMovementType> MdStockMovementType { get; set; }
        public virtual DbSet<MdSupplierType> MdSupplierType { get; set; }
        public virtual DbSet<MdTimeZone> MdTimeZone { get; set; }
        public virtual DbSet<MdUnitMeasure> MdUnitMeasure { get; set; }
        public virtual DbSet<MdUnitSelling> MdUnitSelling { get; set; }
        public virtual DbSet<MdWorkDepartment> MdWorkDepartment { get; set; }
        public virtual DbSet<MdWorkFunction> MdWorkFunction { get; set; }
        public virtual DbSet<MdWorkFunctionTsl> MdWorkFunctionTsl { get; set; }
        public virtual DbSet<StgMetelMaterial> StgMetelMaterial { get; set; }
        public virtual DbSet<StgMetelPriceList> StgMetelPriceList { get; set; }
        public virtual DbSet<SysMenuLeft> SysMenuLeft { get; set; }
        public virtual DbSet<SysMenuLeftRole> SysMenuLeftRole { get; set; }
        public virtual DbSet<SysMenuTop> SysMenuTop { get; set; }
        public virtual DbSet<SysMenuTopRole> SysMenuTopRole { get; set; }
        public virtual DbSet<VwAnBom> VwAnBom { get; set; }
        public virtual DbSet<VwAnBomMaterial> VwAnBomMaterial { get; set; }
        public virtual DbSet<VwAnBomPhase> VwAnBomPhase { get; set; }
        public virtual DbSet<VwAnBomPhaseMaterial> VwAnBomPhaseMaterial { get; set; }
        public virtual DbSet<VwAnCustomer> VwAnCustomer { get; set; }
        public virtual DbSet<VwAnCustomerBusinessPartner> VwAnCustomerBusinessPartner { get; set; }
        public virtual DbSet<VwAnCustomerContact> VwAnCustomerContact { get; set; }
        public virtual DbSet<VwAnMaterial> VwAnMaterial { get; set; }
        public virtual DbSet<VwAnMaterialFormat> VwAnMaterialFormat { get; set; }
        public virtual DbSet<VwAnMaterialWarehouse> VwAnMaterialWarehouse { get; set; }
        public virtual DbSet<VwAnMetelPriceList> VwAnMetelPriceList { get; set; }
        public virtual DbSet<VwAnPhase> VwAnPhase { get; set; }
        public virtual DbSet<VwAnResource> VwAnResource { get; set; }
        public virtual DbSet<VwAnResourceGroup> VwAnResourceGroup { get; set; }
        public virtual DbSet<VwAnSupplier> VwAnSupplier { get; set; }
        public virtual DbSet<VwAnSupplierBusinessPartner> VwAnSupplierBusinessPartner { get; set; }
        public virtual DbSet<VwAnSupplierContact> VwAnSupplierContact { get; set; }
        public virtual DbSet<VwAnWarehouse> VwAnWarehouse { get; set; }
        public virtual DbSet<VwFactDocument> VwFactDocument { get; set; }
        public virtual DbSet<VwFactStockMovementDetail> VwFactStockMovementDetail { get; set; }
        public virtual DbSet<VwFactStockMovementHeader> VwFactStockMovementHeader { get; set; }
        public virtual DbSet<VwLock> VwLock { get; set; }
        public virtual DbSet<VwUser> VwUser { get; set; }
        public virtual DbSet<VwUserRole> VwUserRole { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DN1;Initial Catalog=EMGERP;Persist Security Info=True;User ID=EMGERP_User;Password=emgerp;Connection Timeout=360");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnBom>(entity =>
            {
                entity.HasKey(e => e.IdBom);

                entity.ToTable("anBom");

                entity.Property(e => e.IdBom).HasColumnName("idBom");

                entity.Property(e => e.Bom)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.IdUserLastEdit).HasColumnName("idUserLastEdit");

                entity.Property(e => e.IdUserLock).HasColumnName("idUserLock");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");
            });

            modelBuilder.Entity<AnBomMaterial>(entity =>
            {
                entity.HasKey(e => e.IdBomMaterial)
                    .HasName("PK_anBomComponent");

                entity.ToTable("anBomMaterial");

                entity.Property(e => e.IdBomMaterial).HasColumnName("idBomMaterial");

                entity.Property(e => e.IdBom).HasColumnName("idBom");

                entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");

                entity.Property(e => e.IdUnitSelling).HasColumnName("idUnitSelling");

                entity.Property(e => e.Progressive)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.VQty)
                    .HasColumnName("vQty")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyBase)
                    .HasColumnName("vQtyBase")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyBaseScrap)
                    .HasColumnName("vQtyBaseScrap")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyScrap)
                    .HasColumnName("vQtyScrap")
                    .HasColumnType("decimal(16, 6)");

                entity.HasOne(d => d.IdBomNavigation)
                    .WithMany(p => p.AnBomMaterial)
                    .HasForeignKey(d => d.IdBom)
                    .HasConstraintName("FK_anBomComponent_");

                entity.HasOne(d => d.IdMaterialNavigation)
                    .WithMany(p => p.AnBomMaterial)
                    .HasForeignKey(d => d.IdMaterial)
                    .HasConstraintName("FK_anBomComponent_anMaterial");
            });

            modelBuilder.Entity<AnBomPhase>(entity =>
            {
                entity.HasKey(e => e.IdBomPhase);

                entity.ToTable("anBomPhase");

                entity.Property(e => e.IdBomPhase).HasColumnName("idBomPhase");

                entity.Property(e => e.IdBom).HasColumnName("idBom");

                entity.Property(e => e.IdCurrency).HasColumnName("idCurrency");

                entity.Property(e => e.IdPhase).HasColumnName("idPhase");

                entity.Property(e => e.IdPhaseCalculation).HasColumnName("idPhaseCalculation");

                entity.Property(e => e.IdPhaseType).HasColumnName("idPhaseType");

                entity.Property(e => e.IdResource).HasColumnName("idResource");

                entity.Property(e => e.IdResourceGroup).HasColumnName("idResourceGroup");

                entity.Property(e => e.IdResourceTooling).HasColumnName("idResourceTooling");

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.Note)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Phase)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Progressive)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.VCycleMm)
                    .HasColumnName("vCycle_mm")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VK)
                    .HasColumnName("vK")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VSupplierCostDd)
                    .HasColumnName("vSupplierCost_DD")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VSupplierDd)
                    .HasColumnName("vSupplier_DD")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VToolingK)
                    .HasColumnName("vToolingK")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VToolingStartMm)
                    .HasColumnName("vToolingStart_mm")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VUntoolingMm)
                    .HasColumnName("vUntooling_mm")
                    .HasColumnType("decimal(16, 6)");

                entity.HasOne(d => d.IdBomNavigation)
                    .WithMany(p => p.AnBomPhase)
                    .HasForeignKey(d => d.IdBom)
                    .HasConstraintName("FK_anBomPhase_anBom");

                entity.HasOne(d => d.IdPhaseNavigation)
                    .WithMany(p => p.AnBomPhase)
                    .HasForeignKey(d => d.IdPhase)
                    .HasConstraintName("FK_anBomPhase_anPhase");
            });

            modelBuilder.Entity<AnBomPhaseMaterial>(entity =>
            {
                entity.HasKey(e => e.IdBomPhaseMaterial);

                entity.ToTable("anBomPhaseMaterial");

                entity.Property(e => e.IdBomPhaseMaterial).HasColumnName("idBomPhaseMaterial");

                entity.Property(e => e.IdBom).HasColumnName("idBom");

                entity.Property(e => e.IdBomMaterial).HasColumnName("idBomMaterial");

                entity.Property(e => e.IdBomPhase).HasColumnName("idBomPhase");
            });

            modelBuilder.Entity<AnCustomer>(entity =>
            {
                entity.HasKey(e => e.IdCustomer);

                entity.ToTable("anCustomer");

                entity.Property(e => e.IdCustomer).HasColumnName("idCustomer");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AllowEdit).HasColumnName("allowEdit");

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FiscalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlStock).HasColumnName("flStock");

                entity.Property(e => e.IdCompanySector).HasColumnName("idCompanySector");

                entity.Property(e => e.IdCountry).HasColumnName("idCountry");

                entity.Property(e => e.IdCustomerSource).HasColumnName("idCustomerSource");

                entity.Property(e => e.IdLead).HasColumnName("idLead");

                entity.Property(e => e.IdPaymentType).HasColumnName("idPaymentType");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.IdUserLastEdit).HasColumnName("idUserLastEdit");

                entity.Property(e => e.IdUserLock).HasColumnName("idUserLock");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.IsInternalCustomer).HasColumnName("isInternalCustomer");

                entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Mob1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mob2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tel1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tel2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCountryNavigation)
                    .WithMany(p => p.AnCustomer)
                    .HasForeignKey(d => d.IdCountry)
                    .HasConstraintName("FK_anCustomer_mdCountry");

                entity.HasOne(d => d.IdPaymentTypeNavigation)
                    .WithMany(p => p.AnCustomer)
                    .HasForeignKey(d => d.IdPaymentType)
                    .HasConstraintName("FK_anCustomer_mdPaymentType");

                entity.HasOne(d => d.IdUserCreateNavigation)
                    .WithMany(p => p.AnCustomerIdUserCreateNavigation)
                    .HasForeignKey(d => d.IdUserCreate)
                    .HasConstraintName("FK_anCustomer_anUser2");

                entity.HasOne(d => d.IdUserLastEditNavigation)
                    .WithMany(p => p.AnCustomerIdUserLastEditNavigation)
                    .HasForeignKey(d => d.IdUserLastEdit)
                    .HasConstraintName("FK_anCustomer_anUser");

                entity.HasOne(d => d.IdUserLockNavigation)
                    .WithMany(p => p.AnCustomerIdUserLockNavigation)
                    .HasForeignKey(d => d.IdUserLock)
                    .HasConstraintName("FK_anCustomer_anUser1");
            });

            modelBuilder.Entity<AnCustomerBusinessPartner>(entity =>
            {
                entity.HasKey(e => e.IdCustomerBusinessPartner);

                entity.ToTable("anCustomerBusinessPartner");

                entity.Property(e => e.IdCustomerBusinessPartner).HasColumnName("idCustomerBusinessPartner");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fax2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiscalCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdBusinessPartnerType).HasColumnName("idBusinessPartnerType");

                entity.Property(e => e.IdCountry).HasColumnName("idCountry");

                entity.Property(e => e.IdCustomer).HasColumnName("idCustomer");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Mob1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mob2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ref1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ref2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tel1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdBusinessPartnerTypeNavigation)
                    .WithMany(p => p.AnCustomerBusinessPartner)
                    .HasForeignKey(d => d.IdBusinessPartnerType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_anCustomerBusinessPartner_mdBusinessPartnerType");

                
            });

            modelBuilder.Entity<AnCustomerContact>(entity =>
            {
                entity.HasKey(e => e.IdCustomerContact);

                entity.ToTable("anCustomerContact");

                entity.Property(e => e.IdCustomerContact).HasColumnName("idCustomerContact");

                entity.Property(e => e.DateLastEdit).HasColumnType("datetime");

                entity.Property(e => e.DateLoad).HasColumnType("datetime");

                entity.Property(e => e.Email1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdCustomer).HasColumnName("idCustomer");

                entity.Property(e => e.IdOpportunity).HasColumnName("idOpportunity");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.IdUserLastEdit).HasColumnName("idUserLastEdit");

                entity.Property(e => e.IdWorkDepartment).HasColumnName("idWorkDepartment");

                entity.Property(e => e.IdWorkFunction).HasColumnName("idWorkFunction");

                entity.Property(e => e.IsDecisionMaker).HasColumnName("isDecisionMaker");

                entity.Property(e => e.IsDefault).HasColumnName("isDefault");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mob1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mob2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tel1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tel2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);

             
                entity.HasOne(d => d.IdWorkFunctionNavigation)
                    .WithMany(p => p.AnCustomerContact)
                    .HasForeignKey(d => d.IdWorkFunction)
                    .HasConstraintName("FK_anCustomerContact_mdWorkFunction");
            });

            modelBuilder.Entity<AnCustomerDivision>(entity =>
            {
                entity.HasKey(e => new { e.IdCustomer, e.IdDivision });

                entity.ToTable("anCustomerDivision");

                entity.Property(e => e.IdCustomer).HasColumnName("idCustomer");

                entity.Property(e => e.IdDivision).HasColumnName("idDivision");
            });

            modelBuilder.Entity<AnMaterial>(entity =>
            {
                entity.HasKey(e => e.IdMaterial);

                entity.ToTable("anMaterial");

                entity.HasIndex(e => e.IdBom)
                    .HasName("IX_idBom");

                entity.HasIndex(e => e.IdMaterialClass)
                    .HasName("IX_idMaterialClass");

                entity.HasIndex(e => e.IdMaterialSector)
                    .HasName("IX_idMaterialSector");

                entity.HasIndex(e => e.IdMaterialShape)
                    .HasName("IX_idMaterialShape");

                entity.HasIndex(e => e.IdMaterialStatus)
                    .HasName("IX_idMaterialStatus");

                entity.HasIndex(e => e.IdMaterialType)
                    .HasName("IX_idMaterialType");

                entity.HasIndex(e => e.IdSupplier)
                    .HasName("IX_idSupplier");

                entity.HasIndex(e => e.IdUnitSelling)
                    .HasName("IX_idUnitSelling");

                entity.HasIndex(e => e.IdUserCreate)
                    .HasName("IX_idUserCreate");

                entity.HasIndex(e => e.IdUserLastEdit)
                    .HasName("IX_idUserLastEdit");

                entity.HasIndex(e => e.IdUserLock)
                    .HasName("IX_idUserLock");

                entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.BarcodeType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ean)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Electrocode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Etim)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlStock).HasColumnName("flStock");

                entity.Property(e => e.Height).HasColumnType("decimal(16, 6)");

                entity.Property(e => e.IdBom).HasColumnName("idBOM");

                entity.Property(e => e.IdMaterialClass).HasColumnName("idMaterialClass");

                entity.Property(e => e.IdMaterialSector).HasColumnName("idMaterialSector");

                entity.Property(e => e.IdMaterialShape).HasColumnName("idMaterialShape");

                entity.Property(e => e.IdMaterialStatus).HasColumnName("idMaterialStatus");

                entity.Property(e => e.IdMaterialType).HasColumnName("idMaterialType");

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.IdUnitSelling).HasColumnName("idUnitSelling");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.IdUserLastEdit).HasColumnName("idUserLastEdit");

                entity.Property(e => e.IdUserLock).HasColumnName("idUserLock");

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.Lenght).HasColumnType("decimal(16, 6)");

                entity.Property(e => e.Material)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VPrice)
                    .HasColumnName("vPrice")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VPriceAvg)
                    .HasColumnName("vPriceAvg")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VPriceLast)
                    .HasColumnName("vPriceLast")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyBase)
                    .HasColumnName("vQtyBase")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyBox)
                    .HasColumnName("vQtyBox")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyMax)
                    .HasColumnName("vQtyMax")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyMin)
                    .HasColumnName("vQtyMin")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyMulti)
                    .HasColumnName("vQtyMulti")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.Weight).HasColumnType("decimal(16, 6)");

                entity.Property(e => e.Width).HasColumnType("decimal(16, 6)");

                entity.HasOne(d => d.IdBomNavigation)
                    .WithMany(p => p.AnMaterial)
                    .HasForeignKey(d => d.IdBom)
                    .HasConstraintName("FK_anMaterial_anBom");

                entity.HasOne(d => d.IdMaterialClassNavigation)
                    .WithMany(p => p.AnMaterial)
                    .HasForeignKey(d => d.IdMaterialClass)
                    .HasConstraintName("FK_anMaterial_mdMaterialClass");

                entity.HasOne(d => d.IdMaterialSectorNavigation)
                    .WithMany(p => p.AnMaterial)
                    .HasForeignKey(d => d.IdMaterialSector)
                    .HasConstraintName("FK_anMaterial_mdMaterialSector");

                entity.HasOne(d => d.IdMaterialShapeNavigation)
                    .WithMany(p => p.AnMaterial)
                    .HasForeignKey(d => d.IdMaterialShape)
                    .HasConstraintName("FK_anMaterial_mdMaterialShape");

                entity.HasOne(d => d.IdMaterialStatusNavigation)
                    .WithMany(p => p.AnMaterial)
                    .HasForeignKey(d => d.IdMaterialStatus)
                    .HasConstraintName("FK_anMaterial_mdMaterialStatus");

                entity.HasOne(d => d.IdMaterialTypeNavigation)
                    .WithMany(p => p.AnMaterial)
                    .HasForeignKey(d => d.IdMaterialType)
                    .HasConstraintName("FK_anMaterial_mdMaterialType");

                entity.HasOne(d => d.IdSupplierNavigation)
                    .WithMany(p => p.AnMaterial)
                    .HasForeignKey(d => d.IdSupplier)
                    .HasConstraintName("FK_anMaterial_anSupplier");

                entity.HasOne(d => d.IdUnitSellingNavigation)
                    .WithMany(p => p.AnMaterial)
                    .HasForeignKey(d => d.IdUnitSelling)
                    .HasConstraintName("FK_anMaterial_mdUnitSelling");

                entity.HasOne(d => d.IdUserCreateNavigation)
                    .WithMany(p => p.AnMaterialIdUserCreateNavigation)
                    .HasForeignKey(d => d.IdUserCreate)
                    .HasConstraintName("FK_anMaterial_anUser");

                entity.HasOne(d => d.IdUserLastEditNavigation)
                    .WithMany(p => p.AnMaterialIdUserLastEditNavigation)
                    .HasForeignKey(d => d.IdUserLastEdit)
                    .HasConstraintName("FK_anMaterial_anUser1");

                entity.HasOne(d => d.IdUserLockNavigation)
                    .WithMany(p => p.AnMaterialIdUserLockNavigation)
                    .HasForeignKey(d => d.IdUserLock)
                    .HasConstraintName("FK_anMaterial_anUser2");
            });

            modelBuilder.Entity<AnMaterialFormat>(entity =>
            {
                entity.HasKey(e => e.IdMaterialFormat);

                entity.ToTable("anMaterialFormat");

                entity.Property(e => e.IdMaterialFormat).HasColumnName("idMaterialFormat");

                entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");

                entity.Property(e => e.IdUnitSelling).HasColumnName("idUnitSelling");

                entity.Property(e => e.VPriceCustomer)
                    .HasColumnName("vPriceCustomer")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VPriceWhosaler)
                    .HasColumnName("vPriceWhosaler")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyBase)
                    .HasColumnName("vQtyBase")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyBox)
                    .HasColumnName("vQtyBox")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyMax)
                    .HasColumnName("vQtyMax")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyMin)
                    .HasColumnName("vQtyMin")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyMulti)
                    .HasColumnName("vQtyMulti")
                    .HasColumnType("decimal(16, 6)");

                entity.HasOne(d => d.IdMaterialNavigation)
                    .WithMany(p => p.AnMaterialFormat)
                    .HasForeignKey(d => d.IdMaterial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_anMaterialFormat_anMaterial");

                entity.HasOne(d => d.IdUnitSellingNavigation)
                    .WithMany(p => p.AnMaterialFormat)
                    .HasForeignKey(d => d.IdUnitSelling)
                    .HasConstraintName("FK_anMaterialFormat_mdUnitSelling");
            });

            modelBuilder.Entity<AnMaterialWarehouse>(entity =>
            {
                entity.HasKey(e => new { e.IdMaterial, e.IdWarehouse })
                    .HasName("PK_anMaterialWharehouse");

                entity.ToTable("anMaterialWarehouse");

                entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");

                entity.Property(e => e.IdWarehouse).HasColumnName("idWarehouse");

                entity.Property(e => e.VQtyStock)
                    .HasColumnName("vQtyStock")
                    .HasColumnType("decimal(16, 6)");
            });

            modelBuilder.Entity<AnMetelPriceList>(entity =>
            {
                entity.HasKey(e => e.IdMetelPriceList);

                entity.ToTable("anMetelPriceList");

                entity.Property(e => e.IdMetelPriceList).HasColumnName("idMetelPriceList");

                entity.Property(e => e.Batch)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DateLastChange).HasColumnType("smalldatetime");

                entity.Property(e => e.DateStart).HasColumnType("smalldatetime");

                entity.Property(e => e.DateStartWholesaler).HasColumnType("smalldatetime");

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.IdUserLastEdit).HasColumnName("idUserLastEdit");

                entity.Property(e => e.Number)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PriceList)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AnPhase>(entity =>
            {
                entity.HasKey(e => e.IdPhase);

                entity.ToTable("anPhase");

                entity.Property(e => e.IdPhase).HasColumnName("idPhase");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCurrency).HasColumnName("idCurrency");

                entity.Property(e => e.IdPhaseCalculation).HasColumnName("idPhaseCalculation");

                entity.Property(e => e.IdPhaseType).HasColumnName("idPhaseType");

                entity.Property(e => e.IdResource).HasColumnName("idResource");

                entity.Property(e => e.IdResourceGroup).HasColumnName("idResourceGroup");

                entity.Property(e => e.IdResourceTooling).HasColumnName("idResourceTooling");

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.IdUserLastEdit).HasColumnName("idUserLastEdit");

                entity.Property(e => e.IdUserLock).HasColumnName("idUserLock");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.Note)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Phase)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VCycleMm)
                    .HasColumnName("vCycle_mm")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VK)
                    .HasColumnName("vK")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VSupplierCostDd)
                    .HasColumnName("vSupplierCost_DD")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VSupplierDd)
                    .HasColumnName("vSupplier_DD")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VToolingK)
                    .HasColumnName("vToolingK")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VToolingStartMm)
                    .HasColumnName("vToolingStart_mm")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VUntoolingMm)
                    .HasColumnName("vUntooling_mm")
                    .HasColumnType("decimal(16, 6)");

                entity.HasOne(d => d.IdCurrencyNavigation)
                    .WithMany(p => p.AnPhase)
                    .HasForeignKey(d => d.IdCurrency)
                    .HasConstraintName("FK_anPhase_mdCurrency");

                entity.HasOne(d => d.IdPhaseCalculationNavigation)
                    .WithMany(p => p.AnPhase)
                    .HasForeignKey(d => d.IdPhaseCalculation)
                    .HasConstraintName("FK_anPhase_mdPhaseCalculation");

                entity.HasOne(d => d.IdPhaseTypeNavigation)
                    .WithMany(p => p.AnPhase)
                    .HasForeignKey(d => d.IdPhaseType)
                    .HasConstraintName("FK_anPhase_mdPhaseType");

                entity.HasOne(d => d.IdResourceNavigation)
                    .WithMany(p => p.AnPhaseIdResourceNavigation)
                    .HasForeignKey(d => d.IdResource)
                    .HasConstraintName("FK_anPhase_anResource1");

                entity.HasOne(d => d.IdResourceGroupNavigation)
                    .WithMany(p => p.AnPhase)
                    .HasForeignKey(d => d.IdResourceGroup)
                    .HasConstraintName("FK_anPhase_mdResourceGroup");

                entity.HasOne(d => d.IdResourceToolingNavigation)
                    .WithMany(p => p.AnPhaseIdResourceToolingNavigation)
                    .HasForeignKey(d => d.IdResourceTooling)
                    .HasConstraintName("FK_anPhase_anResource");

                entity.HasOne(d => d.IdSupplierNavigation)
                    .WithMany(p => p.AnPhase)
                    .HasForeignKey(d => d.IdSupplier)
                    .HasConstraintName("FK_anPhase_anSupplier");

                entity.HasOne(d => d.IdUserCreateNavigation)
                    .WithMany(p => p.AnPhaseIdUserCreateNavigation)
                    .HasForeignKey(d => d.IdUserCreate)
                    .HasConstraintName("FK_anPhase_anUser1");

                entity.HasOne(d => d.IdUserLastEditNavigation)
                    .WithMany(p => p.AnPhaseIdUserLastEditNavigation)
                    .HasForeignKey(d => d.IdUserLastEdit)
                    .HasConstraintName("FK_anPhase_anUser2");

                entity.HasOne(d => d.IdUserLockNavigation)
                    .WithMany(p => p.AnPhaseIdUserLockNavigation)
                    .HasForeignKey(d => d.IdUserLock)
                    .HasConstraintName("FK_anPhase_anUser");
            });

            modelBuilder.Entity<AnPhaseMaterial>(entity =>
            {
                entity.HasKey(e => e.IdPhaseMaterial);

                entity.ToTable("anPhaseMaterial");

                entity.Property(e => e.IdPhaseMaterial).HasColumnName("idPhaseMaterial");

                entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");

                entity.Property(e => e.IdPhase).HasColumnName("idPhase");

                entity.Property(e => e.IdUnitSelling).HasColumnName("idUnitSelling");

                entity.Property(e => e.VQty)
                    .HasColumnName("vQty")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyBase)
                    .HasColumnName("vQtyBase")
                    .HasColumnType("decimal(16, 6)");

                entity.HasOne(d => d.IdMaterialNavigation)
                    .WithMany(p => p.AnPhaseMaterial)
                    .HasForeignKey(d => d.IdMaterial)
                    .HasConstraintName("FK_anPhaseMaterial_anMaterial");

                entity.HasOne(d => d.IdPhaseNavigation)
                    .WithMany(p => p.AnPhaseMaterial)
                    .HasForeignKey(d => d.IdPhase)
                    .HasConstraintName("FK_anPhaseMaterial_anPhase");
            });

            modelBuilder.Entity<AnResource>(entity =>
            {
                entity.HasKey(e => e.IdResource);

                entity.ToTable("anResource");

                entity.Property(e => e.IdResource).HasColumnName("idResource");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdResourceStatus).HasColumnName("idResourceStatus");

                entity.Property(e => e.IdResourceType).HasColumnName("idResourceType");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.IdUserLastEdit).HasColumnName("idUserLastEdit");

                entity.Property(e => e.IdUserLock).HasColumnName("idUserLock");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.Resource)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VCostH)
                    .HasColumnName("vCostH")
                    .HasColumnType("decimal(16, 6)");

                entity.HasOne(d => d.IdResourceStatusNavigation)
                    .WithMany(p => p.AnResource)
                    .HasForeignKey(d => d.IdResourceStatus)
                    .HasConstraintName("FK_anResource_mdResourceStatus");

                entity.HasOne(d => d.IdResourceTypeNavigation)
                    .WithMany(p => p.AnResource)
                    .HasForeignKey(d => d.IdResourceType)
                    .HasConstraintName("FK_anResource_mdResourceType");

                entity.HasOne(d => d.IdUserCreateNavigation)
                    .WithMany(p => p.AnResourceIdUserCreateNavigation)
                    .HasForeignKey(d => d.IdUserCreate)
                    .HasConstraintName("FK_anResource_anUser");

                entity.HasOne(d => d.IdUserLastEditNavigation)
                    .WithMany(p => p.AnResourceIdUserLastEditNavigation)
                    .HasForeignKey(d => d.IdUserLastEdit)
                    .HasConstraintName("FK_anResource_anUser2");

                entity.HasOne(d => d.IdUserLockNavigation)
                    .WithMany(p => p.AnResourceIdUserLockNavigation)
                    .HasForeignKey(d => d.IdUserLock)
                    .HasConstraintName("FK_anResource_anUser1");
            });

            modelBuilder.Entity<AnResourceGroup>(entity =>
            {
                entity.HasKey(e => e.IdRow)
                    .HasName("PK_anResourceGroup_1");

                entity.ToTable("anResourceGroup");

                entity.Property(e => e.IdRow).HasColumnName("idRow");

                entity.Property(e => e.IdResource).HasColumnName("idResource");

                entity.Property(e => e.IdResourceGroup).HasColumnName("idResourceGroup");

                entity.HasOne(d => d.IdResourceNavigation)
                    .WithMany(p => p.AnResourceGroup)
                    .HasForeignKey(d => d.IdResource)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_anResourceGroup_anResource");

                entity.HasOne(d => d.IdResourceGroupNavigation)
                    .WithMany(p => p.AnResourceGroup)
                    .HasForeignKey(d => d.IdResourceGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_anResourceGroup_mdResourceGroup");
            });

            modelBuilder.Entity<AnSupplier>(entity =>
            {
                entity.HasKey(e => e.IdSupplier);

                entity.ToTable("anSupplier");

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AllowEdit).HasColumnName("allowEdit");

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FiscalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlStock).HasColumnName("flStock");

                entity.Property(e => e.IdCompanySector).HasColumnName("idCompanySector");

                entity.Property(e => e.IdCountry).HasColumnName("idCountry");

                entity.Property(e => e.IdLead).HasColumnName("idLead");

                entity.Property(e => e.IdPaymentType).HasColumnName("idPaymentType");

                entity.Property(e => e.IdSupplierSource).HasColumnName("idSupplierSource");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.IdUserLastEdit).HasColumnName("idUserLastEdit");

                entity.Property(e => e.IdUserLock).HasColumnName("idUserLock");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.IsInternalSupplier).HasColumnName("isInternalSupplier");

                entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.MetelCompanyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Mob1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mob2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tel1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tel2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCountryNavigation)
                    .WithMany(p => p.AnSupplier)
                    .HasForeignKey(d => d.IdCountry)
                    .HasConstraintName("FK_anSupplier_mdCountry");

                entity.HasOne(d => d.IdPaymentTypeNavigation)
                    .WithMany(p => p.AnSupplier)
                    .HasForeignKey(d => d.IdPaymentType)
                    .HasConstraintName("FK_anSupplier_mdPaymentType");
            });

            modelBuilder.Entity<AnSupplierBusinessPartner>(entity =>
            {
                entity.HasKey(e => e.IdSupplierBusinessPartner);

                entity.ToTable("anSupplierBusinessPartner");

                entity.Property(e => e.IdSupplierBusinessPartner).HasColumnName("idSupplierBusinessPartner");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fax2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiscalCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdBusinessPartnerType).HasColumnName("idBusinessPartnerType");

                entity.Property(e => e.IdCountry).HasColumnName("idCountry");

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Mob1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mob2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ref1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ref2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tel1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdBusinessPartnerTypeNavigation)
                    .WithMany(p => p.AnSupplierBusinessPartner)
                    .HasForeignKey(d => d.IdBusinessPartnerType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_anSupplierBusinessPartner_mdBusinessPartnerType");

                entity.HasOne(d => d.IdSupplierNavigation)
                    .WithMany(p => p.AnSupplierBusinessPartner)
                    .HasForeignKey(d => d.IdSupplier)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_anSupplierBusinessPartner_anSupplier");
            });

            modelBuilder.Entity<AnSupplierContact>(entity =>
            {
                entity.HasKey(e => e.IdSupplierContact);

                entity.ToTable("anSupplierContact");

                entity.Property(e => e.IdSupplierContact).HasColumnName("idSupplierContact");

                entity.Property(e => e.DateLastEdit).HasColumnType("datetime");

                entity.Property(e => e.DateLoad).HasColumnType("datetime");

                entity.Property(e => e.Email1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdOpportunity).HasColumnName("idOpportunity");

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.IdUserLastEdit).HasColumnName("idUserLastEdit");

                entity.Property(e => e.IdWorkDepartment).HasColumnName("idWorkDepartment");

                entity.Property(e => e.IdWorkFunction).HasColumnName("idWorkFunction");

                entity.Property(e => e.IsDecisionMaker).HasColumnName("isDecisionMaker");

                entity.Property(e => e.IsDefault).HasColumnName("isDefault");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mob1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mob2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tel1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tel2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdSupplierNavigation)
                    .WithMany(p => p.AnSupplierContact)
                    .HasForeignKey(d => d.IdSupplier)
                    .HasConstraintName("FK_anSupplierContact_anSupplier");

                entity.HasOne(d => d.IdWorkFunctionNavigation)
                    .WithMany(p => p.AnSupplierContact)
                    .HasForeignKey(d => d.IdWorkFunction)
                    .HasConstraintName("FK_anSupplierContact_mdWorkFunction");
            });

            modelBuilder.Entity<AnSupplierDivision>(entity =>
            {
                entity.HasKey(e => new { e.IdSupplier, e.IdDivision });

                entity.ToTable("anSupplierDivision");

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.IdDivision).HasColumnName("idDivision");
            });

            modelBuilder.Entity<AnSupplierType>(entity =>
            {
                entity.HasKey(e => new { e.IdSupplier, e.IdSupplierType });

                entity.ToTable("anSupplierType");

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.IdSupplierType).HasColumnName("idSupplierType");

                entity.HasOne(d => d.IdSupplierNavigation)
                    .WithMany(p => p.AnSupplierType)
                    .HasForeignKey(d => d.IdSupplier)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_anSupplierType_anSupplier");

                entity.HasOne(d => d.IdSupplierTypeNavigation)
                    .WithMany(p => p.AnSupplierType)
                    .HasForeignKey(d => d.IdSupplierType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_anSupplierType_mdSupplierType");
            });

            modelBuilder.Entity<AnUser>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("PK_anUser_1");

                entity.ToTable("anUser");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("id")
                    .HasMaxLength(128);

                entity.Property(e => e.IdCulture).HasColumnName("idCulture");

                entity.Property(e => e.IdCurrency).HasColumnName("idCurrency");

                entity.Property(e => e.IdLanguage).HasColumnName("idLanguage");

                entity.Property(e => e.IdSalesArea).HasColumnName("idSalesArea");

                entity.Property(e => e.IdTimeZone).HasColumnName("idTimeZone");

                entity.Property(e => e.IsActive).HasColumnName("isActive");
            });

            modelBuilder.Entity<AnWarehouse>(entity =>
            {
                entity.HasKey(e => e.IdWarehouse);

                entity.ToTable("anWarehouse");

                entity.Property(e => e.IdWarehouse)
                    .HasColumnName("idWarehouse")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCustomer).HasColumnName("idCustomer");

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.Warehouse)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey, e.UserId })
                    .HasName("PK_dbo.AspNetUserLogins");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK_dbo.AspNetUserRoles");

                entity.Property(e => e.UserId).HasMaxLength(128);

                entity.Property(e => e.RoleId).HasMaxLength(128);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId");
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(128);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.JoinDate).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<DistintaScorpionCsv>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DistintaScorpionCSV");

                entity.Property(e => e.Area)
                    .HasColumnName("AREA")
                    .HasMaxLength(255);

                entity.Property(e => e.Autore).HasMaxLength(255);

                entity.Property(e => e.Commessa).HasMaxLength(255);

                entity.Property(e => e.Descrizione).HasMaxLength(1000);

                entity.Property(e => e.Elemento).HasMaxLength(255);

                entity.Property(e => e.Grezzo)
                    .HasColumnName("GREZZO")
                    .HasMaxLength(255);

                entity.Property(e => e.Gruppo).HasMaxLength(255);

                entity.Property(e => e.Lavorazione)
                    .HasColumnName("LAVORAZIONE")
                    .HasMaxLength(255);

                entity.Property(e => e.Macchina).HasMaxLength(255);

                entity.Property(e => e.Massa).HasMaxLength(255);

                entity.Property(e => e.Materiale).HasMaxLength(255);

                entity.Property(e => e.Note).HasMaxLength(1000);

                entity.Property(e => e.NoteAggiuntive)
                    .HasColumnName("Note aggiuntive")
                    .HasMaxLength(1000);

                entity.Property(e => e.NumeroParte)
                    .HasColumnName("Numero parte")
                    .HasMaxLength(255);

                entity.Property(e => e.PercorsoFile)
                    .HasColumnName("Percorso file")
                    .HasMaxLength(1000);

                entity.Property(e => e.QtaTot)
                    .HasColumnName("QTA' TOT")
                    .HasMaxLength(255);

                entity.Property(e => e.Qtà)
                    .HasColumnName("QTÀ")
                    .HasMaxLength(255);

                entity.Property(e => e.Rev)
                    .HasColumnName("REV")
                    .HasMaxLength(255);

                entity.Property(e => e.StrutturaDistintaComponenti)
                    .HasColumnName("Struttura distinta componenti")
                    .HasMaxLength(255);

                entity.Property(e => e.Trattamento)
                    .HasColumnName("TRATTAMENTO")
                    .HasMaxLength(255);

                entity.Property(e => e.TrattamentoSuperficiale)
                    .HasColumnName("TRATTAMENTO SUPERFICIALE")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<FactDocument>(entity =>
            {
                entity.HasKey(e => e.IdDocument);

                entity.ToTable("factDocument");

                entity.Property(e => e.IdDocument).HasColumnName("idDocument");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.FileExt)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileNameNoExt)
                    .HasColumnName("FileName_NoExt")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileUrl)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.FolderPath)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.IdEntity).HasColumnName("idEntity");

                entity.Property(e => e.IdEntityType).HasColumnName("idEntityType");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEntityTypeNavigation)
                    .WithMany(p => p.FactDocument)
                    .HasForeignKey(d => d.IdEntityType)
                    .HasConstraintName("FK_factDocument_sysEntityType");
            });

            modelBuilder.Entity<FactJobHeader>(entity =>
            {
                entity.HasKey(e => e.IdJob)
                    .HasName("PK_factJob");

                entity.ToTable("factJobHeader");

                entity.Property(e => e.IdJob).HasColumnName("idJob");

                entity.Property(e => e.Code)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DateEnd).HasColumnType("smalldatetime");

                entity.Property(e => e.DateStart).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IdCurrency).HasColumnName("idCurrency");

                entity.Property(e => e.IdCustomer).HasColumnName("idCustomer");

                entity.Property(e => e.IdJobStatus).HasColumnName("idJobStatus");

                entity.Property(e => e.IdJobType).HasColumnName("idJobType");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.IdUserLastEdit).HasColumnName("idUserLastEdit");

                entity.Property(e => e.IdUserLock).HasColumnName("idUserLock");

                entity.Property(e => e.IntDateEnd).HasColumnName("intDateEnd");

                entity.Property(e => e.IntDateStart).HasColumnName("intDateStart");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Job)
                    .HasMaxLength(255)
                    .IsUnicode(false);

              
                entity.HasOne(d => d.IdJobStatusNavigation)
                    .WithMany(p => p.FactJobHeader)
                    .HasForeignKey(d => d.IdJobStatus)
                    .HasConstraintName("FK_factJobHeader_mdJobStatus");

                entity.HasOne(d => d.IdJobTypeNavigation)
                    .WithMany(p => p.FactJobHeader)
                    .HasForeignKey(d => d.IdJobType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__factJobHe__idJob__5ADA3F77");
            });

            modelBuilder.Entity<FactJobLine>(entity =>
            {
                entity.HasKey(e => e.IdJobLine);

                entity.ToTable("factJobLine");

                entity.Property(e => e.IdJobLine).HasColumnName("idJobLine");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdJob).HasColumnName("idJob");

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.JobLine)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdJobNavigation)
                    .WithMany(p => p.FactJobLine)
                    .HasForeignKey(d => d.IdJob)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__factJobLi__idJob__5EAAD05B");
            });

            modelBuilder.Entity<FactJobLineMaterial>(entity =>
            {
                entity.HasKey(e => e.IdJobLineMaterial);

                entity.ToTable("factJobLineMaterial");

                entity.Property(e => e.IdJobLineMaterial).HasColumnName("idJobLineMaterial");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdJobLine).HasColumnName("idJobLine");

                entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.VQty)
                    .HasColumnName("vQty")
                    .HasColumnType("decimal(16, 6)");

                entity.HasOne(d => d.IdJobLineNavigation)
                    .WithMany(p => p.FactJobLineMaterial)
                    .HasForeignKey(d => d.IdJobLine)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__factJobLi__idJob__61873D06");

                entity.HasOne(d => d.IdMaterialNavigation)
                    .WithMany(p => p.FactJobLineMaterial)
                    .HasForeignKey(d => d.IdMaterial)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__factJobLi__idMat__627B613F");
            });

            modelBuilder.Entity<FactStockMovementDetail>(entity =>
            {
                entity.HasKey(e => e.IdStockMovementDetail);

                entity.ToTable("factStockMovementDetail");

                entity.Property(e => e.IdStockMovementDetail).HasColumnName("idStockMovementDetail");

                entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");

                entity.Property(e => e.IdStockMovement).HasColumnName("idStockMovement");

                entity.Property(e => e.IdUnitSelling).HasColumnName("idUnitSelling");

                entity.Property(e => e.Progressive)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.VAmountBaseTot)
                    .HasColumnName("vAmountBaseTot")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VAmountBaseUnit)
                    .HasColumnName("vAmountBaseUnit")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VAmountTot)
                    .HasColumnName("vAmountTot")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VAmountUnit)
                    .HasColumnName("vAmountUnit")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQty)
                    .HasColumnName("vQty")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyBase)
                    .HasColumnName("vQtyBase")
                    .HasColumnType("decimal(16, 6)");
            });

            modelBuilder.Entity<FactStockMovementHeader>(entity =>
            {
                entity.HasKey(e => e.IdStockMovement)
                    .HasName("PK_factStockMovement");

                entity.ToTable("factStockMovementHeader");

                entity.Property(e => e.IdStockMovement).HasColumnName("idStockMovement");

                entity.Property(e => e.Code)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DateStockMovement).HasColumnType("smalldatetime");

                entity.Property(e => e.IdCurrency).HasColumnName("idCurrency");

                entity.Property(e => e.IdCustomer).HasColumnName("idCustomer");

                entity.Property(e => e.IdJob).HasColumnName("idJob");

                entity.Property(e => e.IdStockMovementStatus).HasColumnName("idStockMovementStatus");

                entity.Property(e => e.IdStockMovementType).HasColumnName("idStockMovementType");

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.IdUserLastEdit).HasColumnName("idUserLastEdit");

                entity.Property(e => e.IdUserLock).HasColumnName("idUserLock");

                entity.Property(e => e.IdWarehouseDest).HasColumnName("idWarehouseDest");

                entity.Property(e => e.IdWarehouseSource).HasColumnName("idWarehouseSource");

                entity.Property(e => e.IntDateLoad).HasColumnName("intDateLoad");

                entity.Property(e => e.IntDateStockMovement).HasColumnName("intDateStockMovement");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.PurchaseOrder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOrder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VMovementAmount)
                    .HasColumnName("vMovementAmount")
                    .HasColumnType("decimal(16, 6)");
            });

            modelBuilder.Entity<Log4Net>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Exception)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.JsonPayload)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Level)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logger)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.WebApiMethod)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdBusinessPartnerType>(entity =>
            {
                entity.HasKey(e => e.IdBusinessPartnerType);

                entity.ToTable("mdBusinessPartnerType");

                entity.Property(e => e.IdBusinessPartnerType)
                    .HasColumnName("idBusinessPartnerType")
                    .ValueGeneratedNever();

                entity.Property(e => e.BusinessPartnerType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdCompanySector>(entity =>
            {
                entity.HasKey(e => e.IdCompanySector);

                entity.ToTable("mdCompanySector");

                entity.Property(e => e.IdCompanySector).HasColumnName("idCompanySector");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanySector)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");
            });

            modelBuilder.Entity<MdCountry>(entity =>
            {
                entity.HasKey(e => e.IdCountry);

                entity.ToTable("mdCountry");

                entity.Property(e => e.IdCountry).HasColumnName("idCountry");

                entity.Property(e => e.Alpha2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Alpha3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntermediateRegion)
                    .HasColumnName("intermediateRegion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntermediateRegionCode)
                    .HasColumnName("intermediateRegionCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Iso31662)
                    .HasColumnName("iso_3166_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegionCode)
                    .HasColumnName("regionCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubRegion)
                    .HasColumnName("subRegion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SubRegionCode)
                    .HasColumnName("subRegionCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdCulture>(entity =>
            {
                entity.HasKey(e => e.IdCulture);

                entity.ToTable("mdCulture");

                entity.Property(e => e.IdCulture)
                    .HasColumnName("idCulture")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Culture)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");
            });

            modelBuilder.Entity<MdCurrency>(entity =>
            {
                entity.HasKey(e => e.IdCurrency);

                entity.ToTable("mdCurrency");

                entity.Property(e => e.IdCurrency)
                    .HasColumnName("idCurrency")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.Symbol).HasMaxLength(5);
            });

            modelBuilder.Entity<MdDivision>(entity =>
            {
                entity.HasKey(e => e.IdDivision);

                entity.ToTable("mdDivision");

                entity.Property(e => e.IdDivision).HasColumnName("idDivision");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");
            });

            modelBuilder.Entity<MdEntityType>(entity =>
            {
                entity.HasKey(e => e.IdEntityType)
                    .HasName("PK_sysEntityType");

                entity.ToTable("mdEntityType");

                entity.Property(e => e.IdEntityType)
                    .HasColumnName("idEntityType")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntityType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");
            });

            modelBuilder.Entity<MdFormula>(entity =>
            {
                entity.HasKey(e => e.IdFormula);

                entity.ToTable("mdFormula");

                entity.Property(e => e.IdFormula)
                    .HasColumnName("idFormula")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Formula)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");
            });

            modelBuilder.Entity<MdFormulaUm>(entity =>
            {
                entity.HasKey(e => e.IdFormulaUm);

                entity.ToTable("mdFormulaUm");

                entity.Property(e => e.IdFormulaUm)
                    .HasColumnName("idFormulaUm")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FormulaUm)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");
            });

            modelBuilder.Entity<MdIncoterm>(entity =>
            {
                entity.HasKey(e => e.IdIncoterm);

                entity.ToTable("mdIncoterm");

                entity.Property(e => e.IdIncoterm)
                    .HasColumnName("idIncoterm")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Incoterm)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");
            });

            modelBuilder.Entity<MdIncotermTsl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("mdIncotermTSL");

                entity.Property(e => e.IdIncoterm).HasColumnName("idIncoterm");

                entity.Property(e => e.IdIncotermTsl).HasColumnName("idIncotermTSL");

                entity.Property(e => e.IdLanguage).HasColumnName("idLanguage");

                entity.Property(e => e.Incoterm).HasMaxLength(255);

                entity.Property(e => e.IncotermDescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdJobStatus>(entity =>
            {
                entity.HasKey(e => e.IdJobStatus);

                entity.ToTable("mdJobStatus");

                entity.Property(e => e.IdJobStatus)
                    .HasColumnName("idJobStatus")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.JobStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdJobType>(entity =>
            {
                entity.HasKey(e => e.IdJobType);

                entity.ToTable("mdJobType");

                entity.Property(e => e.IdJobType)
                    .HasColumnName("idJobType")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.JobType)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdLanguage>(entity =>
            {
                entity.HasKey(e => e.IdLanguage);

                entity.ToTable("mdLanguage");

                entity.Property(e => e.IdLanguage)
                    .HasColumnName("idLanguage")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.Language)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdMaterialClass>(entity =>
            {
                entity.HasKey(e => e.IdMaterialClass);

                entity.ToTable("mdMaterialClass");

                entity.Property(e => e.IdMaterialClass)
                    .HasColumnName("idMaterialClass")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.MaterialClass)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdMaterialFormatOld>(entity =>
            {
                entity.HasKey(e => e.IdMaterialFormat)
                    .HasName("PK_mdMaterialFormat");

                entity.ToTable("mdMaterialFormat_OLD");

                entity.Property(e => e.IdMaterialFormat).HasColumnName("idMaterialFormat");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.MaterialFormat)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdMaterialSector>(entity =>
            {
                entity.HasKey(e => e.IdMaterialSector);

                entity.ToTable("mdMaterialSector");

                entity.Property(e => e.IdMaterialSector).HasColumnName("idMaterialSector");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.MaterialSector)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdMaterialShape>(entity =>
            {
                entity.HasKey(e => e.IdMaterialShape);

                entity.ToTable("mdMaterialShape");

                entity.Property(e => e.IdMaterialShape).HasColumnName("idMaterialShape");

                entity.Property(e => e.Area).HasColumnType("decimal(16, 6)");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.D1)
                    .HasColumnName("d1")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.D2)
                    .HasColumnName("d2")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.D3)
                    .HasColumnName("d3")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.IdAreaFormulaUm).HasColumnName("idAreaFormulaUm");

                entity.Property(e => e.IdDimensionFormulaUm).HasColumnName("idDimensionFormulaUm");

                entity.Property(e => e.IdFormula).HasColumnName("idFormula");

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.MaterialShape)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdMaterialStatus>(entity =>
            {
                entity.HasKey(e => e.IdMaterialStatus);

                entity.ToTable("mdMaterialStatus");

                entity.Property(e => e.IdMaterialStatus)
                    .HasColumnName("idMaterialStatus")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.MaterialStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdMaterialType>(entity =>
            {
                entity.HasKey(e => e.IdMaterialType);

                entity.ToTable("mdMaterialType");

                entity.Property(e => e.IdMaterialType).HasColumnName("idMaterialType");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.MaterialType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SpecificWeight).HasColumnType("decimal(16, 6)");
            });

            modelBuilder.Entity<MdPaymentType>(entity =>
            {
                entity.HasKey(e => e.IdPaymentType);

                entity.ToTable("mdPaymentType");

                entity.Property(e => e.IdPaymentType).HasColumnName("idPaymentType");

                entity.Property(e => e.Code)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdPaymentTypeTsl>(entity =>
            {
                entity.HasKey(e => e.IdPaymentTypeTsl);

                entity.ToTable("mdPaymentTypeTSL");

                entity.Property(e => e.IdPaymentTypeTsl).HasColumnName("idPaymentTypeTSL");

                entity.Property(e => e.IdLanguage).HasColumnName("idLanguage");

                entity.Property(e => e.IdPaymentType).HasColumnName("idPaymentType");

                entity.Property(e => e.PaymentType).HasMaxLength(255);
            });

            modelBuilder.Entity<MdPhaseCalculation>(entity =>
            {
                entity.HasKey(e => e.IdPhaseCalculation);

                entity.ToTable("mdPhaseCalculation");

                entity.Property(e => e.IdPhaseCalculation).HasColumnName("idPhaseCalculation");

                entity.Property(e => e.Code)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.PhaseCalculation)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdPhaseType>(entity =>
            {
                entity.HasKey(e => e.IdPhaseType);

                entity.ToTable("mdPhaseType");

                entity.Property(e => e.IdPhaseType).HasColumnName("idPhaseType");

                entity.Property(e => e.Code)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.PhaseType)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdResourceGroup>(entity =>
            {
                entity.HasKey(e => e.IdResourceGroup);

                entity.ToTable("mdResourceGroup");

                entity.Property(e => e.IdResourceGroup).HasColumnName("idResourceGroup");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.ResourceGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdResourceStatus>(entity =>
            {
                entity.HasKey(e => e.IdResourceStatus);

                entity.ToTable("mdResourceStatus");

                entity.Property(e => e.IdResourceStatus)
                    .HasColumnName("idResourceStatus")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.ResourceStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdResourceType>(entity =>
            {
                entity.HasKey(e => e.IdResourceType);

                entity.ToTable("mdResourceType");

                entity.Property(e => e.IdResourceType).HasColumnName("idResourceType");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.ResourceType)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdSalesArea>(entity =>
            {
                entity.HasKey(e => e.IdSalesArea)
                    .HasName("PK_anArea");

                entity.ToTable("mdSalesArea");

                entity.Property(e => e.IdSalesArea)
                    .HasColumnName("idSalesArea")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DocSignature)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.SalesArea)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdStockMovementStatus>(entity =>
            {
                entity.HasKey(e => e.IdStockMovementStatus);

                entity.ToTable("mdStockMovementStatus");

                entity.Property(e => e.IdStockMovementStatus)
                    .HasColumnName("idStockMovementStatus")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.StockMovementStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdStockMovementType>(entity =>
            {
                entity.HasKey(e => e.IdStockMovementType);

                entity.ToTable("mdStockMovementType");

                entity.Property(e => e.IdStockMovementType)
                    .HasColumnName("idStockMovementType")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdStockMovementReverse).HasColumnName("idStockMovementReverse");

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.PCustomer).HasColumnName("P_Customer");

                entity.Property(e => e.PCustomerMandatory).HasColumnName("P_CustomerMandatory");

                entity.Property(e => e.PJob).HasColumnName("P_Job");

                entity.Property(e => e.PJobMandatory).HasColumnName("P_JobMandatory");

                entity.Property(e => e.PPurchaseOrder).HasColumnName("P_PurchaseOrder");

                entity.Property(e => e.PPurchaseOrderMandatory).HasColumnName("P_PurchaseOrderMandatory");

                entity.Property(e => e.PSalesOrder).HasColumnName("P_SalesOrder");

                entity.Property(e => e.PSalesOrderMandatory).HasColumnName("P_SalesOrderMandatory");

                entity.Property(e => e.PSupplier).HasColumnName("P_Supplier");

                entity.Property(e => e.PSupplierMandatory).HasColumnName("P_SupplierMandatory");

                entity.Property(e => e.PWarehouseDest).HasColumnName("P_WarehouseDest");

                entity.Property(e => e.PWarehouseDestMandatory).HasColumnName("P_WarehouseDestMandatory");

                entity.Property(e => e.PWarehouseSource).HasColumnName("P_WarehouseSource");

                entity.Property(e => e.PWarehouseSourceMandatory).HasColumnName("P_WarehouseSourceMandatory");

                entity.Property(e => e.StockMovementType)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdSupplierType>(entity =>
            {
                entity.HasKey(e => e.IdSupplierType);

                entity.ToTable("mdSupplierType");

                entity.Property(e => e.IdSupplierType)
                    .HasColumnName("idSupplierType")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.SupplierType)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdTimeZone>(entity =>
            {
                entity.HasKey(e => e.IdTimeZone);

                entity.ToTable("mdTimeZone");

                entity.Property(e => e.IdTimeZone).HasColumnName("idTimeZone");

                entity.Property(e => e.DisplayName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");
            });

            modelBuilder.Entity<MdUnitMeasure>(entity =>
            {
                entity.HasKey(e => e.IdUnitMeasure);

                entity.ToTable("mdUnitMeasure");

                entity.Property(e => e.IdUnitMeasure)
                    .HasColumnName("idUnitMeasure")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.UnitMeasure)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdUnitSelling>(entity =>
            {
                entity.HasKey(e => e.IdUnitSelling);

                entity.ToTable("mdUnitSelling");

                entity.Property(e => e.IdUnitSelling)
                    .HasColumnName("idUnitSelling")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.UnitSelling)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdWorkDepartment>(entity =>
            {
                entity.HasKey(e => e.IdWorkDepartment)
                    .HasName("PK_mdContactWorkDepartment");

                entity.ToTable("mdWorkDepartment");

                entity.Property(e => e.IdWorkDepartment).HasColumnName("idWorkDepartment");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.WorkDepartment)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdWorkFunction>(entity =>
            {
                entity.HasKey(e => e.IdWorkFunction)
                    .HasName("PK_mdContactWorkFunction");

                entity.ToTable("mdWorkFunction");

                entity.Property(e => e.IdWorkFunction)
                    .HasColumnName("idWorkFunction")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.WorkFunction)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MdWorkFunctionTsl>(entity =>
            {
                entity.HasKey(e => e.IdWorkFunctionTsl)
                    .HasName("PK_mdContactWorkFunctionTSL");

                entity.ToTable("mdWorkFunctionTSL");

                entity.Property(e => e.IdWorkFunctionTsl).HasColumnName("idWorkFunctionTSL");

                entity.Property(e => e.IdLanguage).HasColumnName("idLanguage");

                entity.Property(e => e.IdWorkFunction).HasColumnName("idWorkFunction");

                entity.Property(e => e.WorkFunction)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StgMetelMaterial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STG_METEL_MATERIAL");

                entity.Property(e => e.CodiceBarcode)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceEan)
                    .HasColumnName("CodiceEAN")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceElectrocod)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceEtim)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceProdottoAzienda)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CodiceValuta)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DataUltimaVariazione)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DescrizioneProdotto)
                    .HasMaxLength(43)
                    .IsUnicode(false);

                entity.Property(e => e.FamigliaSconto)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.FamigliaStatistica)
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.LeadTime)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MoltiplicatorePrezzo)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PrezzoPubblico)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.PrezzoRivenditore)
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.ProdottoComposto)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.QualificatoreCodiceBarcode)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.QuantitaCartone)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.QuantitaMassimaOrdinazione)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.QuantitaMinimaOrdinazione)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.QuantitaMultiplaOrdinazione)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SiglaMarchio)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.StatoProdotto)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UnitaDiMisura)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StgMetelPriceList>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STG_METEL_PRICE_LIST");

                entity.Property(e => e.DataDecorrenzaListinoGrossista)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DataUltimaVariazioneImmissione)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DecorrenzaListinoPrezzi)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.DescrizioneListinoPrezzi)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Filler1)
                    .HasMaxLength(39)
                    .IsUnicode(false);

                entity.Property(e => e.Filler2)
                    .HasMaxLength(81)
                    .IsUnicode(false);

                entity.Property(e => e.IdentificazioneTracciato)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Isopartita)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroListinoPrezzi)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PartitaIva)
                    .HasColumnName("PartitaIVA")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.SiglaAzienda)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.VersioneTracciatoListinoPrezzi)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysMenuLeft>(entity =>
            {
                entity.HasKey(e => e.IdMenuItem);

                entity.ToTable("sysMenuLeft");

                entity.Property(e => e.IdMenuItem)
                    .HasColumnName("idMenuItem")
                    .ValueGeneratedNever();

                entity.Property(e => e.Action)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdMenuItemParent).HasColumnName("idMenuItemParent");

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.Link)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PathMatch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Target)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysMenuLeftRole>(entity =>
            {
                entity.HasKey(e => new { e.IdRole, e.IdMenuItem });

                entity.ToTable("sysMenuLeftRole");

                entity.Property(e => e.IdRole)
                    .HasColumnName("idRole")
                    .HasMaxLength(128);

                entity.Property(e => e.IdMenuItem).HasColumnName("idMenuItem");
            });

            modelBuilder.Entity<SysMenuTop>(entity =>
            {
                entity.HasKey(e => e.IdMenuItem);

                entity.ToTable("sysMenuTop");

                entity.Property(e => e.IdMenuItem)
                    .HasColumnName("idMenuItem")
                    .ValueGeneratedNever();

                entity.Property(e => e.Action)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdMenuItemParent).HasColumnName("idMenuItemParent");

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.Link)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PathMatch)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Target)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SysMenuTopRole>(entity =>
            {
                entity.HasKey(e => new { e.IdRole, e.IdMenuItem });

                entity.ToTable("sysMenuTopRole");

                entity.Property(e => e.IdRole)
                    .HasColumnName("idRole")
                    .HasMaxLength(128);

                entity.Property(e => e.IdMenuItem).HasColumnName("idMenuItem");
            });

            modelBuilder.Entity<VwAnBom>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_anBom");

                entity.Property(e => e.Bom)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdBom).HasColumnName("idBom");

                entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.IdUserLastEdit).HasColumnName("idUserLastEdit");

                entity.Property(e => e.IdUserLock).HasColumnName("idUserLock");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.Material)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(201);

                entity.Property(e => e.UserLastEdit)
                    .IsRequired()
                    .HasMaxLength(201);

                entity.Property(e => e.UserLock).HasMaxLength(201);
            });

            modelBuilder.Entity<VwAnBomMaterial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_anBomMaterial");

                entity.Property(e => e.BomCodeComponent)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdBom).HasColumnName("idBom");

                entity.Property(e => e.IdBomComponent).HasColumnName("idBomComponent");

                entity.Property(e => e.IdBomMaterial).HasColumnName("idBomMaterial");

                entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");

                entity.Property(e => e.IdUnitSelling).HasColumnName("idUnitSelling");

                entity.Property(e => e.Material)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Progressive)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UnitSelling)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UnitSellingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VQty)
                    .HasColumnName("vQty")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyBase)
                    .HasColumnName("vQtyBase")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyBaseScrap)
                    .HasColumnName("vQtyBaseScrap")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyScrap)
                    .HasColumnName("vQtyScrap")
                    .HasColumnType("decimal(16, 6)");
            });

            modelBuilder.Entity<VwAnBomPhase>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_anBomPhase");

                entity.Property(e => e.Bom)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BomCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdBom).HasColumnName("idBom");

                entity.Property(e => e.IdBomPhase).HasColumnName("idBomPhase");

                entity.Property(e => e.IdCurrency).HasColumnName("idCurrency");

                entity.Property(e => e.IdPhase).HasColumnName("idPhase");

                entity.Property(e => e.IdPhaseCalculation).HasColumnName("idPhaseCalculation");

                entity.Property(e => e.IdPhaseType).HasColumnName("idPhaseType");

                entity.Property(e => e.IdResource).HasColumnName("idResource");

                entity.Property(e => e.IdResourceGroup).HasColumnName("idResourceGroup");

                entity.Property(e => e.IdResourceTooling).HasColumnName("idResourceTooling");

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.Note)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Phase)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhaseCalculation)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PhaseCalculationCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PhaseType)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PhaseTypeCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Progressive)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Resource)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceGroupCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceTooling)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceToolingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VCycleMm)
                    .HasColumnName("vCycle_mm")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.VK)
                    .HasColumnName("vK")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.VSupplierCostDd)
                    .HasColumnName("vSupplierCost_DD")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.VSupplierDd)
                    .HasColumnName("vSupplier_DD")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.VToolingK)
                    .HasColumnName("vToolingK")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.VToolingStartMm)
                    .HasColumnName("vToolingStart_mm")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.VUntoolingMm)
                    .HasColumnName("vUntooling_mm")
                    .HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<VwAnBomPhaseMaterial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_anBomPhaseMaterial");

                entity.Property(e => e.Bom)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BomCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdBom).HasColumnName("idBom");

                entity.Property(e => e.IdBomMaterial).HasColumnName("idBomMaterial");

                entity.Property(e => e.IdBomPhase).HasColumnName("idBomPhase");

                entity.Property(e => e.IdBomPhaseMaterial).HasColumnName("idBomPhaseMaterial");

                entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");

                entity.Property(e => e.IdMaterialClass).HasColumnName("idMaterialClass");

                entity.Property(e => e.IdPhase).HasColumnName("idPhase");

                entity.Property(e => e.IdUnitSelling).HasColumnName("idUnitSelling");

                entity.Property(e => e.Material)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialClass)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialClassCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phase)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhaseCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProgressiveMaterial)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ProgressivePhase)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UnitSelling)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UnitSellingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAnCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_anCustomer");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressFull)
                    .IsRequired()
                    .HasMaxLength(820);

                entity.Property(e => e.AddressFullFormatted).HasMaxLength(817);

                entity.Property(e => e.AddressFullHtml)
                    .IsRequired()
                    .HasColumnName("AddressFullHTML")
                    .HasMaxLength(827);

                entity.Property(e => e.AllowEdit).HasColumnName("allowEdit");

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanySector)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CompanySectorCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Email1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FiscalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlStock).HasColumnName("flStock");

                entity.Property(e => e.IdCompanySector).HasColumnName("idCompanySector");

                entity.Property(e => e.IdCountry).HasColumnName("idCountry");

                entity.Property(e => e.IdCustomer).HasColumnName("idCustomer");

                entity.Property(e => e.IdLead).HasColumnName("idLead");

                entity.Property(e => e.IdPaymentType).HasColumnName("idPaymentType");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.IdUserLastEdit).HasColumnName("idUserLastEdit");

                entity.Property(e => e.IdUserLock).HasColumnName("idUserLock");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsInternalCustomer).HasColumnName("isInternalCustomer");

                entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Mob1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mob2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tel1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tel2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(201);

                entity.Property(e => e.UserLastEdit)
                    .IsRequired()
                    .HasMaxLength(201);

                entity.Property(e => e.UserLock).HasMaxLength(201);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAnCustomerBusinessPartner>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_anCustomerBusinessPartner");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressFull)
                    .IsRequired()
                    .HasMaxLength(435);

                entity.Property(e => e.AddressFullFormatted).HasMaxLength(432);

                entity.Property(e => e.AddressFullHtml)
                    .IsRequired()
                    .HasColumnName("AddressFullHTML")
                    .HasMaxLength(442);

                entity.Property(e => e.Alpha2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessPartnerType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessPartnerTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Email1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fax2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiscalCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdBusinessPartnerType).HasColumnName("idBusinessPartnerType");

                entity.Property(e => e.IdCountry).HasColumnName("idCountry");

                entity.Property(e => e.IdCustomer).HasColumnName("idCustomer");

                entity.Property(e => e.IdCustomerBusinessPartner).HasColumnName("idCustomerBusinessPartner");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Mob1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mob2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ref1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ref2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tel1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAnCustomerContact>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_anCustomerContact");

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateLastEdit).HasColumnType("datetime");

                entity.Property(e => e.DateLoad).HasColumnType("datetime");

                entity.Property(e => e.Email1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(511)
                    .IsUnicode(false);

                entity.Property(e => e.IdCustomer).HasColumnName("idCustomer");

                entity.Property(e => e.IdCustomerContact).HasColumnName("idCustomerContact");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.IdUserLastEdit).HasColumnName("idUserLastEdit");

                entity.Property(e => e.IdWorkDepartment).HasColumnName("idWorkDepartment");

                entity.Property(e => e.IdWorkFunction).HasColumnName("idWorkFunction");

                entity.Property(e => e.IsDecisionMaker).HasColumnName("isDecisionMaker");

                entity.Property(e => e.IsDefault).HasColumnName("isDefault");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mob1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mob2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tel1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tel2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WorkDepartment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkFunction)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAnMaterial>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_anMaterial");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.BarcodeType)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Bom)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BomCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ean)
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.Electrocode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Etim)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlStock).HasColumnName("flStock");

                entity.Property(e => e.Height).HasColumnType("decimal(16, 6)");

                entity.Property(e => e.IdBom).HasColumnName("idBom");

                entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");

                entity.Property(e => e.IdMaterialClass).HasColumnName("idMaterialClass");

                entity.Property(e => e.IdMaterialSector).HasColumnName("idMaterialSector");

                entity.Property(e => e.IdMaterialShape).HasColumnName("idMaterialShape");

                entity.Property(e => e.IdMaterialStatus).HasColumnName("idMaterialStatus");

                entity.Property(e => e.IdMaterialType).HasColumnName("idMaterialType");

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.IdUnitSelling).HasColumnName("idUnitSelling");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.IdUserLastEdit).HasColumnName("idUserLastEdit");

                entity.Property(e => e.IdUserLock).HasColumnName("idUserLock");

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.Lenght).HasColumnType("decimal(16, 6)");

                entity.Property(e => e.Material)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialClass)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialClassCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialSector)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialSectorCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialShape)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialShapeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialStatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitSelling)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UnitSellingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(201);

                entity.Property(e => e.UserLastEdit)
                    .IsRequired()
                    .HasMaxLength(201);

                entity.Property(e => e.UserLock).HasMaxLength(201);

                entity.Property(e => e.VPrice)
                    .HasColumnName("vPrice")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VPriceAvg)
                    .HasColumnName("vPriceAvg")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VPriceLast)
                    .HasColumnName("vPriceLast")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyBase)
                    .HasColumnName("vQtyBase")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyBox)
                    .HasColumnName("vQtyBox")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyMax)
                    .HasColumnName("vQtyMax")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyMin)
                    .HasColumnName("vQtyMin")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyMulti)
                    .HasColumnName("vQtyMulti")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.Weight).HasColumnType("decimal(16, 6)");

                entity.Property(e => e.Width).HasColumnType("decimal(16, 6)");
            });

            modelBuilder.Entity<VwAnMaterialFormat>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_anMaterialFormat");

                entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");

                entity.Property(e => e.IdMaterialFormat).HasColumnName("idMaterialFormat");

                entity.Property(e => e.IdUnitSelling).HasColumnName("idUnitSelling");

                entity.Property(e => e.UnitSelling)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UnitSellingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VPriceCustomer)
                    .HasColumnName("vPriceCustomer")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.VPriceWhosaler)
                    .HasColumnName("vPriceWhosaler")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.VQtyBase)
                    .HasColumnName("vQtyBase")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.VQtyBox)
                    .HasColumnName("vQtyBox")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.VQtyMax)
                    .HasColumnName("vQtyMax")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.VQtyMin)
                    .HasColumnName("vQtyMin")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.VQtyMulti)
                    .HasColumnName("vQtyMulti")
                    .HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<VwAnMaterialWarehouse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_anMaterialWarehouse");

                entity.Property(e => e.Customer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCustomer).HasColumnName("idCustomer");

                entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.IdWarehouse).HasColumnName("idWarehouse");

                entity.Property(e => e.Supplier)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VQtyStock)
                    .HasColumnName("vQtyStock")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.Warehouse)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAnMetelPriceList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_anMetelPriceList");

                entity.Property(e => e.Batch)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DateLastChange).HasColumnType("smalldatetime");

                entity.Property(e => e.DateStart).HasColumnType("smalldatetime");

                entity.Property(e => e.DateStartWholesaler).HasColumnType("smalldatetime");

                entity.Property(e => e.IdMetelPriceList).HasColumnName("idMetelPriceList");

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.IdUserLastEdit).HasColumnName("idUserLastEdit");

                entity.Property(e => e.Number)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PriceList)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasMaxLength(11)
                    .IsUnicode(false);

                entity.Property(e => e.Version)
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAnPhase>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_anPhase");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCurrency).HasColumnName("idCurrency");

                entity.Property(e => e.IdPhase).HasColumnName("idPhase");

                entity.Property(e => e.IdPhaseCalculation).HasColumnName("idPhaseCalculation");

                entity.Property(e => e.IdPhaseType).HasColumnName("idPhaseType");

                entity.Property(e => e.IdResource).HasColumnName("idResource");

                entity.Property(e => e.IdResourceGroup).HasColumnName("idResourceGroup");

                entity.Property(e => e.IdResourceTooling).HasColumnName("idResourceTooling");

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.IdUserLastEdit).HasColumnName("idUserLastEdit");

                entity.Property(e => e.IdUserLock).HasColumnName("idUserLock");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.Note)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Phase)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PhaseCalculation)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PhaseCalculationCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PhaseType)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PhaseTypeCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Resource)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceGroupCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceTooling)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceToolingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserCreate).HasMaxLength(201);

                entity.Property(e => e.UserLastEdit).HasMaxLength(201);

                entity.Property(e => e.UserLock).HasMaxLength(201);

                entity.Property(e => e.VCycleMm)
                    .HasColumnName("vCycle_mm")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.VK)
                    .HasColumnName("vK")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.VSupplierCostDd)
                    .HasColumnName("vSupplierCost_DD")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.VSupplierDd)
                    .HasColumnName("vSupplier_DD")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.VToolingK)
                    .HasColumnName("vToolingK")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.VToolingStartMm)
                    .HasColumnName("vToolingStart_mm")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.VUntoolingMm)
                    .HasColumnName("vUntooling_mm")
                    .HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<VwAnResource>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_anResource");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdResource).HasColumnName("idResource");

                entity.Property(e => e.IdResourceStatus).HasColumnName("idResourceStatus");

                entity.Property(e => e.IdResourceType).HasColumnName("idResourceType");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.IdUserLastEdit).HasColumnName("idUserLastEdit");

                entity.Property(e => e.IdUserLock).HasColumnName("idUserLock");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.Resource)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceStatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(201);

                entity.Property(e => e.UserLastEdit)
                    .IsRequired()
                    .HasMaxLength(201);

                entity.Property(e => e.UserLock).HasMaxLength(201);

                entity.Property(e => e.VCostH)
                    .HasColumnName("vCostH")
                    .HasColumnType("decimal(12, 2)");
            });

            modelBuilder.Entity<VwAnResourceGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_anResourceGroup");

                entity.Property(e => e.IdResource).HasColumnName("idResource");

                entity.Property(e => e.IdResourceGroup).HasColumnName("idResourceGroup");

                entity.Property(e => e.IdRow).HasColumnName("idRow");

                entity.Property(e => e.IntOrder).HasColumnName("intOrder");

                entity.Property(e => e.IsEnabled).HasColumnName("isEnabled");

                entity.Property(e => e.ResourceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResourceGroup)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAnSupplier>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_anSupplier");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AddressFull)
                    .IsRequired()
                    .HasMaxLength(820);

                entity.Property(e => e.AddressFullFormatted).HasMaxLength(817);

                entity.Property(e => e.AddressFullHtml)
                    .IsRequired()
                    .HasColumnName("AddressFullHTML")
                    .HasMaxLength(827);

                entity.Property(e => e.AllowEdit).HasColumnName("allowEdit");

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanySector)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CompanySectorCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Email1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FiscalCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlStock).HasColumnName("flStock");

                entity.Property(e => e.IdCompanySector).HasColumnName("idCompanySector");

                entity.Property(e => e.IdCountry).HasColumnName("idCountry");

                entity.Property(e => e.IdLead).HasColumnName("idLead");

                entity.Property(e => e.IdPaymentType).HasColumnName("idPaymentType");

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.IdUserLastEdit).HasColumnName("idUserLastEdit");

                entity.Property(e => e.IdUserLock).HasColumnName("idUserLock");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsInternalSupplier).HasColumnName("isInternalSupplier");

                entity.Property(e => e.Latitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(9, 6)");

                entity.Property(e => e.MetelCompanyCode)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Mob1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mob2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTypeCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tel1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tel2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(201);

                entity.Property(e => e.UserLastEdit)
                    .IsRequired()
                    .HasMaxLength(201);

                entity.Property(e => e.UserLock).HasMaxLength(201);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasColumnName("ZIP")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAnSupplierBusinessPartner>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_anSupplierBusinessPartner");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AddressFull)
                    .IsRequired()
                    .HasMaxLength(435);

                entity.Property(e => e.AddressFullFormatted).HasMaxLength(432);

                entity.Property(e => e.AddressFullHtml)
                    .IsRequired()
                    .HasColumnName("AddressFullHTML")
                    .HasMaxLength(442);

                entity.Property(e => e.Alpha2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessPartnerType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessPartnerTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Email1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fax1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fax2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FiscalCode)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdBusinessPartnerType).HasColumnName("idBusinessPartnerType");

                entity.Property(e => e.IdCountry).HasColumnName("idCountry");

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.IdSupplierBusinessPartner).HasColumnName("idSupplierBusinessPartner");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Mob1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mob2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ref1)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ref2)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tel1)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel2)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Zip)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAnSupplierContact>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_anSupplierContact");

                entity.Property(e => e.BusinessName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DateLastEdit).HasColumnType("datetime");

                entity.Property(e => e.DateLoad).HasColumnType("datetime");

                entity.Property(e => e.Email1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Email2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(511)
                    .IsUnicode(false);

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.IdSupplierContact).HasColumnName("idSupplierContact");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.IdUserLastEdit).HasColumnName("idUserLastEdit");

                entity.Property(e => e.IdWorkDepartment).HasColumnName("idWorkDepartment");

                entity.Property(e => e.IdWorkFunction).HasColumnName("idWorkFunction");

                entity.Property(e => e.IsDecisionMaker).HasColumnName("isDecisionMaker");

                entity.Property(e => e.IsDefault).HasColumnName("isDefault");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.LastName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mob1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Mob2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tel1)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Tel2)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WorkDepartment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkFunction)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwAnWarehouse>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_anWarehouse");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Customer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCustomer).HasColumnName("idCustomer");

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.IdWarehouse).HasColumnName("idWarehouse");

                entity.Property(e => e.Supplier)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Warehouse)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwFactDocument>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_factDocument");

                entity.Property(e => e.Description)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.EntityCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileExt)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileNameNoExt)
                    .HasColumnName("FileName_NoExt")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FileUrl)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.FolderPath)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.IdDocument).HasColumnName("idDocument");

                entity.Property(e => e.IdEntity).HasColumnName("idEntity");

                entity.Property(e => e.IdEntityType).HasColumnName("idEntityType");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(201);
            });

            modelBuilder.Entity<VwFactStockMovementDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_factStockMovementDetail");

                entity.Property(e => e.Code)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Customer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateStockMovement).HasColumnType("smalldatetime");

                entity.Property(e => e.IdCustomer).HasColumnName("idCustomer");

                entity.Property(e => e.IdJob).HasColumnName("idJob");

                entity.Property(e => e.IdMaterial).HasColumnName("idMaterial");

                entity.Property(e => e.IdStockMovement).HasColumnName("idStockMovement");

                entity.Property(e => e.IdStockMovementStatus).HasColumnName("idStockMovementStatus");

                entity.Property(e => e.IdStockMovementType).HasColumnName("idStockMovementType");

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.IdUnitSelling).HasColumnName("idUnitSelling");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.IdWarehouseDest).HasColumnName("idWarehouseDest");

                entity.Property(e => e.IntDateLoad).HasColumnName("intDateLoad");

                entity.Property(e => e.IntDateStockMovement).HasColumnName("intDateStockMovement");

                entity.Property(e => e.Job)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.JobCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Material)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialCode)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Progressive)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOrder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockMovementStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StockMovementStatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockMovementType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StockMovementTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UnitSelling)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UnitSellingCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VAmountBaseTot)
                    .HasColumnName("vAmountBaseTot")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VAmountBaseUnit)
                    .HasColumnName("vAmountBaseUnit")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VAmountTot)
                    .HasColumnName("vAmountTot")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VAmountUnit)
                    .HasColumnName("vAmountUnit")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQty)
                    .HasColumnName("vQty")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.VQtyBase)
                    .HasColumnName("vQtyBase")
                    .HasColumnType("decimal(16, 6)");

                entity.Property(e => e.WarehouseDest)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseDestCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseSource)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseSourceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwFactStockMovementHeader>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_factStockMovementHeader");

                entity.Property(e => e.Code)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Customer)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DateStockMovement).HasColumnType("smalldatetime");

                entity.Property(e => e.IdCurrency).HasColumnName("idCurrency");

                entity.Property(e => e.IdCustomer).HasColumnName("idCustomer");

                entity.Property(e => e.IdJob).HasColumnName("idJob");

                entity.Property(e => e.IdStockMovement).HasColumnName("idStockMovement");

                entity.Property(e => e.IdStockMovementStatus).HasColumnName("idStockMovementStatus");

                entity.Property(e => e.IdStockMovementType).HasColumnName("idStockMovementType");

                entity.Property(e => e.IdSupplier).HasColumnName("idSupplier");

                entity.Property(e => e.IdUserCreate).HasColumnName("idUserCreate");

                entity.Property(e => e.IdUserLastEdit).HasColumnName("idUserLastEdit");

                entity.Property(e => e.IdUserLock).HasColumnName("idUserLock");

                entity.Property(e => e.IdWarehouseDest).HasColumnName("idWarehouseDest");

                entity.Property(e => e.IdWarehouseSource).HasColumnName("idWarehouseSource");

                entity.Property(e => e.IntDateLoad).HasColumnName("intDateLoad");

                entity.Property(e => e.IntDateStockMovement).HasColumnName("intDateStockMovement");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.Job)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.JobCode)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SalesOrder)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockMovementStatus)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StockMovementStatusCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StockMovementType)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.StockMovementTypeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Supplier)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SupplierCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserCreate)
                    .IsRequired()
                    .HasMaxLength(201);

                entity.Property(e => e.UserLastEdit)
                    .IsRequired()
                    .HasMaxLength(201);

                entity.Property(e => e.UserLock).HasMaxLength(201);

                entity.Property(e => e.VMovementAmount)
                    .HasColumnName("vMovementAmount")
                    .HasColumnType("decimal(12, 2)");

                entity.Property(e => e.WarehouseDest)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseDestCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseSource)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.WarehouseSourceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VwLock>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_Lock");

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Entity)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EntityCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdEntityType).HasColumnName("idEntityType");

                entity.Property(e => e.IdUserLock).HasColumnName("idUserLock");

                entity.Property(e => e.UserLock).HasMaxLength(201);
            });

            modelBuilder.Entity<VwUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_User");

                entity.Property(e => e.CodCulture)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodCurrency)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodLanguage)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.CodSalesArea)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Culture)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.IdCulture).HasColumnName("idCulture");

                entity.Property(e => e.IdCurrency).HasColumnName("idCurrency");

                entity.Property(e => e.IdLanguage).HasColumnName("idLanguage");

                entity.Property(e => e.IdSalesArea).HasColumnName("idSalesArea");

                entity.Property(e => e.IdTimeZone).HasColumnName("idTimeZone");

                entity.Property(e => e.IdTimeZoneDotNet)
                    .HasColumnName("idTimeZoneDotNet")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Language)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.SalesArea)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.TimeZoneDisplayName)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserFull)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<VwUserRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_UserRole");

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .IsRequired()
                    .HasColumnName("id")
                    .HasMaxLength(128);

                entity.Property(e => e.IdRole)
                    .IsRequired()
                    .HasColumnName("idRole")
                    .HasMaxLength(128);

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.UserFull)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
