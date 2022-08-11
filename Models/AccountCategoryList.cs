using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class AccountCategoryList
    {
        public int ListId { get; set; }
        public int Id { get; set; }

        public virtual AccountCategoryMast IdNavigation { get; set; }
        public virtual SubGroupMast List { get; set; }
    }
}
