using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class HrrateMasterProject
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public int? DesignationId { get; set; }
        public decimal? Crate { get; set; }
        public decimal? Erate { get; set; }
    }
}
