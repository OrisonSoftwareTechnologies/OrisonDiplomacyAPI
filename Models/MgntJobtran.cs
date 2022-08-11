using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class MgntJobtran
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Description { get; set; }
        public decimal Rate { get; set; }
        public int Quantity { get; set; }
        public decimal Amount { get; set; }
        public string EmployeeName { get; set; }
        public string Status { get; set; }
        public string InvoiceNo { get; set; }
        public int JobMastId { get; set; }

        public virtual MgntJobMaster JobMast { get; set; }
    }
}
