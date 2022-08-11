using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class Setting
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public int? BranchId { get; set; }
        public string Value { get; set; }
        public bool? AllowDelete { get; set; }
    }
}
