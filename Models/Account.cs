using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class Account
    {
        public Account()
        {
            AccountsListUsers = new HashSet<AccountsListUser>();
            AccountsLists = new HashSet<AccountsList>();
            AdditionalChargeCrAccounts = new HashSet<AdditionalCharge>();
            AdditionalChargeDrAccounts = new HashSet<AdditionalCharge>();
            ChequeBanks = new HashSet<Cheque>();
            ChequeParties = new HashSet<Cheque>();
            CostCentreDetailClients = new HashSet<CostCentreDetail>();
            CostCentreDetailSuppliers = new HashSet<CostCentreDetail>();
            CustomerStatuses = new HashSet<CustomerStatus>();
            DynamicAccounts = new HashSet<DynamicAccount>();
            FlightChartingDetails = new HashSet<FlightChartingDetail>();
            FlightChartings = new HashSet<FlightCharting>();
            GroupParents = new HashSet<GroupParent>();
            HrempAdvanceDetails = new HashSet<HrempAdvanceDetail>();
            HrempDocuments = new HashSet<HrempDocument>();
            HrempExperiences = new HashSet<HrempExperience>();
            HrempFamilies = new HashSet<HrempFamily>();
            HrempLeaveDetails = new HashSet<HrempLeaveDetail>();
            HrempNotes = new HashSet<HrempNote>();
            HrempPhotos = new HashSet<HrempPhoto>();
            HrempProjectTrans = new HashSet<HrempProjectTran>();
            HrempQualifications = new HashSet<HrempQualification>();
            HrempSalaries = new HashSet<HrempSalary>();
            HrempWages = new HashSet<HrempWage>();
            HrtimeSheets = new HashSet<HrtimeSheet>();
            PortalUsers = new HashSet<PortalUser>();
            ProdExpenses = new HashSet<ProdExpense>();
            TransactionCrAccounts = new HashSet<Transaction>();
            TransactionDrAccounts = new HashSet<Transaction>();
            TransactionPostAccounts = new HashSet<Transaction>();
            UniqueAccounts = new HashSet<UniqueAccount>();
            VoucherEntries = new HashSet<VoucherEntry>();
            Vouchers = new HashSet<Voucher>();
            VtypeTranBankAccountNavigations = new HashSet<VtypeTran>();
            VtypeTranCardAccountNavigations = new HashSet<VtypeTran>();
            VtypeTranCashAccountNavigations = new HashSet<VtypeTran>();
        }

        public int Id { get; set; }
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public int? Parent { get; set; }
        public int ParentLevel { get; set; }
        public bool? VoucherEntry { get; set; }
        public bool FinalAccount { get; set; }
        public int AccountGroup { get; set; }
        public int? SubGroup { get; set; }
        public int? AccCategory { get; set; }
        public bool? ShowChild { get; set; }
        public bool? Isdefault { get; set; }
        public bool? AllowEntry { get; set; }
        public bool InActive { get; set; }
        public bool? Editable { get; set; }
        public long? UserTrackId { get; set; }
        public int? Currency { get; set; }
        public int? BranchId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int? CreatedUser { get; set; }
        public int? ModifiedUser { get; set; }
        public int? AorderNo { get; set; }
        public int? Ccid { get; set; }
        public bool? InVisible { get; set; }
        public decimal? SortField { get; set; }
        public bool? ShowRow { get; set; }

        public virtual AccountCategoryMast AccCategoryNavigation { get; set; }
        public virtual AccountGroupMast AccountGroupNavigation { get; set; }
        public virtual Company Branch { get; set; }
        public virtual SubGroupMast SubGroupNavigation { get; set; }
        public virtual Hremployee Hremployee { get; set; }
        public virtual HremployeeBackup HremployeeBackup { get; set; }
        public virtual HrgratuityParent HrgratuityParent { get; set; }
        public virtual PersonnelDetailsTran PersonnelDetailsTran { get; set; }
        public virtual ICollection<AccountsListUser> AccountsListUsers { get; set; }
        public virtual ICollection<AccountsList> AccountsLists { get; set; }
        public virtual ICollection<AdditionalCharge> AdditionalChargeCrAccounts { get; set; }
        public virtual ICollection<AdditionalCharge> AdditionalChargeDrAccounts { get; set; }
        public virtual ICollection<Cheque> ChequeBanks { get; set; }
        public virtual ICollection<Cheque> ChequeParties { get; set; }
        public virtual ICollection<CostCentreDetail> CostCentreDetailClients { get; set; }
        public virtual ICollection<CostCentreDetail> CostCentreDetailSuppliers { get; set; }
        public virtual ICollection<CustomerStatus> CustomerStatuses { get; set; }
        public virtual ICollection<DynamicAccount> DynamicAccounts { get; set; }
        public virtual ICollection<FlightChartingDetail> FlightChartingDetails { get; set; }
        public virtual ICollection<FlightCharting> FlightChartings { get; set; }
        public virtual ICollection<GroupParent> GroupParents { get; set; }
        public virtual ICollection<HrempAdvanceDetail> HrempAdvanceDetails { get; set; }
        public virtual ICollection<HrempDocument> HrempDocuments { get; set; }
        public virtual ICollection<HrempExperience> HrempExperiences { get; set; }
        public virtual ICollection<HrempFamily> HrempFamilies { get; set; }
        public virtual ICollection<HrempLeaveDetail> HrempLeaveDetails { get; set; }
        public virtual ICollection<HrempNote> HrempNotes { get; set; }
        public virtual ICollection<HrempPhoto> HrempPhotos { get; set; }
        public virtual ICollection<HrempProjectTran> HrempProjectTrans { get; set; }
        public virtual ICollection<HrempQualification> HrempQualifications { get; set; }
        public virtual ICollection<HrempSalary> HrempSalaries { get; set; }
        public virtual ICollection<HrempWage> HrempWages { get; set; }
        public virtual ICollection<HrtimeSheet> HrtimeSheets { get; set; }
        public virtual ICollection<PortalUser> PortalUsers { get; set; }
        public virtual ICollection<ProdExpense> ProdExpenses { get; set; }
        public virtual ICollection<Transaction> TransactionCrAccounts { get; set; }
        public virtual ICollection<Transaction> TransactionDrAccounts { get; set; }
        public virtual ICollection<Transaction> TransactionPostAccounts { get; set; }
        public virtual ICollection<UniqueAccount> UniqueAccounts { get; set; }
        public virtual ICollection<VoucherEntry> VoucherEntries { get; set; }
        public virtual ICollection<Voucher> Vouchers { get; set; }
        public virtual ICollection<VtypeTran> VtypeTranBankAccountNavigations { get; set; }
        public virtual ICollection<VtypeTran> VtypeTranCardAccountNavigations { get; set; }
        public virtual ICollection<VtypeTran> VtypeTranCashAccountNavigations { get; set; }
    }
}
