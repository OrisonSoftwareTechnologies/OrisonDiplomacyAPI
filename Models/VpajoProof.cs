using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class VpajoProof
    {
        public long Id { get; set; }
        public long Vid { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public DateTime? Date { get; set; }

        public virtual Voucher VidNavigation { get; set; }
    }
}
