using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class VoucherAllocation
    {
        public int Id { get; set; }
        public long Vid { get; set; }
        public long Veid { get; set; }
        public int? AccountId { get; set; }
        public decimal Amount { get; set; }

        public virtual Voucher VidNavigation { get; set; }
        public virtual VoucherEntry VoucherEntry { get; set; }
    }
}
