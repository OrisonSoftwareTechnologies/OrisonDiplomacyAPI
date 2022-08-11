using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class HrtimeSheetConsolidated
    {
        public int Id { get; set; }
        public int? Tid { get; set; }
        public string Project { get; set; }
        public decimal? Days { get; set; }
        public decimal? Ot { get; set; }
        public decimal? Hot { get; set; }
        public decimal? Bonus { get; set; }
        public decimal? Amount { get; set; }

        public virtual HrtimeSheet TidNavigation { get; set; }
    }
}
