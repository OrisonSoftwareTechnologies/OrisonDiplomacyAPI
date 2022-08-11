using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class InvJoborderItem
    {
        public int Reference { get; set; }
        public string SlNo { get; set; }
        public string Description { get; set; }
        public int? Books { get; set; }
        public string Unit { get; set; }
        public string Copies { get; set; }
        public string SerialNo { get; set; }
        public string BookNo { get; set; }
        public string Size { get; set; }
        public string ColourofInk { get; set; }
        public string Gum { get; set; }
        public string ItemId { get; set; }
        public double? Rate { get; set; }
        public decimal? Total { get; set; }
    }
}
