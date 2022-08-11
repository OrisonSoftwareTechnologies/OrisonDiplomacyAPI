using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class HrleaveSalary
    {
        public HrleaveSalary()
        {
            HrleaveSalaryTrans = new HashSet<HrleaveSalaryTran>();
        }

        public int Id { get; set; }
        public string Month { get; set; }
        public int Year { get; set; }
        public decimal? Total { get; set; }
        public DateTime? Date { get; set; }
        public string RefNo { get; set; }

        public virtual ICollection<HrleaveSalaryTran> HrleaveSalaryTrans { get; set; }
    }
}
