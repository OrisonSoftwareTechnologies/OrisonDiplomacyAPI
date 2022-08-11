using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class Inward
    {
        public int? TranId { get; set; }
        public int? ItemId { get; set; }
        public decimal? Qty { get; set; }
        public DateTime? Tdate { get; set; }
        public decimal? Cost { get; set; }
    }
}
