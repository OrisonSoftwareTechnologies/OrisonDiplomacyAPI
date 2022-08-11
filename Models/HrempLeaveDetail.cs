using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class HrempLeaveDetail
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string LeaveType { get; set; }
        public DateTime? JoiningDate { get; set; }
        public string Reason { get; set; }
        public int? Duration { get; set; }
        public int? OpeningBalance { get; set; }
        public DateTime? Mdate { get; set; }
        public string Muser { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public string Remarks { get; set; }

        public virtual Account Emp { get; set; }
    }
}
