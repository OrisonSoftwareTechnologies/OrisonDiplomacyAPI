using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class TrialBalanceVw
    {
        public DateTime EntryDate { get; set; }
        public int AccountId { get; set; }
        public decimal? DebitSum { get; set; }
        public decimal? CreditSum { get; set; }
    }
}
