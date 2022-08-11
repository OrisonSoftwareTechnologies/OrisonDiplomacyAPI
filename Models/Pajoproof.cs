using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class Pajoproof
    {
        public int Id { get; set; }
        public long Vid { get; set; }
        public string Proof1 { get; set; }
        public DateTime? Proof1Date { get; set; }
        public string Proof2 { get; set; }
        public DateTime? Proof2Date { get; set; }
        public string Proof3 { get; set; }
        public DateTime? Proof3Date { get; set; }
        public string Proof4 { get; set; }
        public DateTime? Proof4Date { get; set; }
        public string Proof5 { get; set; }
        public DateTime? Proof5Date { get; set; }

        public virtual Voucher VidNavigation { get; set; }
    }
}
