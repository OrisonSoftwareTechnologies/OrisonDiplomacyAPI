using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class OrisonSystemALZAMREEQContext : DbContext
    {
        public OrisonSystemALZAMREEQContext()
        {
        }

        public OrisonSystemALZAMREEQContext(DbContextOptions<OrisonSystemALZAMREEQContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AccountCategoryList> AccountCategoryLists { get; set; }
        public virtual DbSet<AccountCategoryListVw> AccountCategoryListVws { get; set; }
        public virtual DbSet<AccountCategoryMast> AccountCategoryMasts { get; set; }
        public virtual DbSet<AccountCategoryTran> AccountCategoryTrans { get; set; }
        public virtual DbSet<AccountGroupMast> AccountGroupMasts { get; set; }
        public virtual DbSet<Accounts1> Accounts1s { get; set; }
        public virtual DbSet<AccountsList> AccountsLists { get; set; }
        public virtual DbSet<AccountsListMast> AccountsListMasts { get; set; }
        public virtual DbSet<AccountsListUser> AccountsListUsers { get; set; }
        public virtual DbSet<AccountsVw> AccountsVws { get; set; }
        public virtual DbSet<AdditionalCharge> AdditionalCharges { get; set; }
        public virtual DbSet<AgingDetail> AgingDetails { get; set; }
        public virtual DbSet<AgingMonthwise> AgingMonthwises { get; set; }
        public virtual DbSet<AirportMast> AirportMasts { get; set; }
        public virtual DbSet<AreaMast> AreaMasts { get; set; }
        public virtual DbSet<AttachedFile> AttachedFiles { get; set; }
        public virtual DbSet<AvgCost> AvgCosts { get; set; }
        public virtual DbSet<BillAllocationSumVw> BillAllocationSumVws { get; set; }
        public virtual DbSet<BillwiseDetailsVw> BillwiseDetailsVws { get; set; }
        public virtual DbSet<CallDetail> CallDetails { get; set; }
        public virtual DbSet<CardMast> CardMasts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Cheque> Cheques { get; set; }
        public virtual DbSet<ChequeBank> ChequeBanks { get; set; }
        public virtual DbSet<ChequeSetting> ChequeSettings { get; set; }
        public virtual DbSet<ChequesTran> ChequesTrans { get; set; }
        public virtual DbSet<ColumnsTran> ColumnsTrans { get; set; }
        public virtual DbSet<ColumnsTranList> ColumnsTranLists { get; set; }
        public virtual DbSet<ColumnsVetran> ColumnsVetrans { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanySetting> CompanySettings { get; set; }
        public virtual DbSet<CompanyTypeMast> CompanyTypeMasts { get; set; }
        public virtual DbSet<CostCentre> CostCentres { get; set; }
        public virtual DbSet<CostCentreDetail> CostCentreDetails { get; set; }
        public virtual DbSet<CostCentreVw> CostCentreVws { get; set; }
        public virtual DbSet<CostPhaseMast> CostPhaseMasts { get; set; }
        public virtual DbSet<CostUnitMast> CostUnitMasts { get; set; }
        public virtual DbSet<CostcentreRecurringVw> CostcentreRecurringVws { get; set; }
        public virtual DbSet<Creditor> Creditors { get; set; }
        public virtual DbSet<CurrencyMast> CurrencyMasts { get; set; }
        public virtual DbSet<CustomReportColumn> CustomReportColumns { get; set; }
        public virtual DbSet<CustomReportManager> CustomReportManagers { get; set; }
        public virtual DbSet<CustomerStatus> CustomerStatuses { get; set; }
        public virtual DbSet<DatewiseLedgerVw> DatewiseLedgerVws { get; set; }
        public virtual DbSet<Debtor> Debtors { get; set; }
        public virtual DbSet<DocumentDetail> DocumentDetails { get; set; }
        public virtual DbSet<DocumentRef> DocumentRefs { get; set; }
        public virtual DbSet<DocumentTypeMast> DocumentTypeMasts { get; set; }
        public virtual DbSet<DynamicAccount> DynamicAccounts { get; set; }
        public virtual DbSet<EmiratesMast> EmiratesMasts { get; set; }
        public virtual DbSet<EmployeeRegistration> EmployeeRegistrations { get; set; }
        public virtual DbSet<EntryModeMast> EntryModeMasts { get; set; }
        public virtual DbSet<FlightCharting> FlightChartings { get; set; }
        public virtual DbSet<FlightChartingDetail> FlightChartingDetails { get; set; }
        public virtual DbSet<FlightChartingDetailsVw> FlightChartingDetailsVws { get; set; }
        public virtual DbSet<FlightChartingVw> FlightChartingVws { get; set; }
        public virtual DbSet<FlightInvoiceItem> FlightInvoiceItems { get; set; }
        public virtual DbSet<FlightInvoiceTran> FlightInvoiceTrans { get; set; }
        public virtual DbSet<FlightStaffVw> FlightStaffVws { get; set; }
        public virtual DbSet<FlightVw> FlightVws { get; set; }
        public virtual DbSet<FormGridSetting> FormGridSettings { get; set; }
        public virtual DbSet<FormLabelSetting> FormLabelSettings { get; set; }
        public virtual DbSet<FormatMast> FormatMasts { get; set; }
        public virtual DbSet<GroupDetail> GroupDetails { get; set; }
        public virtual DbSet<GroupMajor> GroupMajors { get; set; }
        public virtual DbSet<GroupMaster> GroupMasters { get; set; }
        public virtual DbSet<GroupMasterVw> GroupMasterVws { get; set; }
        public virtual DbSet<GroupMiddle> GroupMiddles { get; set; }
        public virtual DbSet<GroupMinor> GroupMinors { get; set; }
        public virtual DbSet<GroupParent> GroupParents { get; set; }
        public virtual DbSet<GroupsVw> GroupsVws { get; set; }
        public virtual DbSet<Help> Helps { get; set; }
        public virtual DbSet<HrallowanceMast> HrallowanceMasts { get; set; }
        public virtual DbSet<HrbranchSetting> HrbranchSettings { get; set; }
        public virtual DbSet<HrcompDocImage> HrcompDocImages { get; set; }
        public virtual DbSet<HrcompDocument> HrcompDocuments { get; set; }
        public virtual DbSet<HrdayTypeMaster> HrdayTypeMasters { get; set; }
        public virtual DbSet<HrdepartmentMast> HrdepartmentMasts { get; set; }
        public virtual DbSet<HrdocTranDetail> HrdocTranDetails { get; set; }
        public virtual DbSet<HrdocTransfer> HrdocTransfers { get; set; }
        public virtual DbSet<HrempAdvance> HrempAdvances { get; set; }
        public virtual DbSet<HrempAdvanceDetail> HrempAdvanceDetails { get; set; }
        public virtual DbSet<HrempChequeDetail> HrempChequeDetails { get; set; }
        public virtual DbSet<HrempDeductionMaster> HrempDeductionMasters { get; set; }
        public virtual DbSet<HrempDocImage> HrempDocImages { get; set; }
        public virtual DbSet<HrempDocument> HrempDocuments { get; set; }
        public virtual DbSet<HrempExpImage> HrempExpImages { get; set; }
        public virtual DbSet<HrempExperience> HrempExperiences { get; set; }
        public virtual DbSet<HrempExperienceImage> HrempExperienceImages { get; set; }
        public virtual DbSet<HrempFamImage> HrempFamImages { get; set; }
        public virtual DbSet<HrempFamily> HrempFamilies { get; set; }
        public virtual DbSet<HrempFamilyImage> HrempFamilyImages { get; set; }
        public virtual DbSet<HrempIncomeMaster> HrempIncomeMasters { get; set; }
        public virtual DbSet<HrempLeaveDetail> HrempLeaveDetails { get; set; }
        public virtual DbSet<HrempNote> HrempNotes { get; set; }
        public virtual DbSet<HrempPhoto> HrempPhotos { get; set; }
        public virtual DbSet<HrempProject> HrempProjects { get; set; }
        public virtual DbSet<HrempProjectTran> HrempProjectTrans { get; set; }
        public virtual DbSet<HrempQualImage> HrempQualImages { get; set; }
        public virtual DbSet<HrempQualification> HrempQualifications { get; set; }
        public virtual DbSet<HrempQualificationImage> HrempQualificationImages { get; set; }
        public virtual DbSet<HrempSalary> HrempSalaries { get; set; }
        public virtual DbSet<HrempWage> HrempWages { get; set; }
        public virtual DbSet<HrempWagesDeduction> HrempWagesDeductions { get; set; }
        public virtual DbSet<HrempWagesIncome> HrempWagesIncomes { get; set; }
        public virtual DbSet<Hremployee> Hremployees { get; set; }
        public virtual DbSet<HremployeeBackup> HremployeeBackups { get; set; }
        public virtual DbSet<Hrgratuity> Hrgratuities { get; set; }
        public virtual DbSet<HrgratuityParent> HrgratuityParents { get; set; }
        public virtual DbSet<HrgratuityTran> HrgratuityTrans { get; set; }
        public virtual DbSet<HrinvContract> HrinvContracts { get; set; }
        public virtual DbSet<HrinvDeduction> HrinvDeductions { get; set; }
        public virtual DbSet<HrinvWorkingProgress> HrinvWorkingProgresses { get; set; }
        public virtual DbSet<HrleaveSalary> HrleaveSalaries { get; set; }
        public virtual DbSet<HrleaveSalaryTran> HrleaveSalaryTrans { get; set; }
        public virtual DbSet<Hrmaster> Hrmasters { get; set; }
        public virtual DbSet<HrprojectInvoice> HrprojectInvoices { get; set; }
        public virtual DbSet<HrprojectInvoiceTran> HrprojectInvoiceTrans { get; set; }
        public virtual DbSet<HrprojectTransfer> HrprojectTransfers { get; set; }
        public virtual DbSet<HrrateMasterEmployee> HrrateMasterEmployees { get; set; }
        public virtual DbSet<HrrateMasterProject> HrrateMasterProjects { get; set; }
        public virtual DbSet<Hrreminder> Hrreminders { get; set; }
        public virtual DbSet<HrstmtMatter> HrstmtMatters { get; set; }
        public virtual DbSet<HrtimeSheet> HrtimeSheets { get; set; }
        public virtual DbSet<HrtimeSheetConsolidated> HrtimeSheetConsolidateds { get; set; }
        public virtual DbSet<HrtimeSheetDefaultSetting> HrtimeSheetDefaultSettings { get; set; }
        public virtual DbSet<HrtimeSheetDetail> HrtimeSheetDetails { get; set; }
        public virtual DbSet<HrtransportationMast> HrtransportationMasts { get; set; }
        public virtual DbSet<HrtransportationTran> HrtransportationTrans { get; set; }
        public virtual DbSet<HrwagesAllView> HrwagesAllViews { get; set; }
        public virtual DbSet<Image> Images { get; set; }
        public virtual DbSet<IncrimentMast> IncrimentMasts { get; set; }
        public virtual DbSet<InvFifoallocation> InvFifoallocations { get; set; }
        public virtual DbSet<InvItemSearch> InvItemSearches { get; set; }
        public virtual DbSet<InvJobOrder> InvJobOrders { get; set; }
        public virtual DbSet<InvJoborderItem> InvJoborderItems { get; set; }
        public virtual DbSet<InvoiceNote> InvoiceNotes { get; set; }
        public virtual DbSet<Inward> Inwards { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<ItemMaster> ItemMasters { get; set; }
        public virtual DbSet<ItemMasterDetail> ItemMasterDetails { get; set; }
        public virtual DbSet<ItemMasterImported> ItemMasterImporteds { get; set; }
        public virtual DbSet<JobAllocation> JobAllocations { get; set; }
        public virtual DbSet<JobDetail> JobDetails { get; set; }
        public virtual DbSet<JobImage> JobImages { get; set; }
        public virtual DbSet<JobMain> JobMains { get; set; }
        public virtual DbSet<JobManager> JobManagers { get; set; }
        public virtual DbSet<JobOrder> JobOrders { get; set; }
        public virtual DbSet<JobOutSide> JobOutSides { get; set; }
        public virtual DbSet<JobUser> JobUsers { get; set; }
        public virtual DbSet<LedgerTrialVw> LedgerTrialVws { get; set; }
        public virtual DbSet<LedgerVw> LedgerVws { get; set; }
        public virtual DbSet<LedgerVwbillwise> LedgerVwbillwises { get; set; }
        public virtual DbSet<LedgerVwsimple> LedgerVwsimples { get; set; }
        public virtual DbSet<Link> Links { get; set; }
        public virtual DbSet<Madeena> Madeenas { get; set; }
        public virtual DbSet<MastDesignation> MastDesignations { get; set; }
        public virtual DbSet<MasterMisc> MasterMiscs { get; set; }
        public virtual DbSet<MgntJobMaster> MgntJobMasters { get; set; }
        public virtual DbSet<MgntJobtran> MgntJobtrans { get; set; }
        public virtual DbSet<MgntSponsorMast> MgntSponsorMasts { get; set; }
        public virtual DbSet<NumberingTran> NumberingTrans { get; set; }
        public virtual DbSet<OldAccount> OldAccounts { get; set; }
        public virtual DbSet<OpeningGroupVw> OpeningGroupVws { get; set; }
        public virtual DbSet<OrderCustomer> OrderCustomers { get; set; }
        public virtual DbSet<Outward> Outwards { get; set; }
        public virtual DbSet<Pajoproof> Pajoproofs { get; set; }
        public virtual DbSet<ParentChildtb> ParentChildtbs { get; set; }
        public virtual DbSet<ParentTb> ParentTbs { get; set; }
        public virtual DbSet<PaymentModeMast> PaymentModeMasts { get; set; }
        public virtual DbSet<Personnel> Personnel { get; set; }
        public virtual DbSet<PersonnelDetailsTran> PersonnelDetailsTrans { get; set; }
        public virtual DbSet<PortalUser> PortalUsers { get; set; }
        public virtual DbSet<ProdExpense> ProdExpenses { get; set; }
        public virtual DbSet<ProdFinishedItem> ProdFinishedItems { get; set; }
        public virtual DbSet<ProdMaster> ProdMasters { get; set; }
        public virtual DbSet<ProdMaterial> ProdMaterials { get; set; }
        public virtual DbSet<Reminder> Reminders { get; set; }
        public virtual DbSet<RenewalMast> RenewalMasts { get; set; }
        public virtual DbSet<Setting> Settings { get; set; }
        public virtual DbSet<SheetTemp> SheetTemps { get; set; }
        public virtual DbSet<ShipViaMast> ShipViaMasts { get; set; }
        public virtual DbSet<SponsorMaster> SponsorMasters { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<SubGroupList> SubGroupLists { get; set; }
        public virtual DbSet<SubGroupListVw> SubGroupListVws { get; set; }
        public virtual DbSet<SubGroupMast> SubGroupMasts { get; set; }
        public virtual DbSet<SubGroupTran> SubGroupTrans { get; set; }
        public virtual DbSet<SubGroupTranList> SubGroupTranLists { get; set; }
        public virtual DbSet<Tempve> Tempves { get; set; }
        public virtual DbSet<Tempvno> Tempvnos { get; set; }
        public virtual DbSet<TermsTran> TermsTrans { get; set; }
        public virtual DbSet<Test> Tests { get; set; }
        public virtual DbSet<Testtb> Testtbs { get; set; }
        public virtual DbSet<TranCostCentre> TranCostCentres { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }
        public virtual DbSet<TrialBalanceVw> TrialBalanceVws { get; set; }
        public virtual DbSet<UniqueAccount> UniqueAccounts { get; set; }
        public virtual DbSet<UniqueAccountsViewVw> UniqueAccountsViewVws { get; set; }
        public virtual DbSet<UnitMaster> UnitMasters { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
        public virtual DbSet<UserRight> UserRights { get; set; }
        public virtual DbSet<UserRightsMaster> UserRightsMasters { get; set; }
        public virtual DbSet<UserRightsTemplate> UserRightsTemplates { get; set; }
        public virtual DbSet<UserTrack> UserTracks { get; set; }
        public virtual DbSet<UsersBranch> UsersBranches { get; set; }
        public virtual DbSet<UsersSection> UsersSections { get; set; }
        public virtual DbSet<UsersSectionMaster> UsersSectionMasters { get; set; }
        public virtual DbSet<VeaccountsVw> VeaccountsVws { get; set; }
        public virtual DbSet<VentryAccount> VentryAccounts { get; set; }
        public virtual DbSet<VentryCostCentre> VentryCostCentres { get; set; }
        public virtual DbSet<VetypeTran> VetypeTrans { get; set; }
        public virtual DbSet<Voucher> Vouchers { get; set; }
        public virtual DbSet<VoucherAdditional> VoucherAdditionals { get; set; }
        public virtual DbSet<VoucherAdditionalTran> VoucherAdditionalTrans { get; set; }
        public virtual DbSet<VoucherAllocation> VoucherAllocations { get; set; }
        public virtual DbSet<VoucherEntry> VoucherEntries { get; set; }
        public virtual DbSet<VoucherEntryVw> VoucherEntryVws { get; set; }
        public virtual DbSet<VoucherStatus> VoucherStatuses { get; set; }
        public virtual DbSet<VpajoProof> VpajoProofs { get; set; }
        public virtual DbSet<VtypeMast> VtypeMasts { get; set; }
        public virtual DbSet<VtypeTran> VtypeTrans { get; set; }
        public virtual DbSet<WareHouseMaster> WareHouseMasters { get; set; }
        public virtual DbSet<WarehouseBranch> WarehouseBranches { get; set; }
        public virtual DbSet<WsBodyCheck> WsBodyChecks { get; set; }
        public virtual DbSet<WsImage> WsImages { get; set; }
        public virtual DbSet<WsJobDetailsApp> WsJobDetailsApps { get; set; }
        public virtual DbSet<WsJobMaster> WsJobMasters { get; set; }
        public virtual DbSet<WsRandomUrl> WsRandomUrls { get; set; }
        public virtual DbSet<WsVehicleCheck> WsVehicleChecks { get; set; }
        public virtual DbSet<WsVehicleMaster> WsVehicleMasters { get; set; }
        public virtual DbSet<WsvehicleCheck1> WsvehicleChecks1 { get; set; }
        public virtual DbSet<WsvehicleCheckMaster> WsvehicleCheckMasters { get; set; }
        public virtual DbSet<staff> staff { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-E4OU17C5\\SA;Initial Catalog=OrisonSystemALZAMREEQ;User ID=sa;Password=hcs1237;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasIndex(e => e.AccountCode, "IX_Accounts")
                    .IsUnique();

                entity.HasIndex(e => e.AccountName, "IX_Accounts_1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AllowEntry).HasDefaultValueSql("((1))");

                entity.Property(e => e.AorderNo).HasColumnName("AOrderNo");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Editable).HasDefaultValueSql("((1))");

                entity.Property(e => e.InVisible).HasDefaultValueSql("((0))");

                entity.Property(e => e.Isdefault).HasColumnName("ISDefault");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SortField).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.UserTrackId).HasColumnName("UserTrackID");

                entity.HasOne(d => d.AccCategoryNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.AccCategory)
                    .HasConstraintName("FK_Accounts_AccountCategoryMast1");

                entity.HasOne(d => d.AccountGroupNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.AccountGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Accounts_AccountGroupMast1");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_Accounts_Company");

                entity.HasOne(d => d.SubGroupNavigation)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.SubGroup)
                    .HasConstraintName("FK_Accounts_SubGroupMast1");
            });

            modelBuilder.Entity<AccountCategoryList>(entity =>
            {
                entity.HasKey(e => new { e.ListId, e.Id })
                    .HasName("PK_AccCategoryList");

                entity.ToTable("AccountCategoryList");

                entity.Property(e => e.ListId).HasColumnName("ListID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.AccountCategoryLists)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccCategoryList_AccountCategoryMast");

                entity.HasOne(d => d.List)
                    .WithMany(p => p.AccountCategoryLists)
                    .HasForeignKey(d => d.ListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccCategoryList_SubGroupMast");
            });

            modelBuilder.Entity<AccountCategoryListVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AccountCategoryListVW");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ListId).HasColumnName("ListID");
            });

            modelBuilder.Entity<AccountCategoryMast>(entity =>
            {
                entity.ToTable("AccountCategoryMast");

                entity.HasIndex(e => e.Description, "IX_AccountCategoryMast")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<AccountCategoryTran>(entity =>
            {
                entity.ToTable("AccountCategoryTran");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Vid).HasColumnName("VID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.AccountCategoryTrans)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MastAccCategoryListDetails_MasterAccountCategory");
            });

            modelBuilder.Entity<AccountGroupMast>(entity =>
            {
                entity.ToTable("AccountGroupMast");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Accounts1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Accounts1");

                entity.Property(e => e.AccType).HasMaxLength(50);

                entity.Property(e => e.AccountCode)
                    .HasMaxLength(15)
                    .HasColumnName("Account Code");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(75)
                    .HasColumnName("Account Name");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Agroup).HasMaxLength(50);

                entity.Property(e => e.Area).HasMaxLength(30);

                entity.Property(e => e.Branch).HasMaxLength(25);

                entity.Property(e => e.Building).HasMaxLength(50);

                entity.Property(e => e.Category).HasMaxLength(25);

                entity.Property(e => e.Company).HasMaxLength(50);

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.CreditDays)
                    .HasMaxLength(5)
                    .HasColumnName("Credit Days");

                entity.Property(e => e.CreditLimit)
                    .HasMaxLength(25)
                    .HasColumnName("Credit Limit");

                entity.Property(e => e.Currency).HasMaxLength(20);

                entity.Property(e => e.CustomerType)
                    .HasMaxLength(50)
                    .HasColumnName("Customer Type");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.EntryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Entry Date");

                entity.Property(e => e.Fax).HasMaxLength(25);

                entity.Property(e => e.FlatNo).HasColumnName("Flat No");

                entity.Property(e => e.FromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("From Date");

                entity.Property(e => e.Levell).HasMaxLength(1);

                entity.Property(e => e.Mobile).HasMaxLength(25);

                entity.Property(e => e.Nationality).HasMaxLength(50);

                entity.Property(e => e.Parent).HasMaxLength(15);

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(30)
                    .HasColumnName("Passport No");

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.SalesMan)
                    .HasMaxLength(30)
                    .HasColumnName("Sales Man");

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.Property(e => e.ToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("To Date");

                entity.Property(e => e.User).HasMaxLength(20);

                entity.Property(e => e.VoucherEntry)
                    .HasMaxLength(3)
                    .HasColumnName("Voucher Entry");
            });

            modelBuilder.Entity<AccountsList>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_AccountsList_1")
                    .IsClustered(false);

                entity.ToTable("AccountsList");

                entity.HasIndex(e => new { e.ListId, e.AccountId }, "IX_AccountsList")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.ListId).HasColumnName("ListID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountsLists)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_AccountsList_Accounts");

                entity.HasOne(d => d.List)
                    .WithMany(p => p.AccountsLists)
                    .HasForeignKey(d => d.ListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountsList_AccountsListMast");
            });

            modelBuilder.Entity<AccountsListMast>(entity =>
            {
                entity.ToTable("AccountsListMast");

                entity.HasIndex(e => e.Description, "IX_AccountsListMast")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<AccountsListUser>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.List, e.AccountId });

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.List).HasMaxLength(50);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountsListUsers)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountsListUsers_Accounts");
            });

            modelBuilder.Entity<AccountsVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("AccountsVW");

                entity.Property(e => e.AccCategory).HasMaxLength(30);

                entity.Property(e => e.AccCategoryId).HasColumnName("AccCategoryID");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.AccountGroup)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.AccountGroupId).HasColumnName("AccountGroupID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AorderNo).HasColumnName("AOrderNo");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.Cccode)
                    .HasMaxLength(20)
                    .HasColumnName("CCCode");

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.Ccname)
                    .HasMaxLength(100)
                    .HasColumnName("CCName");

                entity.Property(e => e.GroupType).HasMaxLength(20);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Isdefault).HasColumnName("ISDefault");

                entity.Property(e => e.Parent).HasMaxLength(100);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.SortField).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.SubGroup).HasMaxLength(30);

                entity.Property(e => e.SubGroupId).HasColumnName("SubGroupID");
            });

            modelBuilder.Entity<AdditionalCharge>(entity =>
            {
                entity.ToTable("AdditionalCharge", "Inv");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CrAccountId).HasColumnName("CrAccountID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DrAccountId).HasColumnName("DrAccountID");

                entity.Property(e => e.DrorCr)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('Debit')");

                entity.Property(e => e.InvDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InvNo).HasMaxLength(25);

                entity.Property(e => e.Tcode)
                    .HasMaxLength(10)
                    .HasColumnName("TCode");

                entity.Property(e => e.Trnno)
                    .HasMaxLength(25)
                    .HasColumnName("TRNNo");

                entity.Property(e => e.Vat)
                    .HasColumnType("money")
                    .HasColumnName("VAT");

                entity.Property(e => e.Veidcr).HasColumnName("VEIDCr");

                entity.Property(e => e.Veiddr).HasColumnName("VEIDDr");

                entity.Property(e => e.Veidvatcr).HasColumnName("VEIDVATCr");

                entity.Property(e => e.Veidvatdr).HasColumnName("VEIDVATDr");

                entity.Property(e => e.Vid).HasColumnName("VID");

                entity.HasOne(d => d.CrAccount)
                    .WithMany(p => p.AdditionalChargeCrAccounts)
                    .HasForeignKey(d => d.CrAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvAdditionalCharge_Accounts");

                entity.HasOne(d => d.DrAccount)
                    .WithMany(p => p.AdditionalChargeDrAccounts)
                    .HasForeignKey(d => d.DrAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvAdditionalCharge_Accounts1");

                entity.HasOne(d => d.VidNavigation)
                    .WithMany(p => p.AdditionalCharges)
                    .HasForeignKey(d => d.Vid)
                    .HasConstraintName("FK_InvAdditionalCharge_Voucher");
            });

            modelBuilder.Entity<AgingDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<AgingMonthwise>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("AgingMonthwise");

                entity.Property(e => e.Title).HasMaxLength(50);
            });

            modelBuilder.Entity<AirportMast>(entity =>
            {
                entity.ToTable("AirportMast");

                entity.HasIndex(e => e.AirportCode, "IX_AirportMast")
                    .IsUnique();

                entity.HasIndex(e => e.Name, "IX_AirportMast_1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AirportCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength(true);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(100);
            });

            modelBuilder.Entity<AreaMast>(entity =>
            {
                entity.ToTable("AreaMast");

                entity.HasIndex(e => e.Description, "IX_AreaMast")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<AttachedFile>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.FileName).IsRequired();

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.AttachedFiles)
                    .HasForeignKey(d => d.DocId)
                    .HasConstraintName("FK_AttachedFiles_DocumentDetails");
            });

            modelBuilder.Entity<AvgCost>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_InvAvgCost")
                    .IsClustered(false);

                entity.ToTable("AvgCost", "Inv");

                entity.HasIndex(e => new { e.PurchaseDate, e.ItemId, e.BranchId }, "IX_InvAvgCost")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AvgCost1)
                    .HasColumnType("money")
                    .HasColumnName("AvgCost");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.LastRate).HasColumnType("money");

                entity.Property(e => e.PurchaseDate).HasColumnType("smalldatetime");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.AvgCosts)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_AvgCost_Company");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.AvgCosts)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_InvAvgCost_InvItemMaster");
            });

            modelBuilder.Entity<BillAllocationSumVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BillAllocationSumVW");

                entity.Property(e => e.SumAmount).HasColumnType("money");

                entity.Property(e => e.Veid).HasColumnName("VEID");
            });

            modelBuilder.Entity<BillwiseDetailsVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("BillwiseDetailsVW");

                entity.Property(e => e.Abr)
                    .HasMaxLength(3)
                    .HasColumnName("ABR");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.Credit).HasColumnType("money");

                entity.Property(e => e.Debit).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.DueDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ExchangeRate).HasColumnType("money");

                entity.Property(e => e.Paid).HasColumnType("money");

                entity.Property(e => e.PartyName).HasMaxLength(100);

                entity.Property(e => e.RefNo).HasMaxLength(20);

                entity.Property(e => e.TranType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("VDate");

                entity.Property(e => e.Veid).HasColumnName("VEID");

                entity.Property(e => e.Vid).HasColumnName("VID");

                entity.Property(e => e.Vno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("VNo");

                entity.Property(e => e.Vtype).HasColumnName("VType");
            });

            modelBuilder.Entity<CallDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CallingDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ClientCode).HasMaxLength(30);

                entity.Property(e => e.ClientName).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Status).HasMaxLength(30);

                entity.Property(e => e.TransferredTo).HasMaxLength(30);
            });

            modelBuilder.Entity<CardMast>(entity =>
            {
                entity.ToTable("CardMast");

                entity.HasIndex(e => e.Description, "IX_CardMast")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Commission).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(30);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category", "Inv");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category1)
                    .HasMaxLength(30)
                    .HasColumnName("Category");
            });

            modelBuilder.Entity<Cheque>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.ChequeDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ChequeNo).HasMaxLength(10);

                entity.Property(e => e.Commission).HasColumnType("money");

                entity.Property(e => e.PartyId).HasColumnName("PartyID");

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.Veid).HasColumnName("VEID");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.ChequeBanks)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_Cheques_Accounts");

                entity.HasOne(d => d.CardTypeNavigation)
                    .WithMany(p => p.Cheques)
                    .HasForeignKey(d => d.CardType)
                    .HasConstraintName("FK_Cheques_CardMast");

                entity.HasOne(d => d.Party)
                    .WithMany(p => p.ChequeParties)
                    .HasForeignKey(d => d.PartyId)
                    .HasConstraintName("FK_Cheques_Accounts1");

                entity.HasOne(d => d.Ve)
                    .WithMany(p => p.Cheques)
                    .HasForeignKey(d => d.Veid)
                    .HasConstraintName("FK_Cheques_VoucherEntry");
            });

            modelBuilder.Entity<ChequeBank>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.ChequeCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.IsDefault).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Bank)
                    .WithMany()
                    .HasForeignKey(d => d.BankId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ChequeBanks_Accounts");
            });

            modelBuilder.Entity<ChequeSetting>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Casing).HasDefaultValueSql("((0))");

                entity.Property(e => e.ChequeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateFormat)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DateSeparator)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FieldSettings).IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.LandScape).HasDefaultValueSql("((1))");

                entity.Property(e => e.NumField1).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.NumField2).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.NumField3).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.VarField1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VarFiled2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VarFiled3)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ChequesTran>(entity =>
            {
                entity.ToTable("ChequesTran");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChequeId).HasColumnName("ChequeID");

                entity.Property(e => e.TranType).HasMaxLength(20);

                entity.Property(e => e.Veid).HasColumnName("VEID");

                entity.Property(e => e.Vid).HasColumnName("VID");

                entity.HasOne(d => d.Ve)
                    .WithMany(p => p.ChequesTrans)
                    .HasForeignKey(d => d.Veid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ChequesTran_VoucherEntry");

                entity.HasOne(d => d.VidNavigation)
                    .WithMany(p => p.ChequesTrans)
                    .HasForeignKey(d => d.Vid)
                    .HasConstraintName("FK_ChequesPosted_Voucher");
            });

            modelBuilder.Entity<ColumnsTran>(entity =>
            {
                entity.ToTable("ColumnsTran");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Vtid).HasColumnName("VTID");
            });

            modelBuilder.Entity<ColumnsTranList>(entity =>
            {
                entity.ToTable("ColumnsTranList");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.CidNavigation)
                    .WithMany(p => p.ColumnsTranLists)
                    .HasForeignKey(d => d.Cid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ColumnsTranList_ColumnsTran");
            });

            modelBuilder.Entity<ColumnsVetran>(entity =>
            {
                entity.ToTable("ColumnsVETran");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Vetid).HasColumnName("VETID");

                entity.HasOne(d => d.Vet)
                    .WithMany(p => p.ColumnsVetrans)
                    .HasForeignKey(d => d.Vetid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ColumnVETran_VETypeTran");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.HasIndex(e => e.CompanyCode, "IX_Company")
                    .IsUnique();

                entity.HasIndex(e => e.BranchName, "IX_Company_1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.Address2).HasMaxLength(100);

                entity.Property(e => e.Address3).HasMaxLength(100);

                entity.Property(e => e.AllowDelete).HasDefaultValueSql("((1))");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Currency).HasMaxLength(3);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EntryFrom).HasColumnType("datetime");

                entity.Property(e => e.Ernno)
                    .HasMaxLength(50)
                    .HasColumnName("ERNNo");

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.LetterHead).HasColumnType("ntext");

                entity.Property(e => e.Tel1).HasMaxLength(20);

                entity.Property(e => e.Tel2).HasMaxLength(20);

                entity.Property(e => e.Trnno)
                    .HasMaxLength(50)
                    .HasColumnName("TRNNo");

                entity.Property(e => e.Vatplace)
                    .HasMaxLength(150)
                    .HasColumnName("VATPlace");

                entity.Property(e => e.Website).HasMaxLength(100);

                entity.HasOne(d => d.CompanyTypeNavigation)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.CompanyType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_CompanyTypeMast");
            });

            modelBuilder.Entity<CompanySetting>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Keyword).HasMaxLength(30);

                entity.Property(e => e.Remarks).HasMaxLength(30);

                entity.Property(e => e.SubKeyWord).HasMaxLength(30);

                entity.Property(e => e.Value).HasMaxLength(30);
            });

            modelBuilder.Entity<CompanyTypeMast>(entity =>
            {
                entity.ToTable("CompanyTypeMast");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<CostCentre>(entity =>
            {
                entity.ToTable("CostCentre");

                entity.HasIndex(e => e.Description, "IX_CostCentre")
                    .IsUnique();

                entity.HasIndex(e => e.Code, "IX_Jobs")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.InActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Ptype)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("PType")
                    .HasDefaultValueSql("('Real')");
            });

            modelBuilder.Entity<CostCentreDetail>(entity =>
            {
                entity.HasKey(e => e.Ccid);

                entity.Property(e => e.Ccid)
                    .ValueGeneratedNever()
                    .HasColumnName("CCID");

                entity.Property(e => e.ClientId).HasColumnName("ClientID");

                entity.Property(e => e.ContractValue).HasColumnType("money");

                entity.Property(e => e.Edate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("EDate");

                entity.Property(e => e.InvoicedAmt).HasColumnType("money");

                entity.Property(e => e.Make).HasMaxLength(75);

                entity.Property(e => e.Myear)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MYear");

                entity.Property(e => e.NumField1).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.NumField2).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.NumField3).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.NvarField1)
                    .HasMaxLength(50)
                    .HasColumnName("NVarField1");

                entity.Property(e => e.NvarField2)
                    .HasMaxLength(50)
                    .HasColumnName("NVarField2");

                entity.Property(e => e.NvarField3)
                    .HasMaxLength(50)
                    .HasColumnName("NVarField3");

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.RegNo).HasMaxLength(20);

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.Sdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("SDate");

                entity.Property(e => e.SerialNo).HasMaxLength(20);

                entity.Property(e => e.StaffId1).HasColumnName("StaffID1");

                entity.Property(e => e.StaffId2).HasColumnName("StaffID2");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.SupplierId).HasColumnName("SupplierID");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.HasOne(d => d.Cc)
                    .WithOne(p => p.CostCentreDetail)
                    .HasForeignKey<CostCentreDetail>(d => d.Ccid)
                    .HasConstraintName("FK_CostCentreDetails_CostCentre");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.CostCentreDetailClients)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_CostCentreDetails_Accounts");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.CostCentreDetailSuppliers)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_CostCentreDetails_Accounts1");
            });

            modelBuilder.Entity<CostCentreVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CostCentreVW");

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.CostCentre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Cost_Centre");

                entity.Property(e => e.CostPhaseId).HasColumnName("CostPhaseID");

                entity.Property(e => e.CostUnit)
                    .HasMaxLength(50)
                    .HasColumnName("Cost_Unit");

                entity.Property(e => e.CostUnitId).HasColumnName("CostUnitID");

                entity.Property(e => e.Credit).HasColumnType("money");

                entity.Property(e => e.Debit).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Phase).HasMaxLength(50);

                entity.Property(e => e.Veid).HasColumnName("VEID");

                entity.Property(e => e.Vid).HasColumnName("VID");
            });

            modelBuilder.Entity<CostPhaseMast>(entity =>
            {
                entity.ToTable("CostPhaseMast");

                entity.HasIndex(e => e.Code, "IX_CostPhaseMast")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(100);
            });

            modelBuilder.Entity<CostUnitMast>(entity =>
            {
                entity.ToTable("CostUnitMast");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(100);
            });

            modelBuilder.Entity<CostcentreRecurringVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CostcentreRecurringVW");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.CostCentre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("Cost_Centre");

                entity.Property(e => e.CostPhaseId).HasColumnName("CostPhaseID");

                entity.Property(e => e.CostUnit)
                    .HasMaxLength(50)
                    .HasColumnName("Cost_Unit");

                entity.Property(e => e.CostUnitId).HasColumnName("CostUnitID");

                entity.Property(e => e.Credit).HasColumnType("money");

                entity.Property(e => e.Debit).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Phase).HasMaxLength(50);

                entity.Property(e => e.RefNo).HasMaxLength(20);

                entity.Property(e => e.TranType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Veid).HasColumnName("VEID");

                entity.Property(e => e.Vid).HasColumnName("VID");

                entity.Property(e => e.Vtype).HasColumnName("VType");
            });

            modelBuilder.Entity<Creditor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CREDITORS");

                entity.Property(e => e.AccountCode).HasMaxLength(255);

                entity.Property(e => e.AccountName).HasMaxLength(255);

                entity.Property(e => e.Address).HasMaxLength(255);

                entity.Property(e => e.Contact).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Fax).HasMaxLength(255);

                entity.Property(e => e.Mobile).HasMaxLength(255);

                entity.Property(e => e.Tel).HasMaxLength(255);
            });

            modelBuilder.Entity<CurrencyMast>(entity =>
            {
                entity.ToTable("CurrencyMast");

                entity.HasIndex(e => e.Abbreviation, "IX_CurrencyMast")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abbreviation)
                    .IsRequired()
                    .HasMaxLength(3);

                entity.Property(e => e.Active).HasDefaultValueSql("((0))");

                entity.Property(e => e.DegitsAfterDecimal).HasDefaultValueSql("((2))");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ExchangeRate).HasColumnType("money");

                entity.Property(e => e.Mdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<CustomReportColumn>(entity =>
            {
                entity.HasIndex(e => new { e.ReportId, e.ColumnName }, "IX_CustomReportColumns")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DataType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.Property(e => e.Width).HasDefaultValueSql("((100))");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.CustomReportColumns)
                    .HasForeignKey(d => d.ReportId)
                    .HasConstraintName("FK_CustomReportColumns_CustomReportColumns");
            });

            modelBuilder.Entity<CustomReportManager>(entity =>
            {
                entity.ToTable("CustomReportManager");

                entity.HasIndex(e => e.ReportName, "IX_CustomReportManager")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ReportName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SqlQuery).HasColumnType("ntext");
            });

            modelBuilder.Entity<CustomerStatus>(entity =>
            {
                entity.ToTable("CustomerStatus");

                entity.Property(e => e.CustId).HasColumnName("CustID");

                entity.Property(e => e.Remarks).HasMaxLength(150);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.HasOne(d => d.Cust)
                    .WithMany(p => p.CustomerStatuses)
                    .HasForeignKey(d => d.CustId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_CustomerStatus_Accounts");
            });

            modelBuilder.Entity<DatewiseLedgerVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("DatewiseLedgerVW");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CreditSum).HasColumnType("money");

                entity.Property(e => e.DebitSum).HasColumnType("money");

                entity.Property(e => e.EntryDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<Debtor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("DEBTORS");

                entity.Property(e => e.AccountCode).HasMaxLength(255);

                entity.Property(e => e.AccountName).HasMaxLength(255);

                entity.Property(e => e.Contact).HasMaxLength(255);

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Emirates).HasMaxLength(255);

                entity.Property(e => e.Fax).HasMaxLength(255);

                entity.Property(e => e.Mobile).HasMaxLength(255);

                entity.Property(e => e.Oldcode)
                    .HasMaxLength(255)
                    .HasColumnName("oldcode");

                entity.Property(e => e.Pobox)
                    .HasMaxLength(30)
                    .HasColumnName("POBox");

                entity.Property(e => e.Tel).HasMaxLength(255);
            });

            modelBuilder.Entity<DocumentDetail>(entity =>
            {
                entity.HasIndex(e => e.SlNo, "IX_DocumentDetails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClientName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("MDate");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.SlNo)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Supplier).HasMaxLength(50);
            });

            modelBuilder.Entity<DocumentRef>(entity =>
            {
                entity.ToTable("DocumentRef");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.RefVid).HasColumnName("RefVID");

                entity.Property(e => e.Vid).HasColumnName("VID");

                entity.HasOne(d => d.VidNavigation)
                    .WithMany(p => p.DocumentRefs)
                    .HasForeignKey(d => d.Vid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DocumentRef_Voucher");
            });

            modelBuilder.Entity<DocumentTypeMast>(entity =>
            {
                entity.ToTable("DocumentTypeMast");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<DynamicAccount>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.DynamicAccounts)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_DynamicAccounts_Accounts");
            });

            modelBuilder.Entity<EmiratesMast>(entity =>
            {
                entity.ToTable("EmiratesMast");

                entity.HasIndex(e => e.Description, "IX_EmiratesMast")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<EmployeeRegistration>(entity =>
            {
                entity.ToTable("EmployeeRegistration");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("address");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("department");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("gender");

                entity.Property(e => e.Staffid).HasColumnName("staffid");
            });

            modelBuilder.Entity<EntryModeMast>(entity =>
            {
                entity.HasKey(e => e.EntryMode)
                    .IsClustered(false);

                entity.ToTable("EntryModeMast");

                entity.HasIndex(e => e.Id, "IX_EntryModeMast")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.EntryMode).HasMaxLength(20);

                entity.Property(e => e.ArabicName).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImportSource).HasMaxLength(50);

                entity.Property(e => e.InitialVtype).HasColumnName("InitialVType");

                entity.HasOne(d => d.ImportSourceNavigation)
                    .WithMany(p => p.EntryModeMasts)
                    .HasPrincipalKey(p => p.Description)
                    .HasForeignKey(d => d.ImportSource)
                    .HasConstraintName("FK_EntryModeMast_VTypeMast");

                entity.HasOne(d => d.InitialVtypeNavigation)
                    .WithMany(p => p.EntryModeMasts)
                    .HasForeignKey(d => d.InitialVtype)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_EntryModeMast_VTypeTran");
            });

            modelBuilder.Entity<FlightCharting>(entity =>
            {
                entity.ToTable("FlightCharting");

                entity.HasIndex(e => e.RefNo, "IX_FlightDetails")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.ArrivalAirportId).HasColumnName("ArrivalAirportID");

                entity.Property(e => e.ArrivalDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ArrivalTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.DeptAirportId).HasColumnName("DeptAirportID");

                entity.Property(e => e.DeptDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DeptTime).HasColumnType("smalldatetime");

                entity.Property(e => e.GroundTime)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.NetTime)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.StaffNetTime)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.FlightChartings)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_FlightCharting_Accounts");

                entity.HasOne(d => d.ArrivalAirport)
                    .WithMany(p => p.FlightChartingArrivalAirports)
                    .HasForeignKey(d => d.ArrivalAirportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FlightCharting_AirportMast1");

                entity.HasOne(d => d.Cc)
                    .WithMany(p => p.FlightChartings)
                    .HasForeignKey(d => d.Ccid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FlightCharting_CostCentre");

                entity.HasOne(d => d.DeptAirport)
                    .WithMany(p => p.FlightChartingDeptAirports)
                    .HasForeignKey(d => d.DeptAirportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FlightCharting_AirportMast");
            });

            modelBuilder.Entity<FlightChartingDetail>(entity =>
            {
                entity.HasIndex(e => new { e.Fcid, e.AccountId }, "IX_FlightChartingDetails")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.Fcid).HasColumnName("FCID");

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.FlightChartingDetails)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FlightChartingDetails_Accounts");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.FlightChartingDetails)
                    .HasForeignKey(d => d.DesignationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FlightChartingDetails_MastDesignation");

                entity.HasOne(d => d.Fc)
                    .WithMany(p => p.FlightChartingDetails)
                    .HasForeignKey(d => d.Fcid)
                    .HasConstraintName("FK_FlightChartingDetails_FlightCharting");
            });

            modelBuilder.Entity<FlightChartingDetailsVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FlightChartingDetailsVW");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.Fcid).HasColumnName("FCID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Rate).HasColumnType("money");
            });

            modelBuilder.Entity<FlightChartingVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FlightChartingVW");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.ArrCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength(true);

                entity.Property(e => e.ArrName).HasMaxLength(50);

                entity.Property(e => e.ArrivalAirportId).HasColumnName("ArrivalAirportID");

                entity.Property(e => e.ArrivalDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ArrivalTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.DeptAirportId).HasColumnName("DeptAirportID");

                entity.Property(e => e.DeptCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength(true);

                entity.Property(e => e.DeptDate).HasColumnType("smalldatetime");

                entity.Property(e => e.DeptName).HasMaxLength(50);

                entity.Property(e => e.DeptTime).HasColumnType("smalldatetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.GroundTime)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NetTime)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.StaffNetTime)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FlightInvoiceItem>(entity =>
            {
                entity.ToTable("FlightInvoiceItem");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Category).HasMaxLength(25);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Remark).HasMaxLength(150);
            });

            modelBuilder.Entity<FlightInvoiceTran>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Details).HasMaxLength(100);

                entity.Property(e => e.InvItemId).HasColumnName("InvItemID");

                entity.Property(e => e.Vid).HasColumnName("VID");

                entity.HasOne(d => d.Cc)
                    .WithMany(p => p.FlightInvoiceTrans)
                    .HasForeignKey(d => d.Ccid)
                    .HasConstraintName("FK_FlightInvoiceTrans_CostCentre");

                entity.HasOne(d => d.InvItem)
                    .WithMany(p => p.FlightInvoiceTrans)
                    .HasForeignKey(d => d.InvItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FlightInvoiceTrans_FlightInvoiceItem");

                entity.HasOne(d => d.VidNavigation)
                    .WithMany(p => p.FlightInvoiceTrans)
                    .HasForeignKey(d => d.Vid)
                    .HasConstraintName("FK_FlightInvoiceTrans_Voucher");
            });

            modelBuilder.Entity<FlightStaffVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FlightStaffVW");

                entity.Property(e => e.AccCategory).HasMaxLength(30);

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.DesgId).HasColumnName("DesgID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Rate).HasColumnType("money");
            });

            modelBuilder.Entity<FlightVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("FlightVW");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.ArrAirportCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength(true);

                entity.Property(e => e.ArrAirportName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ArrivalAirportId).HasColumnName("ArrivalAirportID");

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.DepAirportCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsFixedLength(true);

                entity.Property(e => e.DepAirportName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DeptAirportId).HasColumnName("DeptAirportID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.NetTime)
                    .HasMaxLength(7)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.RefNo)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.RegNo).HasMaxLength(20);

                entity.Property(e => e.SerialNo).HasMaxLength(20);
            });

            modelBuilder.Entity<FormGridSetting>(entity =>
            {
                entity.HasKey(e => new { e.FormName, e.GridName, e.ColumnName });

                entity.Property(e => e.FormName).HasMaxLength(30);

                entity.Property(e => e.GridName).HasMaxLength(30);

                entity.Property(e => e.ColumnName).HasMaxLength(130);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.NewCaption).HasMaxLength(50);

                entity.Property(e => e.OriginalCaption).HasMaxLength(50);
            });

            modelBuilder.Entity<FormLabelSetting>(entity =>
            {
                entity.HasKey(e => new { e.FormName, e.LabelName })
                    .HasName("PK_FormLabelSetting");

                entity.Property(e => e.FormName).HasMaxLength(30);

                entity.Property(e => e.LabelName).HasMaxLength(30);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.NewCaption).HasMaxLength(50);

                entity.Property(e => e.OriginalCaption).HasMaxLength(50);
            });

            modelBuilder.Entity<FormatMast>(entity =>
            {
                entity.ToTable("FormatMast");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsFixedLength(true);

                entity.Property(e => e.Temp)
                    .HasMaxLength(10)
                    .HasColumnName("temp")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<GroupDetail>(entity =>
            {
                entity.ToTable("GroupDetails", "Inv");

                entity.HasIndex(e => new { e.GroupId, e.ItemId }, "IX_InvGroupDetails")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.QtyPerUnit).HasColumnType("decimal(13, 3)");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupDetailGroups)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_InvGroupDetails_InvItemMaster");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.GroupDetailItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvGroupDetails_InvItemMaster1");
            });

            modelBuilder.Entity<GroupMajor>(entity =>
            {
                entity.HasKey(e => e.MajorGroup);

                entity.ToTable("GroupMajor");

                entity.Property(e => e.MajorGroup).HasMaxLength(30);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<GroupMaster>(entity =>
            {
                entity.ToTable("GroupMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DisplayName).HasMaxLength(50);

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_GroupMaster_GroupMaster");
            });

            modelBuilder.Entity<GroupMasterVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GroupMasterVW");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasMaxLength(75);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<GroupMiddle>(entity =>
            {
                entity.HasKey(e => e.MiddleGroup);

                entity.ToTable("GroupMiddle");

                entity.Property(e => e.MiddleGroup).HasMaxLength(30);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<GroupMinor>(entity =>
            {
                entity.HasKey(e => e.MinorGroup);

                entity.ToTable("GroupMinor");

                entity.Property(e => e.MinorGroup).HasMaxLength(30);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<GroupParent>(entity =>
            {
                entity.HasKey(e => new { e.AccountId, e.ParentId })
                    .HasName("PK_GroupParents_1");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.GroupParents)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_GroupParents_Accounts");
            });

            modelBuilder.Entity<GroupsVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("GroupsVW");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.AccountGroup)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.AccountGroupId).HasColumnName("AccountGroupID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Isdefault).HasColumnName("ISDefault");

                entity.Property(e => e.SubGroup).HasMaxLength(30);

                entity.Property(e => e.SubGroupId).HasColumnName("SubGroupID");
            });

            modelBuilder.Entity<Help>(entity =>
            {
                entity.HasKey(e => e.FormName);

                entity.ToTable("Help");

                entity.Property(e => e.FormName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<HrallowanceMast>(entity =>
            {
                entity.ToTable("HRAllowanceMast");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.SalaryMode).HasMaxLength(100);
            });

            modelBuilder.Entity<HrbranchSetting>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("HRBranchSettings");

                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.Branch).HasMaxLength(50);

                entity.Property(e => e.Code).HasMaxLength(30);

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Pbno).HasColumnName("PBNo");

                entity.Property(e => e.Tel1).HasMaxLength(20);

                entity.Property(e => e.Tel2).HasMaxLength(20);

                entity.Property(e => e.Website).HasMaxLength(100);
            });

            modelBuilder.Entity<HrcompDocImage>(entity =>
            {
                entity.ToTable("HRCompDocImages");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HrcompDocument>(entity =>
            {
                entity.ToTable("HRCompDocuments");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category).HasMaxLength(30);

                entity.Property(e => e.Cid).HasColumnName("CID");

                entity.Property(e => e.DocLocation).HasMaxLength(50);

                entity.Property(e => e.DocumentNo).HasMaxLength(30);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.IssuePlace).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(30);

                entity.HasOne(d => d.CidNavigation)
                    .WithMany(p => p.HrcompDocuments)
                    .HasForeignKey(d => d.Cid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRCompDocuments_Company");
            });

            modelBuilder.Entity<HrdayTypeMaster>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("HRDayTypeMaster");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DayValue).HasColumnType("decimal(2, 1)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.RateValue).HasColumnType("money");
            });

            modelBuilder.Entity<HrdepartmentMast>(entity =>
            {
                entity.ToTable("HRDepartmentMast");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HrdocTranDetail>(entity =>
            {
                entity.ToTable("HRDocTranDetails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Dtid).HasColumnName("DTID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Type).HasMaxLength(30);

                entity.HasOne(d => d.Dt)
                    .WithMany(p => p.HrdocTranDetails)
                    .HasForeignKey(d => d.Dtid)
                    .HasConstraintName("FK_HRDocTranDetails_HRDocTransfer");
            });

            modelBuilder.Entity<HrdocTransfer>(entity =>
            {
                entity.ToTable("HRDocTransfer");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FromWhere).HasMaxLength(50);

                entity.Property(e => e.RefNo).HasMaxLength(20);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.ToWhere).HasMaxLength(50);
            });

            modelBuilder.Entity<HrempAdvance>(entity =>
            {
                entity.ToTable("HREmpAdvance");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TotalAmount).HasColumnType("money");

                entity.Property(e => e.Type).HasMaxLength(30);
            });

            modelBuilder.Entity<HrempAdvanceDetail>(entity =>
            {
                entity.ToTable("HREmpAdvanceDetails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aid).HasColumnName("AID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.HrempAdvanceDetails)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_HREmpAdvanceDetails_Accounts");
            });

            modelBuilder.Entity<HrempChequeDetail>(entity =>
            {
                entity.ToTable("HREmpChequeDetails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Bank).HasMaxLength(50);

                entity.Property(e => e.ChequeDate).HasColumnType("datetime");

                entity.Property(e => e.CkequeNo).HasMaxLength(30);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");
            });

            modelBuilder.Entity<HrempDeductionMaster>(entity =>
            {
                entity.ToTable("HREmpDeductionMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(40);
            });

            modelBuilder.Entity<HrempDocImage>(entity =>
            {
                entity.ToTable("HREmpDocImages");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.DocType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.HrempDocImages)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HREmpDocImages_HREmpDocuments");
            });

            modelBuilder.Entity<HrempDocument>(entity =>
            {
                entity.ToTable("HREmpDocuments");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category).HasMaxLength(25);

                entity.Property(e => e.DocumentNo).HasMaxLength(25);

                entity.Property(e => e.DocumentType).HasMaxLength(50);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.IssuePlace).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(30);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.HrempDocuments)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HREmpDocuments_Accounts");
            });

            modelBuilder.Entity<HrempExpImage>(entity =>
            {
                entity.ToTable("HREmpExpImages");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.HrempExpImages)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HREmpExpImages_HREmpDocuments");
            });

            modelBuilder.Entity<HrempExperience>(entity =>
            {
                entity.ToTable("HREmpExperience");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.Designation).HasMaxLength(30);

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.HasOne(d => d.DesignationNavigation)
                    .WithMany(p => p.HrempExperiences)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("FK_HREmpExperience_MastDesignation");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.HrempExperiences)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HREmpExperience_Accounts");
            });

            modelBuilder.Entity<HrempExperienceImage>(entity =>
            {
                entity.ToTable("HREmpExperienceImages");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExpId).HasColumnName("ExpID");

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.Type).HasMaxLength(30);
            });

            modelBuilder.Entity<HrempFamImage>(entity =>
            {
                entity.ToTable("HREmpFamImages");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.FamId).HasColumnName("FamID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.HrempFamImages)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HREmpFamImages_HREmpDocuments");
            });

            modelBuilder.Entity<HrempFamily>(entity =>
            {
                entity.ToTable("HREmpFamily");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Gender).HasMaxLength(20);

                entity.Property(e => e.PassportNo).HasMaxLength(20);

                entity.Property(e => e.PersonName).HasMaxLength(50);

                entity.Property(e => e.Relation).HasMaxLength(30);

                entity.Property(e => e.RelationId).HasColumnName("RelationID");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.HrempFamilies)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HREmpFamily_Accounts");

                entity.HasOne(d => d.RelationNavigation)
                    .WithMany(p => p.HrempFamilies)
                    .HasForeignKey(d => d.RelationId)
                    .HasConstraintName("FK_HREmpFamily_HRMaster");
            });

            modelBuilder.Entity<HrempFamilyImage>(entity =>
            {
                entity.ToTable("HREmpFamilyImages");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FamilyId).HasColumnName("FamilyID");

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.Type).HasMaxLength(30);

                entity.HasOne(d => d.Family)
                    .WithMany(p => p.HrempFamilyImages)
                    .HasForeignKey(d => d.FamilyId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HREmpFamilyImages_HREmpFamily");
            });

            modelBuilder.Entity<HrempIncomeMaster>(entity =>
            {
                entity.ToTable("HREmpIncomeMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(40);
            });

            modelBuilder.Entity<HrempLeaveDetail>(entity =>
            {
                entity.ToTable("HREmpLeaveDetails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.JoiningDate).HasColumnType("datetime");

                entity.Property(e => e.LeaveType).HasMaxLength(40);

                entity.Property(e => e.Mdate)
                    .HasColumnType("datetime")
                    .HasColumnName("MDate");

                entity.Property(e => e.Muser)
                    .HasMaxLength(40)
                    .HasColumnName("MUser");

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.HrempLeaveDetails)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_HREmpLeaveDetails_Accounts");
            });

            modelBuilder.Entity<HrempNote>(entity =>
            {
                entity.ToTable("HREmpNotes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Category).HasMaxLength(30);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Mdate)
                    .HasColumnType("datetime")
                    .HasColumnName("MDate");

                entity.Property(e => e.Muser)
                    .HasMaxLength(40)
                    .HasColumnName("MUser");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.HrempNotes)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_HREmpNotes_Accounts");
            });

            modelBuilder.Entity<HrempPhoto>(entity =>
            {
                entity.ToTable("HREmpPhoto");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Photo).HasColumnType("image");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.HrempPhotos)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HREmpPhoto_Accounts");
            });

            modelBuilder.Entity<HrempProject>(entity =>
            {
                entity.HasKey(e => e.TrNo)
                    .HasName("PK_HREmpProject_1");

                entity.ToTable("HREmpProject");

                entity.Property(e => e.TrNo).HasMaxLength(30);

                entity.Property(e => e.ApprovedBy).HasMaxLength(50);

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.Tdate)
                    .HasColumnType("datetime")
                    .HasColumnName("TDate");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.HasOne(d => d.ProjectCodeNavigation)
                    .WithMany(p => p.HrempProjects)
                    .HasForeignKey(d => d.ProjectCode)
                    .HasConstraintName("FK_HREmpProject_CostCentre");
            });

            modelBuilder.Entity<HrempProjectTran>(entity =>
            {
                entity.ToTable("HREmpProjectTran");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.RefNo).HasMaxLength(20);

                entity.Property(e => e.Status).HasMaxLength(15);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.TrNo).HasMaxLength(30);

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.HrempProjectTrans)
                    .HasForeignKey(d => d.EmpId)
                    .HasConstraintName("FK_HREmpProjectTran_Accounts");

                entity.HasOne(d => d.RefNoNavigation)
                    .WithMany(p => p.HrempProjectTrans)
                    .HasForeignKey(d => d.RefNo)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HREmpProjectTran_HRProjectTransfer");
            });

            modelBuilder.Entity<HrempQualImage>(entity =>
            {
                entity.ToTable("HREmpQualImages");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DocId).HasColumnName("DocID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Doc)
                    .WithMany(p => p.HrempQualImages)
                    .HasForeignKey(d => d.DocId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HREmpQualImages_HREmpDocuments");
            });

            modelBuilder.Entity<HrempQualification>(entity =>
            {
                entity.ToTable("HREmpQualification");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DegreeId).HasColumnName("DegreeID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Qualification).HasMaxLength(30);

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.University).HasMaxLength(50);

                entity.HasOne(d => d.Degree)
                    .WithMany(p => p.HrempQualifications)
                    .HasForeignKey(d => d.DegreeId)
                    .HasConstraintName("FK_HREmpQualification_HRMaster");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.HrempQualifications)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HREmpQualification_Accounts");
            });

            modelBuilder.Entity<HrempQualificationImage>(entity =>
            {
                entity.ToTable("HREmpQualificationImages");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.QualifyId).HasColumnName("QualifyID");

                entity.Property(e => e.Type).HasMaxLength(30);

                entity.HasOne(d => d.Qualify)
                    .WithMany(p => p.HrempQualificationImages)
                    .HasForeignKey(d => d.QualifyId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HREmpQulificationImages_HREmpQualification");
            });

            modelBuilder.Entity<HrempSalary>(entity =>
            {
                entity.ToTable("HREmpSalary");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllowanceId).HasColumnName("AllowanceID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.Allowance)
                    .WithMany(p => p.HrempSalaries)
                    .HasForeignKey(d => d.AllowanceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HREmpSalary_HRAllowanceMast");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.HrempSalaries)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HREmpSalary_Accounts");
            });

            modelBuilder.Entity<HrempWage>(entity =>
            {
                entity.HasKey(e => new { e.EmpId, e.Month, e.Year })
                    .HasName("PK_HREmpWages_1")
                    .IsClustered(false);

                entity.ToTable("HREmpWages");

                entity.HasIndex(e => e.Id, "IX_HREmpWages")
                    .IsUnique();

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Month).HasMaxLength(30);

                entity.Property(e => e.Advance).HasColumnType("money");

                entity.Property(e => e.BasicSalary).HasColumnType("money");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DaysWorked).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.NetSalary).HasColumnType("money");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.PostNetId).HasColumnName("PostNetID");

                entity.Property(e => e.PrintStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.Project).HasMaxLength(50);

                entity.Property(e => e.RollNo).HasMaxLength(30);

                entity.Property(e => e.TotalAllowance).HasColumnType("money");

                entity.Property(e => e.TotalHours).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.TotalRate).HasColumnType("money");

                entity.Property(e => e.TotalWages).HasColumnType("money");

                entity.Property(e => e.Totaldeduction).HasColumnType("money");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.HrempWages)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HREmpWages_Accounts");

                entity.HasOne(d => d.HrtimeSheet)
                    .WithOne(p => p.HrempWage)
                    .HasForeignKey<HrempWage>(d => new { d.EmpId, d.Month, d.Year })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HREmpWages_HRTimeSheets");
            });

            modelBuilder.Entity<HrempWagesDeduction>(entity =>
            {
                entity.ToTable("HREmpWagesDeduction");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.DeductionId).HasColumnName("DeductionID");

                entity.Property(e => e.Wiid).HasColumnName("WIID");

                entity.HasOne(d => d.Deduction)
                    .WithMany(p => p.HrempWagesDeductions)
                    .HasPrincipalKey(p => p.Id)
                    .HasForeignKey(d => d.DeductionId)
                    .HasConstraintName("FK_HREmpWagesDeduction_MasterMisc");

                entity.HasOne(d => d.Wi)
                    .WithMany(p => p.HrempWagesDeductions)
                    .HasPrincipalKey(p => p.Id)
                    .HasForeignKey(d => d.Wiid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HREmpWagesDeduction_HREmpWages");
            });

            modelBuilder.Entity<HrempWagesIncome>(entity =>
            {
                entity.ToTable("HREmpWagesIncome");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Numbers).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.Wages).HasMaxLength(30);

                entity.Property(e => e.Wiid).HasColumnName("WIID");

                entity.HasOne(d => d.Wi)
                    .WithMany(p => p.HrempWagesIncomes)
                    .HasPrincipalKey(p => p.Id)
                    .HasForeignKey(d => d.Wiid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HREmpWagesIncome_HREmpWages");
            });

            modelBuilder.Entity<Hremployee>(entity =>
            {
                entity.ToTable("HREmployee");

                entity.HasIndex(e => e.EmpId, "IX_HREmployee")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.BankAccount).HasMaxLength(30);

                entity.Property(e => e.BasicSalary).HasColumnType("money");

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BloodGroup).HasMaxLength(50);

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Eosdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EOSDate");

                entity.Property(e => e.FromDateTemp).HasColumnType("datetime");

                entity.Property(e => e.Gender).HasMaxLength(20);

                entity.Property(e => e.Grade).HasMaxLength(50);

                entity.Property(e => e.IncremantDate).HasColumnType("datetime");

                entity.Property(e => e.JoiningDate).HasColumnType("datetime");

                entity.Property(e => e.LeaveSalary).HasMaxLength(10);

                entity.Property(e => e.MaritalStatus).HasMaxLength(15);

                entity.Property(e => e.Mdate)
                    .HasColumnType("datetime")
                    .HasColumnName("MDate");

                entity.Property(e => e.MinistrySalary).HasColumnType("money");

                entity.Property(e => e.MinistryStatus).HasMaxLength(20);

                entity.Property(e => e.Muser)
                    .HasMaxLength(50)
                    .HasColumnName("MUser");

                entity.Property(e => e.OnDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMode).HasMaxLength(30);

                entity.Property(e => e.ProjectTranId).HasColumnName("ProjectTranID");

                entity.Property(e => e.Religion).HasMaxLength(50);

                entity.Property(e => e.RemarksFinancial).HasMaxLength(50);

                entity.Property(e => e.SalaryMode).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.Ticket).HasMaxLength(50);

                entity.Property(e => e.ToDateTemp).HasColumnType("datetime");

                entity.Property(e => e.VisaDesignation).HasMaxLength(30);

                entity.Property(e => e.VisaType).HasMaxLength(20);

                entity.Property(e => e.Wbranch)
                    .HasMaxLength(20)
                    .HasColumnName("WBranch");

                entity.HasOne(d => d.Emp)
                    .WithOne(p => p.Hremployee)
                    .HasForeignKey<Hremployee>(d => d.EmpId)
                    .HasConstraintName("FK_HREmployee_Accounts");
            });

            modelBuilder.Entity<HremployeeBackup>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("HREmployeeBackup");

                entity.Property(e => e.EmpId)
                    .ValueGeneratedNever()
                    .HasColumnName("EmpID");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.Area).HasMaxLength(30);

                entity.Property(e => e.BankAccount).HasMaxLength(30);

                entity.Property(e => e.BankName).HasMaxLength(40);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BloodGroup).HasMaxLength(50);

                entity.Property(e => e.Category).HasMaxLength(20);

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Emirates).HasMaxLength(30);

                entity.Property(e => e.Eosdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EOSDate");

                entity.Property(e => e.Gender).HasMaxLength(20);

                entity.Property(e => e.Grade).HasMaxLength(50);

                entity.Property(e => e.Haddress1)
                    .HasMaxLength(50)
                    .HasColumnName("HAddress1");

                entity.Property(e => e.Haddress2)
                    .HasMaxLength(50)
                    .HasColumnName("HAddress2");

                entity.Property(e => e.Hcountry)
                    .HasMaxLength(50)
                    .HasColumnName("HCountry");

                entity.Property(e => e.Hphone)
                    .HasMaxLength(15)
                    .HasColumnName("HPhone");

                entity.Property(e => e.IncremantDate).HasColumnType("datetime");

                entity.Property(e => e.JoiningDate).HasColumnType("datetime");

                entity.Property(e => e.LeaveSalary).HasMaxLength(10);

                entity.Property(e => e.MaritalStatus).HasMaxLength(15);

                entity.Property(e => e.Mdate)
                    .HasColumnType("datetime")
                    .HasColumnName("MDate");

                entity.Property(e => e.MinistrySalary).HasColumnType("money");

                entity.Property(e => e.MinistryStatus).HasMaxLength(20);

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.Muser)
                    .HasMaxLength(50)
                    .HasColumnName("MUser");

                entity.Property(e => e.Nationality).HasMaxLength(30);

                entity.Property(e => e.Pbno)
                    .HasMaxLength(20)
                    .HasColumnName("PBNo");

                entity.Property(e => e.ProjectTranId).HasColumnName("ProjectTranID");

                entity.Property(e => e.Religion).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.RemarksFinancial).HasMaxLength(50);

                entity.Property(e => e.RemarksOfficial).HasMaxLength(50);

                entity.Property(e => e.Rphone)
                    .HasMaxLength(20)
                    .HasColumnName("RPhone");

                entity.Property(e => e.SalaryMode).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.VisaDesignation).HasMaxLength(30);

                entity.Property(e => e.VisaType).HasMaxLength(20);

                entity.Property(e => e.Wbranch)
                    .HasMaxLength(20)
                    .HasColumnName("WBranch");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.HremployeeBackups)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_HREmployeeBackup_HRDepartmentMast");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.HremployeeBackups)
                    .HasForeignKey(d => d.DesignationId)
                    .HasConstraintName("FK_HREmployeeBackup_MastDesignation");

                entity.HasOne(d => d.Emp)
                    .WithOne(p => p.HremployeeBackup)
                    .HasForeignKey<HremployeeBackup>(d => d.EmpId)
                    .HasConstraintName("FK_HREmployeeBackup_Accounts");
            });

            modelBuilder.Entity<Hrgratuity>(entity =>
            {
                entity.ToTable("HRGratuity");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Days).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.GrDays).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.GrId).HasColumnName("GrID");

                entity.Property(e => e.Gratuity).HasMaxLength(50);

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.HasOne(d => d.Gr)
                    .WithMany(p => p.Hrgratuities)
                    .HasForeignKey(d => d.GrId)
                    .HasConstraintName("FK_HRGrativity_HRGrativityParent");
            });

            modelBuilder.Entity<HrgratuityParent>(entity =>
            {
                entity.ToTable("HRGratuityParent");

                entity.HasIndex(e => e.EmpId, "IX_HRGrativityParent")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DeductionTotal).HasColumnType("money");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.GrandTotal).HasColumnType("money");

                entity.Property(e => e.GrativityTotal).HasColumnType("money");

                entity.Property(e => e.IncomeTotal).HasColumnType("money");

                entity.Property(e => e.JoinDate).HasColumnType("datetime");

                entity.Property(e => e.Net).HasColumnType("money");

                entity.Property(e => e.RefNo).HasMaxLength(20);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.Vid).HasColumnName("VID");

                entity.HasOne(d => d.Emp)
                    .WithOne(p => p.HrgratuityParent)
                    .HasForeignKey<HrgratuityParent>(d => d.EmpId)
                    .HasConstraintName("FK_HRGrativity_HRGrativity");
            });

            modelBuilder.Entity<HrgratuityTran>(entity =>
            {
                entity.ToTable("HRGratuityTran");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.GrId).HasColumnName("GrID");

                entity.Property(e => e.Income).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.Type).HasMaxLength(20);

                entity.HasOne(d => d.Gr)
                    .WithMany(p => p.HrgratuityTrans)
                    .HasForeignKey(d => d.GrId)
                    .HasConstraintName("FK_HRGrativityTran_HRGrativityParent");
            });

            modelBuilder.Entity<HrinvContract>(entity =>
            {
                entity.ToTable("HRInvContract");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdvDedDesc).HasMaxLength(100);

                entity.Property(e => e.AdvDeduction).HasColumnType("money");

                entity.Property(e => e.Client).HasMaxLength(50);

                entity.Property(e => e.ContractValue).HasColumnType("money");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DedTotal).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.InvoiceNo)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Net).HasColumnType("money");

                entity.Property(e => e.NetReceivable).HasColumnType("money");

                entity.Property(e => e.NetReceivableDesc).HasMaxLength(100);

                entity.Property(e => e.PrevBillNo).HasMaxLength(20);

                entity.Property(e => e.PrevPayment).HasColumnType("money");

                entity.Property(e => e.PrevPaymentDesc).HasMaxLength(100);

                entity.Property(e => e.Progressive).HasMaxLength(20);

                entity.Property(e => e.Project)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.Retention).HasColumnType("money");

                entity.Property(e => e.RetentionDesc).HasMaxLength(100);

                entity.Property(e => e.WorProgTotal).HasColumnType("money");
            });

            modelBuilder.Entity<HrinvDeduction>(entity =>
            {
                entity.ToTable("HRInvDeduction");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.HasOne(d => d.PidNavigation)
                    .WithMany(p => p.HrinvDeductions)
                    .HasForeignKey(d => d.Pid)
                    .HasConstraintName("FK_HRInvDeduction_HRInvContract");
            });

            modelBuilder.Entity<HrinvWorkingProgress>(entity =>
            {
                entity.ToTable("HRInvWorkingProgress");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CurrPercentage).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.PrevPercentage).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Qty).HasColumnType("decimal(8, 2)");

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.HasOne(d => d.PidNavigation)
                    .WithMany(p => p.HrinvWorkingProgresses)
                    .HasForeignKey(d => d.Pid)
                    .HasConstraintName("FK_HRInvWorkingProgress_HRInvContract");
            });

            modelBuilder.Entity<HrleaveSalary>(entity =>
            {
                entity.ToTable("HRLeaveSalary");

                entity.HasIndex(e => new { e.Month, e.Year }, "IX_HRLeaveSalary")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Month)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.RefNo)
                    .HasMaxLength(20)
                    .IsFixedLength(true);

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<HrleaveSalaryTran>(entity =>
            {
                entity.ToTable("HRLeaveSalaryTran");

                entity.HasIndex(e => new { e.Lsid, e.EmpId }, "IX_HRLeaveSalaryTran")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Lsid).HasColumnName("LSID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.Ls)
                    .WithMany(p => p.HrleaveSalaryTrans)
                    .HasForeignKey(d => d.Lsid)
                    .HasConstraintName("FK_HRLeaveSalary_HRLeaveSalaryTran");
            });

            modelBuilder.Entity<Hrmaster>(entity =>
            {
                entity.ToTable("HRMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(30);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<HrprojectInvoice>(entity =>
            {
                entity.ToTable("HRProjectInvoice");

                entity.HasIndex(e => new { e.Month, e.Year, e.ProjectId }, "IX_HRProjectInvoice")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Attention).HasMaxLength(100);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("money");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo).HasMaxLength(20);

                entity.Property(e => e.Month)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Net).HasColumnType("money");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.RefNo).HasMaxLength(20);

                entity.Property(e => e.Total).HasColumnType("money");
            });

            modelBuilder.Entity<HrprojectInvoiceTran>(entity =>
            {
                entity.ToTable("HRProjectInvoiceTran");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Crate)
                    .HasColumnType("money")
                    .HasColumnName("CRate");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Erate)
                    .HasColumnType("money")
                    .HasColumnName("ERate");

                entity.Property(e => e.Hour).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.HasOne(d => d.PidNavigation)
                    .WithMany(p => p.HrprojectInvoiceTrans)
                    .HasForeignKey(d => d.Pid)
                    .HasConstraintName("FK_HRProjectInvioceTran_HRProjectInvoice");
            });

            modelBuilder.Entity<HrprojectTransfer>(entity =>
            {
                entity.HasKey(e => e.RefNo)
                    .HasName("PK_HRProjectTransfer_1");

                entity.ToTable("HRProjectTransfer");

                entity.HasIndex(e => e.RefNo, "IX_HRProjectTransfer")
                    .IsUnique();

                entity.Property(e => e.RefNo).HasMaxLength(20);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ToProject).HasMaxLength(20);
            });

            modelBuilder.Entity<HrrateMasterEmployee>(entity =>
            {
                entity.ToTable("HRRateMasterEmployee");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Rate).HasColumnType("money");
            });

            modelBuilder.Entity<HrrateMasterProject>(entity =>
            {
                entity.ToTable("HRRateMasterProject");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Crate)
                    .HasColumnType("money")
                    .HasColumnName("CRate");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.Erate)
                    .HasColumnType("money")
                    .HasColumnName("ERate");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");
            });

            modelBuilder.Entity<Hrreminder>(entity =>
            {
                entity.ToTable("HRReminders");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Action).HasMaxLength(50);

                entity.Property(e => e.Category).HasMaxLength(30);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Remarks).HasMaxLength(100);
            });

            modelBuilder.Entity<HrstmtMatter>(entity =>
            {
                entity.ToTable("HRStmtMatter");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.Category).HasMaxLength(50);
            });

            modelBuilder.Entity<HrtimeSheet>(entity =>
            {
                entity.HasKey(e => new { e.EmpId, e.Month, e.Year });

                entity.ToTable("HRTimeSheets");

                entity.HasIndex(e => e.Id, "IX_HRTimeSheets")
                    .IsUnique();

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Month).HasMaxLength(30);

                entity.Property(e => e.Bonus).HasColumnType("money");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Days).HasColumnType("decimal(6, 2)");

                entity.Property(e => e.Hottotal)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("HOTTotal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.MainProject).HasMaxLength(30);

                entity.Property(e => e.Mdate)
                    .HasColumnType("datetime")
                    .HasColumnName("MDate");

                entity.Property(e => e.Muser)
                    .HasMaxLength(40)
                    .HasColumnName("MUser");

                entity.Property(e => e.Nhtotal)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("NHTotal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ottotal)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("OTTotal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.RollNo).HasMaxLength(30);

                entity.Property(e => e.Thtotal)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("THTotal")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Emp)
                    .WithMany(p => p.HrtimeSheets)
                    .HasForeignKey(d => d.EmpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HRTimeSheets_Accounts");
            });

            modelBuilder.Entity<HrtimeSheetConsolidated>(entity =>
            {
                entity.ToTable("HRTimeSheetConsolidated");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Bonus).HasColumnType("money");

                entity.Property(e => e.Days).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.Hot)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("HOT");

                entity.Property(e => e.Ot)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("OT");

                entity.Property(e => e.Project).HasMaxLength(30);

                entity.Property(e => e.Tid).HasColumnName("TID");

                entity.HasOne(d => d.TidNavigation)
                    .WithMany(p => p.HrtimeSheetConsolidateds)
                    .HasPrincipalKey(p => p.Id)
                    .HasForeignKey(d => d.Tid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HRTimeSheetConsolidated_HRTimeSheets");
            });

            modelBuilder.Entity<HrtimeSheetDefaultSetting>(entity =>
            {
                entity.ToTable("HRTimeSheetDefaultSettings");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Branch).HasMaxLength(50);

                entity.Property(e => e.Project).HasMaxLength(40);

                entity.Property(e => e.Th)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("TH");
            });

            modelBuilder.Entity<HrtimeSheetDetail>(entity =>
            {
                entity.ToTable("HRTimeSheetDetails");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Crate)
                    .HasColumnType("money")
                    .HasColumnName("CRate");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DayType).HasMaxLength(30);

                entity.Property(e => e.Designation).HasMaxLength(30);

                entity.Property(e => e.Hot)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("HOT");

                entity.Property(e => e.Nh)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("NH");

                entity.Property(e => e.Ot)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("OT");

                entity.Property(e => e.Project).HasMaxLength(30);

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.RefNo).HasMaxLength(30);

                entity.Property(e => e.Th)
                    .HasColumnType("decimal(4, 2)")
                    .HasColumnName("TH");

                entity.Property(e => e.Tsid).HasColumnName("TSID");

                entity.HasOne(d => d.Ts)
                    .WithMany(p => p.HrtimeSheetDetails)
                    .HasPrincipalKey(p => p.Id)
                    .HasForeignKey(d => d.Tsid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_HRTimeSheetDetails_HRTimeSheets");
            });

            modelBuilder.Entity<HrtransportationMast>(entity =>
            {
                entity.HasKey(e => e.VehicleNo)
                    .HasName("PK_TransportationMast");

                entity.ToTable("HRTransportationMast");

                entity.Property(e => e.VehicleNo).HasMaxLength(50);

                entity.Property(e => e.ChassisNo).HasMaxLength(50);

                entity.Property(e => e.Emirates).HasMaxLength(50);

                entity.Property(e => e.EngineNo).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Make).HasMaxLength(50);

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.Plate).HasMaxLength(50);

                entity.Property(e => e.RegNo)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.Supplier).HasMaxLength(50);

                entity.Property(e => e.VehicleName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HrtransportationTran>(entity =>
            {
                entity.ToTable("HRTransportationTran");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Class).HasMaxLength(50);

                entity.Property(e => e.InsAmount).HasColumnType("money");

                entity.Property(e => e.InsCompany).HasMaxLength(100);

                entity.Property(e => e.InsExpiryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InsIssueDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InsStatus).HasMaxLength(100);

                entity.Property(e => e.Kilometer).HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.MlkExpiryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MlkIdno).HasColumnName("MlkIDNo");

                entity.Property(e => e.MlkIssueDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MlkRenewalDate).HasColumnType("smalldatetime");

                entity.Property(e => e.MlkStatus).HasMaxLength(50);

                entity.Property(e => e.NextDate).HasColumnType("smalldatetime");

                entity.Property(e => e.NextKm)
                    .HasMaxLength(50)
                    .HasColumnName("NextKM");

                entity.Property(e => e.PolicyNo).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.ServiceDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ServiceNo).HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.VehicleNo)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<HrwagesAllView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("HRWagesAllView");

                entity.Property(e => e.Accomodation).HasColumnType("money");

                entity.Property(e => e.Allowance).HasColumnType("money");

                entity.Property(e => e.Basic).HasColumnType("money");

                entity.Property(e => e.Bonus).HasColumnType("money");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.HolidayOtHrs)
                    .HasColumnType("money")
                    .HasColumnName("Holiday OT Hrs");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.NormalOtHrs)
                    .HasColumnType("money")
                    .HasColumnName("Normal OT Hrs");

                entity.Property(e => e.Others).HasColumnType("money");

                entity.Property(e => e.Telephone).HasColumnType("money");

                entity.Property(e => e.Transportation).HasColumnType("money");
            });

            modelBuilder.Entity<Image>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.Type, e.ImageId }, "IX_Images")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImageId).HasColumnName("ImageID");

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.Type)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IncrimentMast>(entity =>
            {
                entity.ToTable("IncrimentMast");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<InvFifoallocation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InvFIFOAllocation");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.InId).HasColumnName("InID");

                entity.Property(e => e.OutId).HasColumnName("OutID");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");
            });

            modelBuilder.Entity<InvItemSearch>(entity =>
            {
                entity.ToTable("InvItemSearch");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.KeyType)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.InvItemSearches)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_InvItemSearch_ItemMaster");
            });

            modelBuilder.Entity<InvJobOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InvJobOrder");

                entity.Property(e => e.AccVerified).HasMaxLength(50);

                entity.Property(e => e.AccVerifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Activated).HasMaxLength(30);

                entity.Property(e => e.ActivatedDate).HasColumnType("datetime");

                entity.Property(e => e.Additional).HasColumnType("money");

                entity.Property(e => e.ApprovedAmount).HasColumnName("Approved Amount");

                entity.Property(e => e.Branch).HasMaxLength(30);

                entity.Property(e => e.ContactNo)
                    .HasMaxLength(20)
                    .HasColumnName("Contact No");

                entity.Property(e => e.ContactPerson)
                    .HasMaxLength(100)
                    .HasColumnName("Contact Person");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(200)
                    .HasColumnName("Customer Address");

                entity.Property(e => e.CustomerCode)
                    .HasMaxLength(20)
                    .HasColumnName("Customer Code");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(200)
                    .HasColumnName("Customer Name");

                entity.Property(e => e.CutOffDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Cut off Date");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNo).HasMaxLength(250);

                entity.Property(e => e.JobDescription)
                    .HasMaxLength(100)
                    .HasColumnName("Job Description");

                entity.Property(e => e.JobType).HasMaxLength(30);

                entity.Property(e => e.Mdate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.Print).HasMaxLength(100);

                entity.Property(e => e.ProofApproved).HasMaxLength(30);

                entity.Property(e => e.QuotRef)
                    .HasMaxLength(30)
                    .HasColumnName("Quot Ref");

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.Property(e => e.RefType).HasMaxLength(20);

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.SalesDivision)
                    .HasMaxLength(20)
                    .HasColumnName("Sales Division");

                entity.Property(e => e.SalesRep)
                    .HasMaxLength(50)
                    .HasColumnName("Sales Rep");

                entity.Property(e => e.SalesRepId)
                    .HasMaxLength(30)
                    .HasColumnName("SalesRepID");

                entity.Property(e => e.SizeOfSign)
                    .HasMaxLength(100)
                    .HasColumnName("Size of Sign");

                entity.Property(e => e.Status).HasMaxLength(30);

                entity.Property(e => e.SubStatus).HasMaxLength(30);

                entity.Property(e => e.TotAmount).HasColumnType("money");

                entity.Property(e => e.TypeOfSign)
                    .HasMaxLength(50)
                    .HasColumnName("Type of Sign");

                entity.Property(e => e.User).HasMaxLength(20);
            });

            modelBuilder.Entity<InvJoborderItem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("InvJoborderItem");

                entity.Property(e => e.BookNo).HasMaxLength(50);

                entity.Property(e => e.ColourofInk).HasMaxLength(50);

                entity.Property(e => e.Copies).HasMaxLength(50);

                entity.Property(e => e.Gum).HasMaxLength(10);

                entity.Property(e => e.ItemId)
                    .HasMaxLength(50)
                    .HasColumnName("item id");

                entity.Property(e => e.SerialNo).HasMaxLength(20);

                entity.Property(e => e.Size).HasMaxLength(50);

                entity.Property(e => e.SlNo).HasMaxLength(5);

                entity.Property(e => e.Total).HasColumnType("money");

                entity.Property(e => e.Unit).HasMaxLength(20);
            });

            modelBuilder.Entity<InvoiceNote>(entity =>
            {
                entity.HasKey(e => e.Keyword);

                entity.Property(e => e.Keyword).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(1000);

                entity.Property(e => e.Remark).HasMaxLength(50);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Inward>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Inward");

                entity.Property(e => e.Cost).HasColumnType("money");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Tdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("TDate");

                entity.Property(e => e.TranId).HasColumnName("TranID");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Item$");

                entity.Property(e => e.Category).HasMaxLength(255);

                entity.Property(e => e.ItemCode).HasMaxLength(255);

                entity.Property(e => e.ItemName).HasMaxLength(255);

                entity.Property(e => e.SPrice)
                    .HasMaxLength(255)
                    .HasColumnName("S#Price");

                entity.Property(e => e.Stock).HasMaxLength(255);

                entity.Property(e => e.TotalCost).HasColumnName("Total Cost");

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<ItemMaster>(entity =>
            {
                entity.ToTable("ItemMaster", "Inv");

                entity.HasIndex(e => e.ItemCode, "IX_InvItemMaster")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AvgCost).HasColumnType("money");

                entity.Property(e => e.BarCode).HasMaxLength(20);

                entity.Property(e => e.BookNo).HasMaxLength(30);

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.CashPrice).HasColumnType("money");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Color).HasMaxLength(30);

                entity.Property(e => e.CostAccountId).HasColumnName("CostAccountID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.CreditPrice).HasColumnType("money");

                entity.Property(e => e.ExcisePercen).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Field1).HasColumnType("ntext");

                entity.Property(e => e.Field2).HasMaxLength(100);

                entity.Property(e => e.Field3).HasMaxLength(100);

                entity.Property(e => e.Field4).HasMaxLength(100);

                entity.Property(e => e.Field5).HasMaxLength(100);

                entity.Property(e => e.InvAccountId).HasColumnName("InvAccountID");

                entity.Property(e => e.InvoicedStock).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ItemCode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ItemName).IsRequired();

                entity.Property(e => e.LastCost).HasColumnType("money");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MajorGroup).HasMaxLength(30);

                entity.Property(e => e.Manufacturer).HasMaxLength(30);

                entity.Property(e => e.Material).HasMaxLength(100);

                entity.Property(e => e.MiddleGroup).HasMaxLength(30);

                entity.Property(e => e.MinorGroup).HasMaxLength(30);

                entity.Property(e => e.ModelNo).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Oemno)
                    .HasMaxLength(50)
                    .HasColumnName("OEMNo");

                entity.Property(e => e.Other).HasMaxLength(30);

                entity.Property(e => e.PaperSize).HasMaxLength(30);

                entity.Property(e => e.PartNo).HasMaxLength(100);

                entity.Property(e => e.PurchaseAccountId).HasColumnName("PurchaseAccountID");

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.Rol)
                    .HasColumnType("decimal(13, 3)")
                    .HasColumnName("ROL");

                entity.Property(e => e.Roq)
                    .HasColumnType("decimal(13, 3)")
                    .HasColumnName("ROQ");

                entity.Property(e => e.SalesAccountId).HasColumnName("SalesAccountID");

                entity.Property(e => e.SellingPrice).HasColumnType("money");

                entity.Property(e => e.SerialNo).HasMaxLength(30);

                entity.Property(e => e.Stock).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StockItem)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Vatpercen)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("VATPercen");

                entity.Property(e => e.Vrate)
                    .HasColumnType("money")
                    .HasColumnName("VRate");

                entity.HasOne(d => d.MajorGroupNavigation)
                    .WithMany(p => p.ItemMasters)
                    .HasForeignKey(d => d.MajorGroup)
                    .HasConstraintName("FK_ItemMaster_GroupMajor");

                entity.HasOne(d => d.MiddleGroupNavigation)
                    .WithMany(p => p.ItemMasters)
                    .HasForeignKey(d => d.MiddleGroup)
                    .HasConstraintName("FK_ItemMaster_GroupMiddle");

                entity.HasOne(d => d.MinorGroupNavigation)
                    .WithMany(p => p.ItemMasters)
                    .HasForeignKey(d => d.MinorGroup)
                    .HasConstraintName("FK_ItemMaster_GroupMinor");

                entity.HasOne(d => d.UnitNavigation)
                    .WithMany(p => p.ItemMasters)
                    .HasForeignKey(d => d.Unit)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemMaster_UnitMaster");
            });

            modelBuilder.Entity<ItemMasterDetail>(entity =>
            {
                entity.ToTable("ItemMasterDetails", "Inv");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.CategoryCode).HasMaxLength(100);

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumField1).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.NumField2).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.NumField3).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.NumField4).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Rowguid)
                    .HasColumnName("rowguid")
                    .HasDefaultValueSql("(newsequentialid())");

                entity.Property(e => e.VarField1).HasMaxLength(100);

                entity.Property(e => e.VarField2).HasMaxLength(100);

                entity.Property(e => e.VarField3).HasMaxLength(100);

                entity.Property(e => e.VarField4).HasMaxLength(100);

                entity.Property(e => e.VarField5).HasMaxLength(100);

                entity.Property(e => e.VarField6).HasMaxLength(100);

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemMasterDetails)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ItemMasterDetails_ItemMaster");
            });

            modelBuilder.Entity<ItemMasterImported>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("ItemMasterImported");

                entity.Property(e => e.AvgCost).HasMaxLength(255);

                entity.Property(e => e.BarCode).HasMaxLength(255);

                entity.Property(e => e.BranchId)
                    .HasMaxLength(255)
                    .HasColumnName("BranchID");

                entity.Property(e => e.CashPrice).HasMaxLength(255);

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CostAccountId).HasColumnName("CostAccountID");

                entity.Property(e => e.CreatedDate).HasMaxLength(255);

                entity.Property(e => e.CreatedUserId)
                    .HasMaxLength(255)
                    .HasColumnName("CreatedUserID");

                entity.Property(e => e.CreditPrice).HasMaxLength(255);

                entity.Property(e => e.Id)
                    .HasMaxLength(255)
                    .HasColumnName("ID");

                entity.Property(e => e.InvAccountId).HasColumnName("InvAccountID");

                entity.Property(e => e.InvoicedStock).HasMaxLength(255);

                entity.Property(e => e.ItemCode).HasMaxLength(255);

                entity.Property(e => e.ItemName).HasMaxLength(255);

                entity.Property(e => e.LastCost).HasMaxLength(255);

                entity.Property(e => e.Location).HasMaxLength(255);

                entity.Property(e => e.MajorGroup).HasMaxLength(255);

                entity.Property(e => e.Manufacturer).HasMaxLength(255);

                entity.Property(e => e.MiddleGroup).HasMaxLength(255);

                entity.Property(e => e.MinorGroup).HasMaxLength(255);

                entity.Property(e => e.ModelNo).HasMaxLength(255);

                entity.Property(e => e.ModifiedDate).HasMaxLength(255);

                entity.Property(e => e.ModifiedUserId)
                    .HasMaxLength(255)
                    .HasColumnName("ModifiedUserID");

                entity.Property(e => e.Oemno)
                    .HasMaxLength(255)
                    .HasColumnName("OEMNo");

                entity.Property(e => e.PartNo).HasMaxLength(255);

                entity.Property(e => e.PurchaseAccountId).HasColumnName("PurchaseAccountID");

                entity.Property(e => e.Remarks).HasMaxLength(255);

                entity.Property(e => e.Rol)
                    .HasMaxLength(255)
                    .HasColumnName("ROL");

                entity.Property(e => e.Roq)
                    .HasMaxLength(255)
                    .HasColumnName("ROQ");

                entity.Property(e => e.SalesAccountId).HasColumnName("SalesAccountID");

                entity.Property(e => e.SellingPrice).HasMaxLength(255);

                entity.Property(e => e.Stock).HasMaxLength(255);

                entity.Property(e => e.Unit).HasMaxLength(255);
            });

            modelBuilder.Entity<JobAllocation>(entity =>
            {
                entity.ToTable("JobAllocation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Allocation).HasMaxLength(50);

                entity.Property(e => e.AllocationDate).HasColumnType("datetime");

                entity.Property(e => e.Remarks).HasMaxLength(300);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.Vid).HasColumnName("VID");

                entity.HasOne(d => d.VidNavigation)
                    .WithMany(p => p.JobAllocations)
                    .HasForeignKey(d => d.Vid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_JobAllocation_JobAllocation");
            });

            modelBuilder.Entity<JobDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Jobid).HasColumnName("jobid");

                entity.Property(e => e.LoginTime)
                    .HasColumnType("datetime")
                    .HasColumnName("login_time");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("remarks");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobDetails)
                    .HasForeignKey(d => d.Jobid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobDetails_JobMain");
            });

            modelBuilder.Entity<JobImage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.FileName).HasMaxLength(500);
            });

            modelBuilder.Entity<JobMain>(entity =>
            {
                entity.ToTable("JobMain");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EndTime)
                    .HasColumnType("datetime")
                    .HasColumnName("end_time");

                entity.Property(e => e.JobNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("job_no");

                entity.Property(e => e.Staffid).HasColumnName("staffid");

                entity.Property(e => e.StartTime)
                    .HasColumnType("datetime")
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<JobManager>(entity =>
            {
                entity.ToTable("JobManager");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Enddate).HasColumnType("datetime");

                entity.Property(e => e.JobNo).HasMaxLength(50);

                entity.Property(e => e.JobType).HasMaxLength(50);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.Startdate).HasColumnType("datetime");

                entity.Property(e => e.Vid).HasColumnName("VID");
            });

            modelBuilder.Entity<JobOrder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("JobOrder");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Itemname)
                    .HasMaxLength(50)
                    .HasColumnName("itemname");

                entity.Property(e => e.Qty)
                    .HasMaxLength(10)
                    .IsFixedLength(true);

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.Unit)
                    .HasMaxLength(10)
                    .HasColumnName("unit")
                    .IsFixedLength(true);

                entity.Property(e => e.Vid).HasColumnName("VID");
            });

            modelBuilder.Entity<JobOutSide>(entity =>
            {
                entity.ToTable("JobOutSide");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColourMode).HasMaxLength(50);

                entity.Property(e => e.CustomerCode).HasMaxLength(30);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.Dono).HasColumnName("DONo");

                entity.Property(e => e.FileName).HasMaxLength(50);

                entity.Property(e => e.Item)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.JobOrderNo).HasMaxLength(30);

                entity.Property(e => e.Media).HasMaxLength(50);

                entity.Property(e => e.OrderDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Place).HasMaxLength(50);

                entity.Property(e => e.Program).HasMaxLength(50);

                entity.Property(e => e.ReceiverName).HasMaxLength(50);

                entity.Property(e => e.Remarks).HasMaxLength(100);
            });

            modelBuilder.Entity<JobUser>(entity =>
            {
                entity.ToTable("JobUser");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<LedgerTrialVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LedgerTrialVW");

                entity.Property(e => e.Abbreviation).HasMaxLength(3);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BasicCredit).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.BasicDebit).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.CommonNarration).HasMaxLength(150);

                entity.Property(e => e.Credit).HasColumnType("numeric(19, 4)");

                entity.Property(e => e.Debit).HasColumnType("numeric(19, 4)");

                entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ForeignCredit).HasColumnType("numeric(19, 4)");

                entity.Property(e => e.ForeignDebit).HasColumnType("numeric(19, 4)");

                entity.Property(e => e.MainAccountName).HasMaxLength(100);

                entity.Property(e => e.RefNo).HasMaxLength(20);

                entity.Property(e => e.RowType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Veid).HasColumnName("VEID");

                entity.Property(e => e.Vid).HasColumnName("VID");

                entity.Property(e => e.Vno)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("VNo");

                entity.Property(e => e.Vtype)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VType");
            });

            modelBuilder.Entity<LedgerVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LedgerVW");

                entity.Property(e => e.Abbreviation).HasMaxLength(3);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BasicCredit).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.BasicDebit).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.CommonNarration).HasMaxLength(150);

                entity.Property(e => e.Credit).HasColumnType("numeric(19, 4)");

                entity.Property(e => e.Debit).HasColumnType("numeric(19, 4)");

                entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ForeignCredit).HasColumnType("numeric(19, 4)");

                entity.Property(e => e.ForeignDebit).HasColumnType("numeric(19, 4)");

                entity.Property(e => e.MainAccountName).HasMaxLength(100);

                entity.Property(e => e.RefNo).HasMaxLength(20);

                entity.Property(e => e.RowType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Veid).HasColumnName("VEID");

                entity.Property(e => e.Vid).HasColumnName("VID");

                entity.Property(e => e.Vno)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("VNo");

                entity.Property(e => e.Vtype)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VType");
            });

            modelBuilder.Entity<LedgerVwbillwise>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LedgerVWBillwise");

                entity.Property(e => e.Abbreviation).HasMaxLength(3);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BasicCredit).HasColumnType("money");

                entity.Property(e => e.BasicDebit).HasColumnType("money");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.CommonNarration).HasMaxLength(150);

                entity.Property(e => e.Credit).HasColumnType("money");

                entity.Property(e => e.Debit).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ForeignCredit).HasColumnType("money");

                entity.Property(e => e.ForeignDebit).HasColumnType("money");

                entity.Property(e => e.MainAccountName).HasMaxLength(100);

                entity.Property(e => e.RefNo).HasMaxLength(20);

                entity.Property(e => e.RowType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Veid).HasColumnName("VEID");

                entity.Property(e => e.Vid).HasColumnName("VID");

                entity.Property(e => e.Vno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("VNo");

                entity.Property(e => e.Vtype)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VType");
            });

            modelBuilder.Entity<LedgerVwsimple>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("LedgerVWSimple");

                entity.Property(e => e.Abbreviation).HasMaxLength(3);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BasicCredit).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.BasicDebit).HasColumnType("decimal(38, 6)");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.CommonNarration).HasMaxLength(150);

                entity.Property(e => e.Credit).HasColumnType("numeric(19, 4)");

                entity.Property(e => e.Debit).HasColumnType("numeric(19, 4)");

                entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ForeignCredit).HasColumnType("numeric(19, 4)");

                entity.Property(e => e.ForeignDebit).HasColumnType("numeric(19, 4)");

                entity.Property(e => e.MainAccountName).HasMaxLength(100);

                entity.Property(e => e.RefNo).HasMaxLength(20);

                entity.Property(e => e.RowType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Veid).HasColumnName("VEID");

                entity.Property(e => e.Vid).HasColumnName("VID");

                entity.Property(e => e.Vno)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("VNo");

                entity.Property(e => e.Vtype)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VType");
            });

            modelBuilder.Entity<Link>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Link");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SiteAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Madeena>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("madeena");

                entity.Property(e => e.Africa).HasMaxLength(50);

                entity.Property(e => e.AvgCost).HasColumnName("Avg Cost");

                entity.Property(e => e.Balance2).HasColumnName("Balance 2");

                entity.Property(e => e.Branch).HasMaxLength(25);

                entity.Property(e => e.Category).HasMaxLength(20);

                entity.Property(e => e.Division).HasMaxLength(100);

                entity.Property(e => e.French).HasMaxLength(50);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(50)
                    .HasColumnName("Item Code");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(50)
                    .HasColumnName("Item Name");

                entity.Property(e => e.Location).HasMaxLength(20);

                entity.Property(e => e.Mdate)
                    .HasColumnType("datetime")
                    .HasColumnName("MDate");

                entity.Property(e => e.Oem)
                    .HasMaxLength(50)
                    .HasColumnName("oem");

                entity.Property(e => e.PartNo)
                    .HasMaxLength(100)
                    .HasColumnName("Part No");

                entity.Property(e => e.ReOrderLevel).HasColumnName("ReOrder Level");

                entity.Property(e => e.Remarks).HasMaxLength(50);

                entity.Property(e => e.SalePrice).HasColumnName("Sale Price");

                entity.Property(e => e.Size).HasMaxLength(50);

                entity.Property(e => e.SizeTwo).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(20);

                entity.Property(e => e.Unit2)
                    .HasMaxLength(20)
                    .HasColumnName("Unit 2");

                entity.Property(e => e.UnitCost).HasColumnName("Unit Cost");

                entity.Property(e => e.User).HasMaxLength(20);

                entity.Property(e => e.Weight).HasMaxLength(50);
            });

            modelBuilder.Entity<MastDesignation>(entity =>
            {
                entity.ToTable("MastDesignation");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MasterMisc>(entity =>
            {
                entity.HasKey(e => new { e.Source, e.Description });

                entity.ToTable("MasterMisc");

                entity.HasIndex(e => e.Id, "IX_MasterMisc")
                    .IsUnique();

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Vdefault).HasColumnName("VDefault");
            });

            modelBuilder.Entity<MgntJobMaster>(entity =>
            {
                entity.ToTable("MgntJobMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdvanceAmount).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.Amount).HasColumnType("decimal(15, 2)");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MgntJobtran>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceNo)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.JobMastId).HasColumnName("JobMastID");

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.JobMast)
                    .WithMany(p => p.MgntJobtrans)
                    .HasForeignKey(d => d.JobMastId)
                    .HasConstraintName("FK_MgntJobtrans_MgntJobMaster");
            });

            modelBuilder.Entity<MgntSponsorMast>(entity =>
            {
                entity.ToTable("MgntSponsorMast");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.DocNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExpDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IssueDate).HasColumnType("smalldatetime");

                entity.Property(e => e.IssuePlace)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeId).HasColumnName("TypeID");
            });

            modelBuilder.Entity<NumberingTran>(entity =>
            {
                entity.ToTable("NumberingTran");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Editable).HasDefaultValueSql("((0))");

                entity.Property(e => e.MaximumDegits).HasDefaultValueSql("((4))");

                entity.Property(e => e.Prefillwithzero).HasDefaultValueSql("((1))");

                entity.Property(e => e.Prefix).HasDefaultValueSql("((3))");

                entity.Property(e => e.PrefixValue).HasMaxLength(5);

                entity.Property(e => e.Renewedby).HasDefaultValueSql("((0))");

                entity.Property(e => e.StartingNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.Suffix).HasDefaultValueSql("((0))");

                entity.Property(e => e.SuffixValue).HasMaxLength(5);

                entity.HasOne(d => d.PrefixNavigation)
                    .WithMany(p => p.NumberingTranPrefixNavigations)
                    .HasForeignKey(d => d.Prefix)
                    .HasConstraintName("FK_MasterNumbering_MasterPrefix");

                entity.HasOne(d => d.RenewedbyNavigation)
                    .WithMany(p => p.NumberingTrans)
                    .HasForeignKey(d => d.Renewedby)
                    .HasConstraintName("FK_MasterNumbering_MasterPeriods");

                entity.HasOne(d => d.SuffixNavigation)
                    .WithMany(p => p.NumberingTranSuffixNavigations)
                    .HasForeignKey(d => d.Suffix)
                    .HasConstraintName("FK_NumberingTran_FormatMast");
            });

            modelBuilder.Entity<OldAccount>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AccountCode).HasMaxLength(255);

                entity.Property(e => e.AccountName).HasMaxLength(255);
            });

            modelBuilder.Entity<OpeningGroupVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("OpeningGroupVW");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.OpCredit).HasColumnType("money");

                entity.Property(e => e.OpDebit).HasColumnType("money");
            });

            modelBuilder.Entity<OrderCustomer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("OrderCustomer");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.CustCode).HasMaxLength(50);

                entity.Property(e => e.Customername).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .HasColumnName("phone");
            });

            modelBuilder.Entity<Outward>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Outward");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Qty).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Tdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("TDate");

                entity.Property(e => e.TranId).HasColumnName("TranID");
            });

            modelBuilder.Entity<Pajoproof>(entity =>
            {
                entity.ToTable("PAJOProof");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Proof1).HasMaxLength(50);

                entity.Property(e => e.Proof1Date).HasColumnType("datetime");

                entity.Property(e => e.Proof2).HasMaxLength(50);

                entity.Property(e => e.Proof2Date).HasColumnType("datetime");

                entity.Property(e => e.Proof3).HasMaxLength(50);

                entity.Property(e => e.Proof3Date).HasColumnType("datetime");

                entity.Property(e => e.Proof4).HasMaxLength(50);

                entity.Property(e => e.Proof4Date).HasColumnType("datetime");

                entity.Property(e => e.Proof5).HasMaxLength(50);

                entity.Property(e => e.Proof5Date).HasColumnType("datetime");

                entity.Property(e => e.Vid).HasColumnName("VID");

                entity.HasOne(d => d.VidNavigation)
                    .WithMany(p => p.Pajoproofs)
                    .HasForeignKey(d => d.Vid)
                    .HasConstraintName("FK_PAJOProof_Voucher");
            });

            modelBuilder.Entity<ParentChildtb>(entity =>
            {
                entity.ToTable("ParentChildtb");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount)
                    .HasColumnType("money")
                    .HasComputedColumnSql("([Qty]*[Rate])", false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ParentChildtbs)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_ParentChildtb_ParentTb");
            });

            modelBuilder.Entity<ParentTb>(entity =>
            {
                entity.ToTable("ParentTb");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaymentModeMast>(entity =>
            {
                entity.ToTable("PaymentModeMast");

                entity.HasIndex(e => e.Description, "IX_PaymentModeMast")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.PaymentCategoryId).HasColumnName("PaymentCategoryID");

                entity.Property(e => e.ReceiptCategoryId).HasColumnName("ReceiptCategoryID");

                entity.HasOne(d => d.PaymentCategory)
                    .WithMany(p => p.PaymentModeMastPaymentCategories)
                    .HasForeignKey(d => d.PaymentCategoryId)
                    .HasConstraintName("FK_PaymentModeMast_AccountCategoryMast1");

                entity.HasOne(d => d.ReceiptCategory)
                    .WithMany(p => p.PaymentModeMastReceiptCategories)
                    .HasForeignKey(d => d.ReceiptCategoryId)
                    .HasConstraintName("FK_PaymentModeMast_AccountCategoryMast");

                entity.HasOne(d => d.ReceiptCategoryNavigation)
                    .WithMany(p => p.PaymentModeMasts)
                    .HasForeignKey(d => d.ReceiptCategoryId)
                    .HasConstraintName("FK_PaymentModeMast_SubGroupMast");
            });

            modelBuilder.Entity<Personnel>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Accomadation).HasColumnType("money");

                entity.Property(e => e.ActcoAccountNo)
                    .HasMaxLength(15)
                    .HasColumnName("ACTCO Account No");

                entity.Property(e => e.AdvanceBalance)
                    .HasColumnType("money")
                    .HasColumnName("Advance Balance");

                entity.Property(e => e.Allowance).HasColumnType("money");

                entity.Property(e => e.Approveddate).HasColumnType("datetime");

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(20)
                    .HasColumnName("Bank Account No");

                entity.Property(e => e.BankDetails)
                    .HasMaxLength(100)
                    .HasColumnName("Bank Details");

                entity.Property(e => e.BasicPay)
                    .HasColumnType("money")
                    .HasColumnName("Basic Pay");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(15)
                    .HasColumnName("Blood Group");

                entity.Property(e => e.Branch).HasMaxLength(15);

                entity.Property(e => e.BranchNo).HasColumnName("Branch No");

                entity.Property(e => e.Category).HasMaxLength(20);

                entity.Property(e => e.Child1Details)
                    .HasMaxLength(100)
                    .HasColumnName("Child 1 Details");

                entity.Property(e => e.Child2Details)
                    .HasMaxLength(100)
                    .HasColumnName("Child 2 Details");

                entity.Property(e => e.Child3Details)
                    .HasMaxLength(100)
                    .HasColumnName("Child 3 Details");

                entity.Property(e => e.Committed).HasMaxLength(15);

                entity.Property(e => e.Confirmationdate).HasColumnType("datetime");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("datetime")
                    .HasColumnName("Date of Birth");

                entity.Property(e => e.Designation).HasMaxLength(30);

                entity.Property(e => e.DrivingLicenceExpDate).HasMaxLength(50);

                entity.Property(e => e.DrivingLicenceIssuedate).HasMaxLength(50);

                entity.Property(e => e.DrivingLicenceIssueplace).HasMaxLength(50);

                entity.Property(e => e.DrivingLicenceNo).HasMaxLength(50);

                entity.Property(e => e.DrivingLicenceType).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Emirate).HasMaxLength(50);

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(20)
                    .HasColumnName("Employee Code");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(50)
                    .HasColumnName("Employee Name");

                entity.Property(e => e.EmployeeNo).HasColumnName("Employee No");

                entity.Property(e => e.EndServiceDate).HasColumnType("datetime");

                entity.Property(e => e.EndServiceDetails).HasMaxLength(50);

                entity.Property(e => e.EntryType)
                    .HasMaxLength(10)
                    .HasColumnName("entry type");

                entity.Property(e => e.FathersDetails)
                    .HasMaxLength(100)
                    .HasColumnName("Fathers Details");

                entity.Property(e => e.FinancialRemarks)
                    .HasMaxLength(100)
                    .HasColumnName("Financial Remarks");

                entity.Property(e => e.FoodAllowance)
                    .HasColumnType("money")
                    .HasColumnName("Food Allowance");

                entity.Property(e => e.Grade).HasMaxLength(10);

                entity.Property(e => e.Gratuity).HasColumnType("money");

                entity.Property(e => e.HcexpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("HCExpDate");

                entity.Property(e => e.HcissueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("HCIssueDate");

                entity.Property(e => e.Hcno)
                    .HasMaxLength(50)
                    .HasColumnName("HCNo");

                entity.Property(e => e.HcountryPhone)
                    .HasMaxLength(20)
                    .HasColumnName("HCountryPhone");

                entity.Property(e => e.Hcphone)
                    .HasMaxLength(50)
                    .HasColumnName("HCPhone");

                entity.Property(e => e.HcplaceIssue)
                    .HasMaxLength(50)
                    .HasColumnName("HCPlaceIssue");

                entity.Property(e => e.Incentive).HasColumnType("money");

                entity.Property(e => e.IncrementDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Increment Date");

                entity.Property(e => e.Installment).HasColumnType("money");

                entity.Property(e => e.JoinedDateAfterLeave)
                    .HasColumnType("datetime")
                    .HasColumnName("Joined Date After Leave");

                entity.Property(e => e.JoiningDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Joining Date");

                entity.Property(e => e.LabourStatus)
                    .HasMaxLength(20)
                    .HasColumnName("Labour Status");

                entity.Property(e => e.LcexpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LCExpDate");

                entity.Property(e => e.LcissueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("LCIssueDate");

                entity.Property(e => e.Lcno)
                    .HasMaxLength(50)
                    .HasColumnName("LCNo");

                entity.Property(e => e.LcplaceIssue)
                    .HasMaxLength(50)
                    .HasColumnName("LCPlaceIssue");

                entity.Property(e => e.LeaveAvailable).HasColumnName("Leave Available");

                entity.Property(e => e.LeaveCalculateFrom).HasColumnType("datetime");

                entity.Property(e => e.LeaveFromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Leave From Date");

                entity.Property(e => e.LeaveSalary)
                    .HasMaxLength(50)
                    .HasColumnName("Leave Salary");

                entity.Property(e => e.LeaveToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Leave To Date");

                entity.Property(e => e.LoanBalance)
                    .HasColumnType("money")
                    .HasColumnName("Loan Balance");

                entity.Property(e => e.LoanInstallment)
                    .HasColumnType("money")
                    .HasColumnName("Loan Installment");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(15)
                    .HasColumnName("Marital Status");

                entity.Property(e => e.MinistrySalary)
                    .HasColumnType("money")
                    .HasColumnName("Ministry Salary");

                entity.Property(e => e.MinistryStatus).HasMaxLength(30);

                entity.Property(e => e.Mobile).HasMaxLength(15);

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(15)
                    .HasColumnName("Modified By");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified Date");

                entity.Property(e => e.MothersDetails)
                    .HasMaxLength(100)
                    .HasColumnName("Mothers Details");

                entity.Property(e => e.Mothertongue).HasMaxLength(50);

                entity.Property(e => e.Nationality).HasMaxLength(15);

                entity.Property(e => e.OfficeFileLocation)
                    .HasMaxLength(50)
                    .HasColumnName("office file location");

                entity.Property(e => e.OfficialRemarks)
                    .HasMaxLength(100)
                    .HasColumnName("Official Remarks");

                entity.Property(e => e.OrderNo).HasColumnName("ORDER NO");

                entity.Property(e => e.Overtimerate).HasColumnType("money");

                entity.Property(e => e.PassportExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Passport Expiry Date");

                entity.Property(e => e.PassportIssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Passport Issue Date");

                entity.Property(e => e.PassportIssuePlace)
                    .HasMaxLength(20)
                    .HasColumnName("Passport Issue Place");

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(15)
                    .HasColumnName("Passport No");

                entity.Property(e => e.PassportRemarks)
                    .HasMaxLength(100)
                    .HasColumnName("Passport Remarks");

                entity.Property(e => e.PassportStatus)
                    .HasMaxLength(50)
                    .HasColumnName("passport status");

                entity.Property(e => e.Pbno)
                    .HasMaxLength(50)
                    .HasColumnName("pbno");

                entity.Property(e => e.PermanentAddress)
                    .HasMaxLength(100)
                    .HasColumnName("Permanent Address");

                entity.Property(e => e.PermanentPhoneNo)
                    .HasMaxLength(40)
                    .HasColumnName("Permanent Phone No");

                entity.Property(e => e.PersonalRemarks)
                    .HasMaxLength(100)
                    .HasColumnName("Personal Remarks");

                entity.Property(e => e.PlaceOfBirth)
                    .HasMaxLength(50)
                    .HasColumnName("Place of Birth");

                entity.Property(e => e.Project).HasMaxLength(100);

                entity.Property(e => e.ProjectJoinedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Project Joined Date");

                entity.Property(e => e.Qualification).HasMaxLength(20);

                entity.Property(e => e.QualificationDetails)
                    .HasMaxLength(100)
                    .HasColumnName("Qualification Details");

                entity.Property(e => e.Religion).HasMaxLength(15);

                entity.Property(e => e.ResidenceAddress)
                    .HasMaxLength(100)
                    .HasColumnName("Residence Address");

                entity.Property(e => e.ResidenceAddress1)
                    .HasMaxLength(50)
                    .HasColumnName("Residence Address1");

                entity.Property(e => e.ResidenceAddress2)
                    .HasMaxLength(50)
                    .HasColumnName("Residence Address2");

                entity.Property(e => e.ResidenceAddress3)
                    .HasMaxLength(50)
                    .HasColumnName("Residence Address3");

                entity.Property(e => e.ResidenceFileNo)
                    .HasMaxLength(50)
                    .HasColumnName("residence file no");

                entity.Property(e => e.ResidencePhoneNo)
                    .HasMaxLength(40)
                    .HasColumnName("Residence Phone No");

                entity.Property(e => e.SalaryMode)
                    .HasMaxLength(10)
                    .HasColumnName("Salary Mode");

                entity.Property(e => e.SalaryStatus)
                    .HasMaxLength(15)
                    .HasColumnName("Salary Status");

                entity.Property(e => e.SerialNo)
                    .HasMaxLength(15)
                    .HasColumnName("Serial No");

                entity.Property(e => e.ServiceBenefit)
                    .HasMaxLength(50)
                    .HasColumnName("Service Benefit");

                entity.Property(e => e.ServiceBenefitDate)
                    .HasColumnType("datetime")
                    .HasColumnName("service benefit date");

                entity.Property(e => e.Sex).HasMaxLength(6);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.Ticket).HasMaxLength(50);

                entity.Property(e => e.Transportation).HasColumnType("money");

                entity.Property(e => e.VisaDesignation)
                    .HasMaxLength(30)
                    .HasColumnName("Visa Designation");

                entity.Property(e => e.VisaExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Visa Expiry Date");

                entity.Property(e => e.VisaIssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Visa Issue Date");

                entity.Property(e => e.VisaIssuePlace)
                    .HasMaxLength(20)
                    .HasColumnName("Visa Issue Place");

                entity.Property(e => e.VisaNo)
                    .HasMaxLength(15)
                    .HasColumnName("Visa No");

                entity.Property(e => e.VisaRemarks)
                    .HasMaxLength(100)
                    .HasColumnName("Visa Remarks");

                entity.Property(e => e.VisaType).HasMaxLength(100);

                entity.Property(e => e.WifeHusbandDetails)
                    .HasMaxLength(100)
                    .HasColumnName("Wife/Husband Details");

                entity.Property(e => e.WpExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WP Expiry Date");

                entity.Property(e => e.WpIssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("WP Issue Date");

                entity.Property(e => e.WpIssuePlace)
                    .HasMaxLength(20)
                    .HasColumnName("WP Issue Place");

                entity.Property(e => e.WpNo)
                    .HasMaxLength(15)
                    .HasColumnName("WP No");

                entity.Property(e => e.WpStatus1)
                    .HasMaxLength(50)
                    .HasColumnName("wp status");

                entity.Property(e => e.Wpstatus)
                    .HasMaxLength(50)
                    .HasColumnName("wpstatus");
            });

            modelBuilder.Entity<PersonnelDetailsTran>(entity =>
            {
                entity.HasKey(e => e.Pid);

                entity.ToTable("PersonnelDetailsTran");

                entity.HasIndex(e => e.AccountId, "IX_PersonnelDetailsTran")
                    .IsUnique();

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.AllowCredit).HasDefaultValueSql("((1))");

                entity.Property(e => e.Category).HasMaxLength(20);

                entity.Property(e => e.City).HasMaxLength(30);

                entity.Property(e => e.ConPersonAddress).HasMaxLength(50);

                entity.Property(e => e.ConPersonPhone).HasMaxLength(20);

                entity.Property(e => e.ConPersonRelation).HasMaxLength(30);

                entity.Property(e => e.ContactPerson).HasMaxLength(50);

                entity.Property(e => e.ContractAmount).HasColumnType("money");

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CreditLimit).HasColumnType("money");

                entity.Property(e => e.CustomerGroup).HasMaxLength(50);

                entity.Property(e => e.Department).HasMaxLength(25);

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.EndDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Ernno)
                    .HasMaxLength(50)
                    .HasColumnName("ERNNo");

                entity.Property(e => e.Fax).HasMaxLength(20);

                entity.Property(e => e.Mobile).HasMaxLength(30);

                entity.Property(e => e.Nationality).HasMaxLength(30);

                entity.Property(e => e.Pbno)
                    .HasMaxLength(20)
                    .HasColumnName("PBNo");

                entity.Property(e => e.Phone1).HasMaxLength(20);

                entity.Property(e => e.Phone2).HasMaxLength(20);

                entity.Property(e => e.Price)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.Remarks).HasMaxLength(100);

                entity.Property(e => e.RenewalDate).HasColumnType("smalldatetime");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.StartDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Trnno)
                    .HasMaxLength(50)
                    .HasColumnName("TRNNo");

                entity.Property(e => e.Vatplace)
                    .HasMaxLength(150)
                    .HasColumnName("VATPlace");

                entity.Property(e => e.Website).HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithOne(p => p.PersonnelDetailsTran)
                    .HasForeignKey<PersonnelDetailsTran>(d => d.AccountId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_PersonnelDetailsTran_Accounts");
            });

            modelBuilder.Entity<PortalUser>(entity =>
            {
                entity.HasIndex(e => new { e.UserName, e.Section }, "IX_PortalUsers1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ClassStatus).HasMaxLength(50);

                entity.Property(e => e.Mdate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.Section).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserIp)
                    .HasMaxLength(50)
                    .HasColumnName("UserIP");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.PortalUsers)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_PortalUsers_Accounts1");
            });

            modelBuilder.Entity<ProdExpense>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Pcode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PCode");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.ProdExpenses)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProdExpenses_Accounts");

                entity.HasOne(d => d.PcodeNavigation)
                    .WithMany(p => p.ProdExpenses)
                    .HasForeignKey(d => d.Pcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProdExpenses_ProdMaster");
            });

            modelBuilder.Entity<ProdFinishedItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CostPercentage).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Pcode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PCode");

                entity.Property(e => e.Qty).HasColumnType("decimal(15, 3)");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ProdFinishedItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProdFinishedItems_ItemMaster");

                entity.HasOne(d => d.PcodeNavigation)
                    .WithMany(p => p.ProdFinishedItems)
                    .HasForeignKey(d => d.Pcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProdFinishedItems_ProdMaster");
            });

            modelBuilder.Entity<ProdMaster>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("ProdMaster");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.NumField1).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.NumField2).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.NumField3).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.VarField1).HasMaxLength(100);

                entity.Property(e => e.VarField2).HasMaxLength(100);

                entity.Property(e => e.VarField3).HasMaxLength(100);
            });

            modelBuilder.Entity<ProdMaterial>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Pcode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PCode");

                entity.Property(e => e.Qty).HasColumnType("decimal(15, 3)");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ProdMaterials)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProdMaterials_ItemMaster");

                entity.HasOne(d => d.PcodeNavigation)
                    .WithMany(p => p.ProdMaterials)
                    .HasForeignKey(d => d.Pcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProdMaterials_ProdMaster");
            });

            modelBuilder.Entity<Reminder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Reminder");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RenewalMast>(entity =>
            {
                entity.ToTable("RenewalMast");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.Category, e.BranchId }, "IX_Settings")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Value).HasMaxLength(150);
            });

            modelBuilder.Entity<SheetTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SheetTemp");

                entity.Property(e => e.Null)
                    .HasMaxLength(255)
                    .HasColumnName("NULL");

                entity.Property(e => e.Null1)
                    .HasMaxLength(255)
                    .HasColumnName("NULL1");

                entity.Property(e => e.Null10)
                    .HasMaxLength(255)
                    .HasColumnName("NULL10");

                entity.Property(e => e.Null11)
                    .HasMaxLength(255)
                    .HasColumnName("NULL11");

                entity.Property(e => e.Null12)
                    .HasMaxLength(255)
                    .HasColumnName("NULL12");

                entity.Property(e => e.Null13)
                    .HasMaxLength(255)
                    .HasColumnName("NULL13");

                entity.Property(e => e.Null14)
                    .HasMaxLength(255)
                    .HasColumnName("NULL14");

                entity.Property(e => e.Null15)
                    .HasMaxLength(255)
                    .HasColumnName("NULL15");

                entity.Property(e => e.Null16)
                    .HasMaxLength(255)
                    .HasColumnName("NULL16");

                entity.Property(e => e.Null17)
                    .HasMaxLength(255)
                    .HasColumnName("NULL17");

                entity.Property(e => e.Null18)
                    .HasMaxLength(255)
                    .HasColumnName("NULL18");

                entity.Property(e => e.Null19)
                    .HasMaxLength(255)
                    .HasColumnName("NULL19");

                entity.Property(e => e.Null2)
                    .HasMaxLength(255)
                    .HasColumnName("NULL2");

                entity.Property(e => e.Null20)
                    .HasMaxLength(255)
                    .HasColumnName("NULL20");

                entity.Property(e => e.Null21)
                    .HasMaxLength(255)
                    .HasColumnName("NULL21");

                entity.Property(e => e.Null22)
                    .HasMaxLength(255)
                    .HasColumnName("NULL22");

                entity.Property(e => e.Null3)
                    .HasMaxLength(255)
                    .HasColumnName("NULL3");

                entity.Property(e => e.Null4)
                    .HasMaxLength(255)
                    .HasColumnName("NULL4");

                entity.Property(e => e.Null5)
                    .HasMaxLength(255)
                    .HasColumnName("NULL5");

                entity.Property(e => e.Null6)
                    .HasMaxLength(255)
                    .HasColumnName("NULL6");

                entity.Property(e => e.Null7)
                    .HasMaxLength(255)
                    .HasColumnName("NULL7");

                entity.Property(e => e.Null8)
                    .HasMaxLength(255)
                    .HasColumnName("NULL8");

                entity.Property(e => e.Null9)
                    .HasMaxLength(255)
                    .HasColumnName("NULL9");

                entity.Property(e => e.Sheets)
                    .HasMaxLength(255)
                    .HasColumnName("SHEETS");

                entity.Property(e => e.WoodfreePaper64X90X80GsmWhite)
                    .HasMaxLength(255)
                    .HasColumnName("WOODFREE PAPER 64 X 90 X 80 GSM - WHITE");
            });

            modelBuilder.Entity<ShipViaMast>(entity =>
            {
                entity.ToTable("ShipViaMast");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SponsorMaster>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("SponsorMaster");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("STOCK");

                entity.Property(e => e.AC)
                    .HasMaxLength(255)
                    .HasColumnName("A/C");

                entity.Property(e => e.Category).HasMaxLength(255);

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.F1).HasMaxLength(255);

                entity.Property(e => e.F14).HasMaxLength(255);

                entity.Property(e => e.F2).HasMaxLength(255);

                entity.Property(e => e.F4).HasMaxLength(255);

                entity.Property(e => e.Group).HasMaxLength(255);

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(255)
                    .HasColumnName("Item Code");

                entity.Property(e => e.ItemName)
                    .HasMaxLength(255)
                    .HasColumnName("Item Name");

                entity.Property(e => e.Size)
                    .HasMaxLength(255)
                    .HasColumnName("SIZE");

                entity.Property(e => e.Units).HasMaxLength(255);
            });

            modelBuilder.Entity<SubGroupList>(entity =>
            {
                entity.HasKey(e => new { e.ListId, e.Id });

                entity.ToTable("SubGroupList");

                entity.Property(e => e.ListId).HasColumnName("ListID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.SubGroupLists)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubGroupList_SubGroupMast");

                entity.HasOne(d => d.List)
                    .WithMany(p => p.SubGroupLists)
                    .HasForeignKey(d => d.ListId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubGroupList_AccountGroupMast");
            });

            modelBuilder.Entity<SubGroupListVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SubGroupListVW");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ListId).HasColumnName("ListID");
            });

            modelBuilder.Entity<SubGroupMast>(entity =>
            {
                entity.ToTable("SubGroupMast");

                entity.HasIndex(e => e.Description, "IX_SubGroupMast")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.GroupType)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OrderNo).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SubGroupTran>(entity =>
            {
                entity.ToTable("SubGroupTran");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<SubGroupTranList>(entity =>
            {
                entity.ToTable("SubGroupTranList");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Sgid).HasColumnName("SGID");

                entity.Property(e => e.SubGroupId).HasColumnName("SubGroupID");

                entity.HasOne(d => d.Sg)
                    .WithMany(p => p.SubGroupTranLists)
                    .HasForeignKey(d => d.Sgid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubGroupTranList_SubGroupTran");
            });

            modelBuilder.Entity<Tempve>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempve");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Veid).HasColumnName("veid");
            });

            modelBuilder.Entity<Tempvno>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tempvno");

                entity.Property(e => e.Veno)
                    .HasMaxLength(5)
                    .HasColumnName("veno");

                entity.Property(e => e.Vno)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("vno");
            });

            modelBuilder.Entity<TermsTran>(entity =>
            {
                entity.ToTable("TermsTran");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DueDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("Test");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.BankAccount).HasMaxLength(30);

                entity.Property(e => e.BankName).HasMaxLength(40);

                entity.Property(e => e.BirthDate).HasColumnType("datetime");

                entity.Property(e => e.BloodGroup).HasMaxLength(50);

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.Eosdate)
                    .HasColumnType("datetime")
                    .HasColumnName("EOSDate");

                entity.Property(e => e.Gender).HasMaxLength(20);

                entity.Property(e => e.Grade).HasMaxLength(50);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IncremantDate).HasColumnType("datetime");

                entity.Property(e => e.Isdefault).HasColumnName("ISDefault");

                entity.Property(e => e.JoiningDate).HasColumnType("datetime");

                entity.Property(e => e.LeaveSalary).HasMaxLength(10);

                entity.Property(e => e.MaritalStatus).HasMaxLength(15);

                entity.Property(e => e.Mdate)
                    .HasColumnType("datetime")
                    .HasColumnName("MDate");

                entity.Property(e => e.MinistrySalary).HasColumnType("money");

                entity.Property(e => e.MinistryStatus).HasMaxLength(20);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Muser)
                    .HasMaxLength(50)
                    .HasColumnName("MUser");

                entity.Property(e => e.ProjectTranId).HasColumnName("ProjectTranID");

                entity.Property(e => e.Religion).HasMaxLength(50);

                entity.Property(e => e.RemarksFinancial).HasMaxLength(50);

                entity.Property(e => e.SalaryMode).HasMaxLength(100);

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.UserTrackId).HasColumnName("UserTrackID");

                entity.Property(e => e.VisaDesignation).HasMaxLength(30);

                entity.Property(e => e.VisaType).HasMaxLength(20);

                entity.Property(e => e.Wbranch)
                    .HasMaxLength(20)
                    .HasColumnName("WBranch");
            });

            modelBuilder.Entity<Testtb>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Testtb");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .UseCollation("Arabic_CI_AS");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<TranCostCentre>(entity =>
            {
                entity.ToTable("TranCostCentre", "Inv");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BasicQty).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.CostPhaseId).HasColumnName("CostPhaseID");

                entity.Property(e => e.CostUnitId).HasColumnName("CostUnitID");

                entity.Property(e => e.NumField1).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.NumField2).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.NumField3).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.Qty)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RowType).HasDefaultValueSql("((0))");

                entity.Property(e => e.StockType).HasDefaultValueSql("((0))");

                entity.Property(e => e.TranId).HasColumnName("TranID");

                entity.Property(e => e.VarField1).HasMaxLength(100);

                entity.Property(e => e.VarField2).HasMaxLength(100);

                entity.Property(e => e.VarField3).HasMaxLength(100);

                entity.HasOne(d => d.Cc)
                    .WithMany(p => p.TranCostCentres)
                    .HasForeignKey(d => d.Ccid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TranCostCentre_CostCentre");

                entity.HasOne(d => d.CostPhase)
                    .WithMany(p => p.TranCostCentres)
                    .HasForeignKey(d => d.CostPhaseId)
                    .HasConstraintName("FK_TranCostCentre_CostPhaseMast");

                entity.HasOne(d => d.CostUnit)
                    .WithMany(p => p.TranCostCentres)
                    .HasForeignKey(d => d.CostUnitId)
                    .HasConstraintName("FK_TranCostCentre_CostUnitMast");

                entity.HasOne(d => d.Tran)
                    .WithMany(p => p.TranCostCentres)
                    .HasForeignKey(d => d.TranId)
                    .HasConstraintName("FK_TranCostCentre_Transactions");
            });

            modelBuilder.Entity<Transaction>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_InvTransaction")
                    .IsClustered(false);

                entity.ToTable("Transactions", "Inv");

                entity.HasIndex(e => new { e.Vid, e.ItemId }, "IX_InvTransaction");

                entity.HasIndex(e => e.RefId, "IX_Transactions");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Addition).HasColumnType("decimal(15, 8)");

                entity.Property(e => e.Amount).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.AvgCostId).HasColumnName("AvgCostID");

                entity.Property(e => e.BasicQty).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.BatchNo).HasMaxLength(20);

                entity.Property(e => e.BookNo).HasMaxLength(20);

                entity.Property(e => e.Cbm)
                    .HasColumnType("decimal(10, 3)")
                    .HasColumnName("CBM")
                    .HasComment("Cubic Meter");

                entity.Property(e => e.Col1).HasMaxLength(50);

                entity.Property(e => e.Col2).HasMaxLength(50);

                entity.Property(e => e.Col3).HasMaxLength(50);

                entity.Property(e => e.Col4).HasMaxLength(50);

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Copy1Colour).HasMaxLength(50);

                entity.Property(e => e.Copy1Gsm).HasMaxLength(50);

                entity.Property(e => e.Copy1Sheets).HasMaxLength(50);

                entity.Property(e => e.Copy2Colour).HasMaxLength(50);

                entity.Property(e => e.Copy2Gsm).HasMaxLength(50);

                entity.Property(e => e.Copy2Sheets).HasMaxLength(50);

                entity.Property(e => e.Copy3Colour).HasMaxLength(50);

                entity.Property(e => e.Copy3Gsm).HasMaxLength(50);

                entity.Property(e => e.Copy3Sheets).HasMaxLength(50);

                entity.Property(e => e.CrAccountId).HasColumnName("CrAccountID");

                entity.Property(e => e.Discount).HasColumnType("money");

                entity.Property(e => e.DrAccountId).HasColumnName("DrAccountID");

                entity.Property(e => e.Excise).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ExcisePer).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ExpDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Factor).HasColumnType("decimal(7, 3)");

                entity.Property(e => e.Focqty)
                    .HasMaxLength(10)
                    .HasColumnName("FOCQty");

                entity.Property(e => e.ItemId).HasColumnName("ItemID");

                entity.Property(e => e.Material).HasMaxLength(100);

                entity.Property(e => e.MgntId).HasColumnName("MgntID");

                entity.Property(e => e.NumField1).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.NumField2).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.NumField3).HasColumnType("decimal(13, 3)");

                entity.Property(e => e.OrgColour).HasMaxLength(50);

                entity.Property(e => e.OrgGsm).HasMaxLength(50);

                entity.Property(e => e.OrgSheets).HasMaxLength(50);

                entity.Property(e => e.Other).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.PostAccountId).HasColumnName("PostAccountID");

                entity.Property(e => e.Qty).HasMaxLength(10);

                entity.Property(e => e.Rate).HasColumnType("money");

                entity.Property(e => e.RefId).HasColumnName("RefID");

                entity.Property(e => e.SerialNo).HasMaxLength(30);

                entity.Property(e => e.Size).HasMaxLength(50);

                entity.Property(e => e.TempQty)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TempUnit)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Unit).HasMaxLength(10);

                entity.Property(e => e.VarField1).HasMaxLength(100);

                entity.Property(e => e.VarField2).HasMaxLength(100);

                entity.Property(e => e.VarField3).HasMaxLength(100);

                entity.Property(e => e.Vat)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("VAT");

                entity.Property(e => e.Vatper)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("VATPer");

                entity.Property(e => e.VatperItem)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("VATPerItem");

                entity.Property(e => e.Vatpurpose)
                    .HasMaxLength(250)
                    .HasColumnName("VATPurpose");

                entity.Property(e => e.Vatrefundable).HasColumnName("VATRefundable");

                entity.Property(e => e.Vid).HasColumnName("VID");

                entity.Property(e => e.Vrate)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("VRate");

                entity.Property(e => e.Whid).HasColumnName("WHID");

                entity.HasOne(d => d.CrAccount)
                    .WithMany(p => p.TransactionCrAccounts)
                    .HasForeignKey(d => d.CrAccountId)
                    .HasConstraintName("FK_Transactions_Accounts2");

                entity.HasOne(d => d.DrAccount)
                    .WithMany(p => p.TransactionDrAccounts)
                    .HasForeignKey(d => d.DrAccountId)
                    .HasConstraintName("FK_Transactions_Accounts");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_Transactions_ItemMaster");

                entity.HasOne(d => d.PostAccount)
                    .WithMany(p => p.TransactionPostAccounts)
                    .HasForeignKey(d => d.PostAccountId)
                    .HasConstraintName("FK_Transactions_Accounts1");

                entity.HasOne(d => d.Ref)
                    .WithMany(p => p.InverseRef)
                    .HasForeignKey(d => d.RefId)
                    .HasConstraintName("FK_Transactions_Transactions");

                entity.HasOne(d => d.UnitNavigation)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.Unit)
                    .HasConstraintName("FK_Transactions_UnitMaster");

                entity.HasOne(d => d.VidNavigation)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.Vid)
                    .HasConstraintName("FK_Transactions_Voucher");

                entity.HasOne(d => d.Wh)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.Whid)
                    .HasConstraintName("FK_Transactions_WareHouseMaster");
            });

            modelBuilder.Entity<TrialBalanceVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TrialBalanceVW");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CreditSum).HasColumnType("money");

                entity.Property(e => e.DebitSum).HasColumnType("money");

                entity.Property(e => e.EntryDate).HasColumnType("smalldatetime");
            });

            modelBuilder.Entity<UniqueAccount>(entity =>
            {
                entity.HasKey(e => e.Keyword);

                entity.Property(e => e.Keyword).HasMaxLength(30);

                entity.Property(e => e.AccId).HasColumnName("AccID");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.UniqueAccounts)
                    .HasForeignKey(d => d.AccId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_UniqueAccounts_Accounts");
            });

            modelBuilder.Entity<UniqueAccountsViewVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("UniqueAccountsViewVW");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Isdefault).HasColumnName("ISDefault");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<UnitMaster>(entity =>
            {
                entity.HasKey(e => e.Unit)
                    .HasName("PK_InvUnitMaster");

                entity.ToTable("UnitMaster", "Inv");

                entity.Property(e => e.Unit).HasMaxLength(10);

                entity.Property(e => e.AllowDelete)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BasicUnit).HasMaxLength(10);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Factor)
                    .HasColumnType("decimal(7, 3)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Factor2).HasColumnType("decimal(7, 3)");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.UserName, "IX_Users")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Category)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Section)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.Username).HasMaxLength(255);
            });

            modelBuilder.Entity<UserRight>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.HasIndex(e => new { e.UserId, e.KeywordId }, "IX_UserRights")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessDenied).HasDefaultValueSql("((0))");

                entity.Property(e => e.KeywordId).HasColumnName("KeywordID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Keyword)
                    .WithMany(p => p.UserRights)
                    .HasForeignKey(d => d.KeywordId)
                    .HasConstraintName("FK_UserRights_UserRightsMaster");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRights)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserRights_Users");
            });

            modelBuilder.Entity<UserRightsMaster>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_MasterFormActions")
                    .IsClustered(false);

                entity.ToTable("UserRightsMaster");

                entity.HasIndex(e => e.Keyword, "IX_FormActionTran_1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Keyword)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Module).HasMaxLength(50);
            });

            modelBuilder.Entity<UserRightsTemplate>(entity =>
            {
                entity.ToTable("UserRightsTemplate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.KeywordId).HasColumnName("KeywordID");

                entity.Property(e => e.Template)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Keyword)
                    .WithMany(p => p.UserRightsTemplates)
                    .HasForeignKey(d => d.KeywordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRightsTemplate_MasterFormActions");
            });

            modelBuilder.Entity<UserTrack>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_UserTrackDelete")
                    .IsClustered(false);

                entity.ToTable("UserTrack");

                entity.HasIndex(e => e.ActionDate, "IX_UserTrack")
                    .IsClustered()
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountCode).HasMaxLength(50);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.ActionDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.MachineName).HasMaxLength(20);

                entity.Property(e => e.ModuleName).HasMaxLength(30);

                entity.Property(e => e.NetAmount).HasColumnType("money");

                entity.Property(e => e.OldAmount).HasColumnType("money");

                entity.Property(e => e.Partyname).HasMaxLength(150);

                entity.Property(e => e.Reason)
                    .HasColumnType("ntext")
                    .HasDefaultValueSql("(N'Deleted')");

                entity.Property(e => e.Reference).HasMaxLength(20);

                entity.Property(e => e.Remarks).HasMaxLength(250);

                entity.Property(e => e.RowId).HasColumnName("RowID");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Vdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("VDate");

                entity.Property(e => e.Version).HasMaxLength(50);
            });

            modelBuilder.Entity<UsersBranch>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.UsersBranches)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_UsersBranches_Company");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersBranches)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UsersBranches_Users");
            });

            modelBuilder.Entity<UsersSection>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Section)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.SectionNavigation)
                    .WithMany(p => p.UsersSections)
                    .HasForeignKey(d => d.Section)
                    .HasConstraintName("FK_UsersSections_UsersSectionMaster");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersSections)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UsersSections_Users");
            });

            modelBuilder.Entity<UsersSectionMaster>(entity =>
            {
                entity.HasKey(e => e.Section);

                entity.ToTable("UsersSectionMaster");

                entity.Property(e => e.Section)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<VeaccountsVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VEAccountsVW");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Credit).HasColumnType("money");

                entity.Property(e => e.Debit).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Veid).HasColumnName("VEID");

                entity.Property(e => e.Vid).HasColumnName("VID");
            });

            modelBuilder.Entity<VentryAccount>(entity =>
            {
                entity.ToTable("VEntryAccounts");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Credit).HasColumnType("money");

                entity.Property(e => e.Debit).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Veid).HasColumnName("VEID");
            });

            modelBuilder.Entity<VentryCostCentre>(entity =>
            {
                entity.ToTable("VEntryCostCentre");

                entity.HasIndex(e => new { e.Veid, e.Ccid, e.CostPhaseId, e.CostUnitId }, "IX_VEntryJobs")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Ccid).HasColumnName("CCID");

                entity.Property(e => e.CostPhaseId).HasColumnName("CostPhaseID");

                entity.Property(e => e.CostUnitId).HasColumnName("CostUnitID");

                entity.Property(e => e.Credit).HasColumnType("money");

                entity.Property(e => e.Debit).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Veid).HasColumnName("VEID");

                entity.HasOne(d => d.Cc)
                    .WithMany(p => p.VentryCostCentres)
                    .HasForeignKey(d => d.Ccid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VEntryCostCentre_CostCentre");

                entity.HasOne(d => d.CostPhase)
                    .WithMany(p => p.VentryCostCentres)
                    .HasForeignKey(d => d.CostPhaseId)
                    .HasConstraintName("FK_VEntryCostCentre_CostPhaseMast");

                entity.HasOne(d => d.CostUnit)
                    .WithMany(p => p.VentryCostCentres)
                    .HasForeignKey(d => d.CostUnitId)
                    .HasConstraintName("FK_VEntryCostCentre_CostUnitMast");

                entity.HasOne(d => d.Ve)
                    .WithMany(p => p.VentryCostCentres)
                    .HasForeignKey(d => d.Veid)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_VEntryCostCentre_VoucherEntry");
            });

            modelBuilder.Entity<VetypeTran>(entity =>
            {
                entity.ToTable("VETypeTran");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Editable).HasDefaultValueSql("((0))");

                entity.Property(e => e.Vtid).HasColumnName("VTID");

                entity.HasOne(d => d.CreditDefaultNavigation)
                    .WithMany(p => p.VetypeTranCreditDefaultNavigations)
                    .HasForeignKey(d => d.CreditDefault)
                    .HasConstraintName("FK_MasterVEType_MasterSubGroup1");

                entity.HasOne(d => d.CreditListNavigation)
                    .WithMany(p => p.VetypeTranCreditListNavigations)
                    .HasForeignKey(d => d.CreditList)
                    .HasConstraintName("FK_VETypeTran_SubGroupTran1");

                entity.HasOne(d => d.DebitDefaultNavigation)
                    .WithMany(p => p.VetypeTranDebitDefaultNavigations)
                    .HasForeignKey(d => d.DebitDefault)
                    .HasConstraintName("FK_MasterVEType_MasterSubGroup");

                entity.HasOne(d => d.DebitListNavigation)
                    .WithMany(p => p.VetypeTranDebitListNavigations)
                    .HasForeignKey(d => d.DebitList)
                    .HasConstraintName("FK_VETypeTran_SubGroupTran");

                entity.HasOne(d => d.Vt)
                    .WithMany(p => p.VetypeTrans)
                    .HasForeignKey(d => d.Vtid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MasterVEType_MasterVType");
            });

            modelBuilder.Entity<Voucher>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("Voucher");

                entity.HasIndex(e => new { e.Vno, e.Vtype, e.BranchId }, "IX_Voucher")
                    .IsUnique();

                entity.HasIndex(e => e.AccountId, "IX_Voucher_1");

                entity.HasIndex(e => e.StaffId, "IX_Voucher_2");

                entity.HasIndex(e => new { e.Vno, e.Vtype, e.BranchId, e.EffectiveDate }, "IX_Voucher_3")
                    .IsClustered()
                    .HasFillFactor((byte)80);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.CanceledDate).HasColumnType("smalldatetime");

                entity.Property(e => e.CanceledUserId).HasColumnName("CanceledUserID");

                entity.Property(e => e.CommonNarration).HasMaxLength(150);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.Docno)
                    .HasMaxLength(25)
                    .HasColumnName("docno");

                entity.Property(e => e.DueDate).HasColumnType("smalldatetime");

                entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");

                entity.Property(e => e.ExchangeRate).HasColumnType("money");

                entity.Property(e => e.ExciseAmt).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.IsCanceled).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate)
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifiedUserId).HasColumnName("ModifiedUserID");

                entity.Property(e => e.Postingcode)
                    .HasMaxLength(25)
                    .HasColumnName("postingcode");

                entity.Property(e => e.PreparedBy).HasMaxLength(30);

                entity.Property(e => e.RefNo).HasMaxLength(20);

                entity.Property(e => e.Remark).HasMaxLength(500);

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.Property(e => e.SubTotal).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.Tround)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("TRound");

                entity.Property(e => e.UserTrackId).HasColumnName("UserTrackID");

                entity.Property(e => e.Vatamt)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("VATAmt");

                entity.Property(e => e.Vatpaid)
                    .HasColumnType("numeric(18, 2)")
                    .HasColumnName("VATPaid");

                entity.Property(e => e.Vdate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("VDate")
                    .HasDefaultValueSql("(((1)/(1))/(1930))");

                entity.Property(e => e.Vno)
                    .IsRequired()
                    .HasMaxLength(25)
                    .HasColumnName("VNo");

                entity.Property(e => e.VnoInt).HasColumnName("VNoInt");

                entity.Property(e => e.VoucherAgainst).HasMaxLength(100);

                entity.Property(e => e.Vround)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("VRound");

                entity.Property(e => e.Vtype).HasColumnName("VType");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Vouchers)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_Voucher_Accounts");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Vouchers)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Voucher_Company");

                entity.HasOne(d => d.VtypeNavigation)
                    .WithMany(p => p.Vouchers)
                    .HasForeignKey(d => d.Vtype)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Voucher_MasterVType");
            });

            modelBuilder.Entity<VoucherAdditional>(entity =>
            {
                entity.HasKey(e => e.Vid)
                    .HasName("PK_VoucherAdditionals_1");

                entity.Property(e => e.Vid)
                    .ValueGeneratedNever()
                    .HasColumnName("VID");

                entity.Property(e => e.ActivatedDate).HasColumnType("smalldatetime");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.AmountPaid).HasColumnType("money");

                entity.Property(e => e.CostPhaseId).HasColumnName("CostPhaseID");

                entity.Property(e => e.CostPhaseIdto).HasColumnName("CostPhaseIDTo");

                entity.Property(e => e.CostUnitId).HasColumnName("CostUnitID");

                entity.Property(e => e.CostUnitIdto).HasColumnName("CostUnitIDTo");

                entity.Property(e => e.Date2).HasColumnType("datetime");

                entity.Property(e => e.Date3).HasColumnType("datetime");

                entity.Property(e => e.Date4).HasColumnType("datetime");

                entity.Property(e => e.Date5).HasColumnType("datetime");

                entity.Property(e => e.Date6).HasColumnType("datetime");

                entity.Property(e => e.Date7).HasColumnType("datetime");

                entity.Property(e => e.DefaultWhid).HasColumnName("DefaultWHID");

                entity.Property(e => e.DefaultWhidto).HasColumnName("DefaultWHIDTo");

                entity.Property(e => e.Discount).HasColumnType("money");

                entity.Property(e => e.DiscountId).HasColumnName("DiscountID");

                entity.Property(e => e.Emirates).HasMaxLength(100);

                entity.Property(e => e.Fax).HasMaxLength(30);

                entity.Property(e => e.Field13).HasMaxLength(50);

                entity.Property(e => e.Field15).HasMaxLength(100);

                entity.Property(e => e.FooterText).HasColumnType("ntext");

                entity.Property(e => e.FreeZone).HasMaxLength(50);

                entity.Property(e => e.HeaderText).HasColumnType("ntext");

                entity.Property(e => e.Keyword).HasMaxLength(50);

                entity.Property(e => e.Num1).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Num2).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Num3).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PartyName).HasMaxLength(100);

                entity.Property(e => e.Place).HasMaxLength(100);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ProjectIdto).HasColumnName("ProjectIDTo");

                entity.Property(e => e.RefType).HasMaxLength(30);

                entity.Property(e => e.ReferedVid).HasColumnName("ReferedVID");

                entity.Property(e => e.Remarks).HasMaxLength(150);

                entity.Property(e => e.Status).HasMaxLength(30);

                entity.Property(e => e.Taxcode)
                    .HasMaxLength(25)
                    .HasColumnName("TAXCode");

                entity.Property(e => e.Tel).HasMaxLength(30);

                entity.Property(e => e.Trnno)
                    .HasMaxLength(50)
                    .HasColumnName("TRNNo");

                entity.Property(e => e.Type).HasMaxLength(30);

                entity.Property(e => e.Vatpurpose)
                    .HasMaxLength(250)
                    .HasColumnName("VATPurpose");

                entity.Property(e => e.Vattype)
                    .HasMaxLength(100)
                    .HasColumnName("VATType");

                entity.Property(e => e.Vdefault).HasColumnName("VDefault");
            });

            modelBuilder.Entity<VoucherAdditionalTran>(entity =>
            {
                entity.ToTable("VoucherAdditionalTran");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColumnName)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.LinkField).HasMaxLength(30);

                entity.Property(e => e.LinkTable).HasMaxLength(30);

                entity.Property(e => e.Vtid).HasColumnName("VTID");
            });

            modelBuilder.Entity<VoucherAllocation>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("VoucherAllocation");

                entity.HasIndex(e => new { e.Vid, e.Veid }, "IX_VoucherAllocation")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.Veid).HasColumnName("VEID");

                entity.Property(e => e.Vid).HasColumnName("VID");

                entity.HasOne(d => d.VidNavigation)
                    .WithMany(p => p.VoucherAllocations)
                    .HasForeignKey(d => d.Vid)
                    .HasConstraintName("FK_VoucherAllocation_Voucher");

                entity.HasOne(d => d.VoucherEntry)
                    .WithMany(p => p.VoucherAllocations)
                    .HasPrincipalKey(p => new { p.Id, p.AccountId })
                    .HasForeignKey(d => new { d.Veid, d.AccountId })
                    .HasConstraintName("FK_VoucherAllocation_VoucherEntry");
            });

            modelBuilder.Entity<VoucherEntry>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("VoucherEntry");

                entity.HasIndex(e => e.AccountId, "IX_VoucherEntry")
                    .IsClustered()
                    .HasFillFactor((byte)80);

                entity.HasIndex(e => new { e.Id, e.AccountId }, "IX_VoucherEntry_1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Action)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("(N'C')")
                    .HasComment("1-Active,2-Updated,3-Canceled,4-Deleted");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Credit).HasColumnType("money");

                entity.Property(e => e.Debit).HasColumnType("money");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Docsubno)
                    .HasMaxLength(25)
                    .HasColumnName("docsubno");

                entity.Property(e => e.ExchangeRate).HasColumnType("money");

                entity.Property(e => e.InvDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InvNo).HasMaxLength(25);

                entity.Property(e => e.Postingsubcode)
                    .HasMaxLength(25)
                    .HasColumnName("postingsubcode");

                entity.Property(e => e.Reconciled).HasDefaultValueSql("((0))");

                entity.Property(e => e.ReconciledDate).HasColumnType("smalldatetime");

                entity.Property(e => e.RefId).HasColumnName("RefID");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.RowType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.SupName).HasMaxLength(100);

                entity.Property(e => e.TaxCode).HasMaxLength(50);

                entity.Property(e => e.TranType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(N'Normal')");

                entity.Property(e => e.Trnno)
                    .HasMaxLength(25)
                    .HasColumnName("TRNNo");

                entity.Property(e => e.UserTrackId).HasColumnName("UserTrackID");

                entity.Property(e => e.Vat)
                    .HasColumnType("money")
                    .HasColumnName("VAT");

                entity.Property(e => e.Vid).HasColumnName("VID");

                entity.Property(e => e.VisibleonPrint).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.VoucherEntries)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VoucherEntry_Accounts1");

                entity.HasOne(d => d.Ref)
                    .WithMany(p => p.InverseRef)
                    .HasForeignKey(d => d.RefId)
                    .HasConstraintName("FK_VoucherEntry_VoucherEntry");

                entity.HasOne(d => d.VidNavigation)
                    .WithMany(p => p.VoucherEntries)
                    .HasForeignKey(d => d.Vid)
                    .HasConstraintName("FK_VoucherEntry_Voucher");
            });

            modelBuilder.Entity<VoucherEntryVw>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VoucherEntryVW");

                entity.Property(e => e.AccountCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.AccountHead)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.AccountName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Action).HasMaxLength(1);

                entity.Property(e => e.BankId).HasColumnName("BankID");

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.Card).HasMaxLength(30);

                entity.Property(e => e.ChequeId).HasColumnName("ChequeID");

                entity.Property(e => e.ChequeNo).HasMaxLength(10);

                entity.Property(e => e.Commission).HasColumnType("money");

                entity.Property(e => e.Credit).HasColumnType("money");

                entity.Property(e => e.Date).HasColumnType("smalldatetime");

                entity.Property(e => e.Debit).HasColumnType("money");

                entity.Property(e => e.DepositTo)
                    .HasMaxLength(100)
                    .HasColumnName("Deposit_To");

                entity.Property(e => e.Description).HasMaxLength(150);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InvDate).HasColumnType("smalldatetime");

                entity.Property(e => e.InvNo).HasMaxLength(25);

                entity.Property(e => e.PartyId).HasColumnName("PartyID");

                entity.Property(e => e.ReconciledDate).HasColumnType("smalldatetime");

                entity.Property(e => e.RefId).HasColumnName("RefID");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.RowType)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Status).HasMaxLength(20);

                entity.Property(e => e.SupName).HasMaxLength(100);

                entity.Property(e => e.TranType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Trnno)
                    .HasMaxLength(25)
                    .HasColumnName("TRNNo");

                entity.Property(e => e.UserTrackId).HasColumnName("UserTrackID");

                entity.Property(e => e.Vat)
                    .HasColumnType("money")
                    .HasColumnName("VAT");

                entity.Property(e => e.Vid).HasColumnName("VID");

                entity.Property(e => e.Vtype).HasColumnName("VType");
            });

            modelBuilder.Entity<VoucherStatus>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("VoucherStatus");

                entity.HasIndex(e => new { e.Vid, e.Id }, "IX_VoucherStatus")
                    .IsClustered();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StatusDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubStatus).HasMaxLength(50);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Vid).HasColumnName("VID");

                entity.HasOne(d => d.VidNavigation)
                    .WithMany(p => p.VoucherStatuses)
                    .HasForeignKey(d => d.Vid)
                    .HasConstraintName("FK_VoucherStatus_Voucher");
            });

            modelBuilder.Entity<VpajoProof>(entity =>
            {
                entity.ToTable("VPajoProof");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.Property(e => e.Vid).HasColumnName("VID");

                entity.HasOne(d => d.VidNavigation)
                    .WithMany(p => p.VpajoProofs)
                    .HasForeignKey(d => d.Vid)
                    .HasConstraintName("FK_VPajoProof_VPajoProof");
            });

            modelBuilder.Entity<VtypeMast>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .IsClustered(false);

                entity.ToTable("VTypeMast");

                entity.HasIndex(e => e.Description, "IX_VTypeMast")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<VtypeTran>(entity =>
            {
                entity.ToTable("VTypeTran");

                entity.HasIndex(e => e.Vtype, "IX_VTypeTran")
                    .IsUnique();

                entity.HasIndex(e => e.Abbreviation, "IX_VTypeTran_1")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abbreviation).HasMaxLength(3);

                entity.Property(e => e.ArabicName).HasMaxLength(50);

                entity.Property(e => e.AutoPosting).HasComment("Posting Auto/Manual");

                entity.Property(e => e.CcstockType).HasColumnName("CCStockType");

                entity.Property(e => e.CctrowType).HasColumnName("CCTRowType");

                entity.Property(e => e.DocumentType)
                    .HasDefaultValueSql("((1))")
                    .HasComment("This voucher is Bill or voucher");

                entity.Property(e => e.EntryMode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasDefaultValueSql("(N'Voucher Entry')");

                entity.Property(e => e.ImportSource).HasMaxLength(50);

                entity.Property(e => e.InvoiceType).HasComment("1 for Inward -1 for out ward");

                entity.Property(e => e.MainRowType)
                    .HasMaxLength(2)
                    .HasComment("Dr for Debit and Cr for Credit");

                entity.Property(e => e.MustTally)
                    .IsRequired()
                    .HasDefaultValueSql("((1))")
                    .HasComment("Option for Debit and Credit must be equal");

                entity.Property(e => e.PrintAfterSave).HasComment("Enable Auto Print after Save");

                entity.Property(e => e.PrintTitle)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.RowType).HasComment("1 for Inward -1 for out ward");

                entity.Property(e => e.ShowCheques).HasComment("Cheques or Not Cheques");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Vtype)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("VType");

                entity.HasOne(d => d.BankAccountNavigation)
                    .WithMany(p => p.VtypeTranBankAccountNavigations)
                    .HasForeignKey(d => d.BankAccount)
                    .HasConstraintName("FK_VTypeTran_Accounts2");

                entity.HasOne(d => d.BasicTypeNavigation)
                    .WithMany(p => p.VtypeTrans)
                    .HasForeignKey(d => d.BasicType)
                    .HasConstraintName("FK_VTypeTran_VTypeMast");

                entity.HasOne(d => d.CardAccountNavigation)
                    .WithMany(p => p.VtypeTranCardAccountNavigations)
                    .HasForeignKey(d => d.CardAccount)
                    .HasConstraintName("FK_VTypeTran_Accounts1");

                entity.HasOne(d => d.CashAccountNavigation)
                    .WithMany(p => p.VtypeTranCashAccountNavigations)
                    .HasForeignKey(d => d.CashAccount)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_VTypeTran_Accounts");

                entity.HasOne(d => d.DocumentTypeNavigation)
                    .WithMany(p => p.VtypeTrans)
                    .HasForeignKey(d => d.DocumentType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VTypeTran_DocumentTypeMast");

                entity.HasOne(d => d.EntryModeNavigation)
                    .WithMany(p => p.VtypeTrans)
                    .HasForeignKey(d => d.EntryMode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VTypeTran_EntryModeMast");

                entity.HasOne(d => d.NumberingNavigation)
                    .WithMany(p => p.VtypeTrans)
                    .HasForeignKey(d => d.Numbering)
                    .HasConstraintName("FK_VTypeTran_NumberingTran");
            });

            modelBuilder.Entity<WareHouseMaster>(entity =>
            {
                entity.ToTable("WareHouseMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Whcode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("WHCODE");
            });

            modelBuilder.Entity<WarehouseBranch>(entity =>
            {
                entity.ToTable("WarehouseBranch");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.Whid).HasColumnName("WHID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.WarehouseBranches)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WarehouseBranch_Company");

                entity.HasOne(d => d.Wh)
                    .WithMany(p => p.WarehouseBranches)
                    .HasForeignKey(d => d.Whid)
                    .HasConstraintName("FK_WarehouseBranch_WareHouseMaster");
            });

            modelBuilder.Entity<WsBodyCheck>(entity =>
            {
                entity.ToTable("WS_BodyCheck");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Airfilter)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Efilter)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Eoil)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Fbrake)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Fdrum)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ffilter)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Ffump)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Gfilter)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Goil)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PlateNo)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Rbrake)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Rdrum)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WsImage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.ComplaintId).HasColumnName("ComplaintID");

                entity.Property(e => e.Imagename)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("imagename");

                entity.Property(e => e.VoucherId).HasColumnName("VoucherID");
            });

            modelBuilder.Entity<WsJobDetailsApp>(entity =>
            {
                entity.ToTable("WS_JobDetailsApp");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aed).HasMaxLength(100);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Idjob).HasColumnName("idjob");
            });

            modelBuilder.Entity<WsJobMaster>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.JobId })
                    .HasName("PK_JobMaster");

                entity.ToTable("WS_JobMaster");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Advisor).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.JobModel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlateNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rdate)
                    .HasColumnType("datetime")
                    .HasColumnName("RDate");

                entity.Property(e => e.RoadTestBy).HasMaxLength(50);

                entity.Property(e => e.Rtime)
                    .HasColumnType("datetime")
                    .HasColumnName("RTime");

                entity.Property(e => e.TestInTime).HasColumnType("datetime");

                entity.Property(e => e.TestOutTime).HasColumnType("datetime");

                entity.Property(e => e.Time).HasColumnType("datetime");
            });

            modelBuilder.Entity<WsRandomUrl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("WS_RandomURL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ShortUrl)
                    .HasMaxLength(50)
                    .HasColumnName("ShortURL");

                entity.Property(e => e.Url).HasColumnName("URL");
            });

            modelBuilder.Entity<WsVehicleCheck>(entity =>
            {
                entity.ToTable("WS_VehicleCheck");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AirFilter)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Efilter)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Eoil)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EOil");

                entity.Property(e => e.Fbrake)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fdrum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FDrum");

                entity.Property(e => e.Ffilter)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FFilter");

                entity.Property(e => e.Ffump)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("FFump");

                entity.Property(e => e.Gfilter)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GFilter");

                entity.Property(e => e.Goil)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GOil");

                entity.Property(e => e.HeatingorAc).HasColumnName("HeatingorAC");

                entity.Property(e => e.PlateNo)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Rbrake)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RBrake");

                entity.Property(e => e.Rdrum)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RDrum");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WsVehicleMaster>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.PlateNo })
                    .HasName("PK_VehicleMaster_1");

                entity.ToTable("WS_VehicleMaster");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.PlateNo).HasMaxLength(50);

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Colour).HasMaxLength(20);

                entity.Property(e => e.Company).HasMaxLength(50);

                entity.Property(e => e.Km)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("KM");

                entity.Property(e => e.Model).HasMaxLength(50);

                entity.Property(e => e.Vim)
                    .HasMaxLength(50)
                    .HasColumnName("VIM");
            });

            modelBuilder.Entity<WsvehicleCheck1>(entity =>
            {
                entity.ToTable("WSVehicleCheck");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.PlateNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WsvehicleCheckMaster>(entity =>
            {
                entity.ToTable("WSVehicleCheckMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Arabic).HasMaxLength(50);

                entity.Property(e => e.Service)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Staff");

                entity.Property(e => e.AccountCode).HasMaxLength(255);

                entity.Property(e => e.AccountName).HasMaxLength(255);

                entity.Property(e => e.Designation).HasMaxLength(255);

                entity.Property(e => e.Mobile).HasMaxLength(255);

                entity.Property(e => e.SlNo)
                    .HasMaxLength(255)
                    .HasColumnName("Sl No");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
