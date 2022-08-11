using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class HrinvDeduction
    {
        public int Id { get; set; }
        public int Pid { get; set; }
        public string Description { get; set; }
        public decimal? Amount { get; set; }

        public virtual HrinvContract PidNavigation { get; set; }
    }
}
