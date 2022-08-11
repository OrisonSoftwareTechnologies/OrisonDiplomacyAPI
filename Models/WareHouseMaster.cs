using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class WareHouseMaster
    {
        public WareHouseMaster()
        {
            Transactions = new HashSet<Transaction>();
            WarehouseBranches = new HashSet<WarehouseBranch>();
        }

        public int Id { get; set; }
        public string Whcode { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<WarehouseBranch> WarehouseBranches { get; set; }
    }
}
