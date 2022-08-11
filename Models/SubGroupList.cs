using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class SubGroupList
    {
        public int ListId { get; set; }
        public int Id { get; set; }

        public virtual SubGroupMast IdNavigation { get; set; }
        public virtual AccountGroupMast List { get; set; }
    }
}
