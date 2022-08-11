using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class GroupMinor
    {
        public GroupMinor()
        {
            ItemMasters = new HashSet<ItemMaster>();
        }

        public int Id { get; set; }
        public string MinorGroup { get; set; }

        public virtual ICollection<ItemMaster> ItemMasters { get; set; }
    }
}
