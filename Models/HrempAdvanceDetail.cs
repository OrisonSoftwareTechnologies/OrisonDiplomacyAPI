using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class HrempAdvanceDetail
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public DateTime? Date { get; set; }
        public decimal? Amount { get; set; }
        public int? Aid { get; set; }
        public string Description { get; set; }
        public bool? Active { get; set; }

        public virtual Account Emp { get; set; }
    }
}
