using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class HrempPhoto
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public byte[] Photo { get; set; }

        public virtual Account Emp { get; set; }
    }
}
