using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class Item
    {
        public double? No { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string Unit { get; set; }
        public string Stock { get; set; }
        public double? Stock1 { get; set; }
        public string Category { get; set; }
        public double? Cost { get; set; }
        public double? TotalCost { get; set; }
        public string SPrice { get; set; }
    }
}
