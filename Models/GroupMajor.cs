using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class GroupMajor
    {
        public GroupMajor()
        {
            ItemMasters = new HashSet<ItemMaster>();
        }

        public int Id { get; set; }
        public string MajorGroup { get; set; }

        public virtual ICollection<ItemMaster> ItemMasters { get; set; }
    }
}
