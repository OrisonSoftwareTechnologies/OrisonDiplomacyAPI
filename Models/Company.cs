using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class Company
    {
        public Company()
        {
            Accounts = new HashSet<Account>();
            AvgCosts = new HashSet<AvgCost>();
            HrcompDocuments = new HashSet<HrcompDocument>();
            UsersBranches = new HashSet<UsersBranch>();
            Vouchers = new HashSet<Voucher>();
            WarehouseBranches = new HashSet<WarehouseBranch>();
        }

        public int Id { get; set; }
        public int CompanyType { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string BranchName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Fax { get; set; }
        public DateTime EntryFrom { get; set; }
        public string LetterHead { get; set; }
        public bool? AllowDelete { get; set; }
        public string Currency { get; set; }
        public string Trnno { get; set; }
        public string Ernno { get; set; }
        public string Vatplace { get; set; }

        public virtual CompanyTypeMast CompanyTypeNavigation { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<AvgCost> AvgCosts { get; set; }
        public virtual ICollection<HrcompDocument> HrcompDocuments { get; set; }
        public virtual ICollection<UsersBranch> UsersBranches { get; set; }
        public virtual ICollection<Voucher> Vouchers { get; set; }
        public virtual ICollection<WarehouseBranch> WarehouseBranches { get; set; }
    }
}
