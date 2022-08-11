using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class UnitMaster
    {
        public UnitMaster()
        {
            ItemMasters = new HashSet<ItemMaster>();
            Transactions = new HashSet<Transaction>();
        }

        public string Unit { get; set; }
        public string Description { get; set; }
        public decimal Factor { get; set; }
        public bool IsComplex { get; set; }
        public string BasicUnit { get; set; }
        public bool? AllowDelete { get; set; }
        public decimal? Factor2 { get; set; }

        public virtual ICollection<ItemMaster> ItemMasters { get; set; }
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}
