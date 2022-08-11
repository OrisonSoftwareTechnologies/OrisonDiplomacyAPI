using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class GroupMaster
    {
        public GroupMaster()
        {
            InverseParent = new HashSet<GroupMaster>();
        }

        public int Id { get; set; }
        public string GroupName { get; set; }
        public int? ParentId { get; set; }
        public string DisplayName { get; set; }

        public virtual GroupMaster Parent { get; set; }
        public virtual ICollection<GroupMaster> InverseParent { get; set; }
    }
}
