using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class VoucherStatus
    {
        public long Id { get; set; }
        public long Vid { get; set; }
        public int UserId { get; set; }
        public DateTime StatusDate { get; set; }
        public string Status { get; set; }
        public string SubStatus { get; set; }

        public virtual Voucher VidNavigation { get; set; }
    }
}
