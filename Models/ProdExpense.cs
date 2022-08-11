using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class ProdExpense
    {
        public int Id { get; set; }
        public string Pcode { get; set; }
        public int AccountId { get; set; }
        public decimal Amount { get; set; }

        public virtual Account Account { get; set; }
        public virtual ProdMaster PcodeNavigation { get; set; }
    }
}
