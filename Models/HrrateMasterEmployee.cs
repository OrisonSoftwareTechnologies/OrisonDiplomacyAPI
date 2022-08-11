using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class HrrateMasterEmployee
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public int? DesignationId { get; set; }
        public decimal? Rate { get; set; }
    }
}
