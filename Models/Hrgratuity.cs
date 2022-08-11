using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class Hrgratuity
    {
        public int Id { get; set; }
        public int GrId { get; set; }
        public DateTime? FromDate { get; set; }
        public DateTime? ToDate { get; set; }
        public decimal? Days { get; set; }
        public decimal? GrDays { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public string Gratuity { get; set; }

        public virtual HrgratuityParent Gr { get; set; }
    }
}
