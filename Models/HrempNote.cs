using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class HrempNote
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public DateTime? Date { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public DateTime? Mdate { get; set; }
        public string Muser { get; set; }

        public virtual Account Emp { get; set; }
    }
}
