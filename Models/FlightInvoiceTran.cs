using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class FlightInvoiceTran
    {
        public int Id { get; set; }
        public int? SlNo { get; set; }
        public long Vid { get; set; }
        public int InvItemId { get; set; }
        public string Description { get; set; }
        public string Details { get; set; }
        public decimal? Amount { get; set; }
        public int? Ccid { get; set; }

        public virtual CostCentre Cc { get; set; }
        public virtual FlightInvoiceItem InvItem { get; set; }
        public virtual Voucher VidNavigation { get; set; }
    }
}
