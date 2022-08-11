using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class GroupDetail
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int ItemId { get; set; }
        public decimal QtyPerUnit { get; set; }

        public virtual ItemMaster Group { get; set; }
        public virtual ItemMaster Item { get; set; }
    }
}
