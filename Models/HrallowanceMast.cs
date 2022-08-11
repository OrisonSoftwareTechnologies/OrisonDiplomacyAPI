using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class HrallowanceMast
    {
        public HrallowanceMast()
        {
            HrempSalaries = new HashSet<HrempSalary>();
        }

        public int Id { get; set; }
        public string SalaryMode { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int? PriorityNo { get; set; }

        public virtual ICollection<HrempSalary> HrempSalaries { get; set; }
    }
}
