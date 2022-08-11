using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class CostCentreVw
    {
        public long Id { get; set; }
        public long Veid { get; set; }
        public int Ccid { get; set; }
        public string CostCentre { get; set; }
        public int? CostPhaseId { get; set; }
        public int? CostUnitId { get; set; }
        public string Phase { get; set; }
        public string CostUnit { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public string Description { get; set; }
        public long Vid { get; set; }
    }
}
