using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class MgntJobMaster
    {
        public MgntJobMaster()
        {
            MgntJobtrans = new HashSet<MgntJobtran>();
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? DueDate { get; set; }
        public string Status { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public decimal? AdvanceAmount { get; set; }

        public virtual ICollection<MgntJobtran> MgntJobtrans { get; set; }
    }
}
