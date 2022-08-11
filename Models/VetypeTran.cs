using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class VetypeTran
    {
        public VetypeTran()
        {
            ColumnsVetrans = new HashSet<ColumnsVetran>();
        }

        public int Id { get; set; }
        public int Vtid { get; set; }
        public int? DebitList { get; set; }
        public int? CreditList { get; set; }
        public int? DebitDefault { get; set; }
        public int? CreditDefault { get; set; }
        public bool? Editable { get; set; }

        public virtual SubGroupMast CreditDefaultNavigation { get; set; }
        public virtual SubGroupTran CreditListNavigation { get; set; }
        public virtual SubGroupMast DebitDefaultNavigation { get; set; }
        public virtual SubGroupTran DebitListNavigation { get; set; }
        public virtual VtypeTran Vt { get; set; }
        public virtual ICollection<ColumnsVetran> ColumnsVetrans { get; set; }
    }
}
