using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class HrinvWorkingProgress
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public string Description { get; set; }
        public decimal? Qty { get; set; }
        public decimal? PrevPercentage { get; set; }
        public decimal? CurrPercentage { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Amount { get; set; }

        public virtual HrinvContract PidNavigation { get; set; }
    }
}
