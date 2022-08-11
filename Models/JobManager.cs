using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class JobManager
    {
        public int Id { get; set; }
        public string JobNo { get; set; }
        public int? Vid { get; set; }
        public int? StaffId { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public string JobType { get; set; }
    }
}
