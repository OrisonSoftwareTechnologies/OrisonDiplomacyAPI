using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class ChequesTran
    {
        public long Id { get; set; }
        public long? Vid { get; set; }
        public long? Veid { get; set; }
        public int ChequeId { get; set; }
        public string TranType { get; set; }

        public virtual VoucherEntry Ve { get; set; }
        public virtual Voucher VidNavigation { get; set; }
    }
}
