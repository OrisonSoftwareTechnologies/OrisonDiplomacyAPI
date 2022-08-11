using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class InvFifoallocation
    {
        public long Id { get; set; }
        public long OutId { get; set; }
        public long InId { get; set; }
        public decimal? Qty { get; set; }
    }
}
