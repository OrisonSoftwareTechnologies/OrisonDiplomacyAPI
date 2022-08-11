using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class HrgratuityParent
    {
        public HrgratuityParent()
        {
            Hrgratuities = new HashSet<Hrgratuity>();
            HrgratuityTrans = new HashSet<HrgratuityTran>();
        }

        public int Id { get; set; }
        public string RefNo { get; set; }
        public int EmpId { get; set; }
        public string Status { get; set; }
        public decimal? IncomeTotal { get; set; }
        public decimal? GrativityTotal { get; set; }
        public decimal? DeductionTotal { get; set; }
        public decimal? GrandTotal { get; set; }
        public decimal? Net { get; set; }
        public DateTime? Date { get; set; }
        public string Remarks { get; set; }
        public DateTime? JoinDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? Vid { get; set; }

        public virtual Account Emp { get; set; }
        public virtual ICollection<Hrgratuity> Hrgratuities { get; set; }
        public virtual ICollection<HrgratuityTran> HrgratuityTrans { get; set; }
    }
}
