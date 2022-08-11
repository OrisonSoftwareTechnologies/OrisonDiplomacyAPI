using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class ProdFinishedItem
    {
        public int Id { get; set; }
        public string Pcode { get; set; }
        public int ItemId { get; set; }
        public decimal Qty { get; set; }
        public decimal? CostPercentage { get; set; }

        public virtual ItemMaster Item { get; set; }
        public virtual ProdMaster PcodeNavigation { get; set; }
    }
}
