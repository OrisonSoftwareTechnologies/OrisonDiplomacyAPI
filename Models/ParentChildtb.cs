using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class ParentChildtb
    {
        public int Id { get; set; }
        public int? ParentId { get; set; }
        public int? Qty { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }

        public virtual ParentTb Parent { get; set; }
    }
}
