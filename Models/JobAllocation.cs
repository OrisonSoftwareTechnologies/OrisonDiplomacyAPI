using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class JobAllocation
    {
        public int Id { get; set; }
        public long? Vid { get; set; }
        public int? StaffId { get; set; }
        public string Allocation { get; set; }
        public string Remarks { get; set; }
        public DateTime? AllocationDate { get; set; }

        public virtual Voucher VidNavigation { get; set; }
    }
}
