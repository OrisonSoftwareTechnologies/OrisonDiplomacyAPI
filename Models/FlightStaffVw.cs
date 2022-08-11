using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class FlightStaffVw
    {
        public string AccountCode { get; set; }
        public string AccountName { get; set; }
        public decimal? Rate { get; set; }
        public string AccCategory { get; set; }
        public int? DesgId { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
    }
}
