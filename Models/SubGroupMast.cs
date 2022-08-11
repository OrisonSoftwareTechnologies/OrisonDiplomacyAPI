using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class SubGroupMast
    {
        public SubGroupMast()
        {
            AccountCategoryLists = new HashSet<AccountCategoryList>();
            Accounts = new HashSet<Account>();
            PaymentModeMasts = new HashSet<PaymentModeMast>();
            SubGroupLists = new HashSet<SubGroupList>();
            VetypeTranCreditDefaultNavigations = new HashSet<VetypeTran>();
            VetypeTranDebitDefaultNavigations = new HashSet<VetypeTran>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int? OrderNo { get; set; }
        public int? DivisionNo { get; set; }
        public string GroupType { get; set; }

        public virtual ICollection<AccountCategoryList> AccountCategoryLists { get; set; }
        public virtual ICollection<Account> Accounts { get; set; }
        public virtual ICollection<PaymentModeMast> PaymentModeMasts { get; set; }
        public virtual ICollection<SubGroupList> SubGroupLists { get; set; }
        public virtual ICollection<VetypeTran> VetypeTranCreditDefaultNavigations { get; set; }
        public virtual ICollection<VetypeTran> VetypeTranDebitDefaultNavigations { get; set; }
    }
}
