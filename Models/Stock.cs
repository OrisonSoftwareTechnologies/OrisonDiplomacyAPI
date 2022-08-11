using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class Stock
    {
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string ItemCode { get; set; }
        public string F4 { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string ItemName { get; set; }
        public string Units { get; set; }
        public string Category { get; set; }
        public string Group { get; set; }
        public double? Qty { get; set; }
        public double? Rate { get; set; }
        public string AC { get; set; }
        public string F14 { get; set; }
    }
}
