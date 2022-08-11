using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class HrleaveSalaryTran
    {
        public int Id { get; set; }
        public int Lsid { get; set; }
        public int EmpId { get; set; }
        public int ProjectId { get; set; }
        public decimal? Amount { get; set; }
        public int? NoOfMonths { get; set; }

        public virtual HrleaveSalary Ls { get; set; }
    }
}
