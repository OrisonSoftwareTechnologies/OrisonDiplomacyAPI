using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class SubGroupTran
    {
        public SubGroupTran()
        {
            SubGroupTranLists = new HashSet<SubGroupTranList>();
            VetypeTranCreditListNavigations = new HashSet<VetypeTran>();
            VetypeTranDebitListNavigations = new HashSet<VetypeTran>();
        }

        public int Id { get; set; }
        public bool ColumnType { get; set; }

        public virtual ICollection<SubGroupTranList> SubGroupTranLists { get; set; }
        public virtual ICollection<VetypeTran> VetypeTranCreditListNavigations { get; set; }
        public virtual ICollection<VetypeTran> VetypeTranDebitListNavigations { get; set; }
    }
}
