using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class FlightInvoiceItem
    {
        public FlightInvoiceItem()
        {
            FlightInvoiceTrans = new HashSet<FlightInvoiceTran>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Remark { get; set; }
        public decimal? Amount { get; set; }

        public virtual ICollection<FlightInvoiceTran> FlightInvoiceTrans { get; set; }
    }
}
