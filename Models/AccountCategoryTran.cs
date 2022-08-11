using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class AccountCategoryTran
    {
        public int Id { get; set; }
        public int Vid { get; set; }
        public int CategoryId { get; set; }

        public virtual AccountCategoryMast Category { get; set; }
    }
}
