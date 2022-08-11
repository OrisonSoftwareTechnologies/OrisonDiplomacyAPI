using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class GroupMiddle
    {
        public GroupMiddle()
        {
            ItemMasters = new HashSet<ItemMaster>();
        }

        public int Id { get; set; }
        public string MiddleGroup { get; set; }

        public virtual ICollection<ItemMaster> ItemMasters { get; set; }
    }
}
