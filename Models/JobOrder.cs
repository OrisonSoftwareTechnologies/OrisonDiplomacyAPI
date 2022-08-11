using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class JobOrder
    {
        public long Id { get; set; }
        public long? Vid { get; set; }
        public short? Itemcode { get; set; }
        public string Itemname { get; set; }
        public string Qty { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }
        public string Unit { get; set; }
    }
}
