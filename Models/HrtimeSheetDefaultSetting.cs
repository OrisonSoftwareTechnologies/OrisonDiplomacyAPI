using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class HrtimeSheetDefaultSetting
    {
        public int Id { get; set; }
        public string Branch { get; set; }
        public string Project { get; set; }
        public decimal? Th { get; set; }
    }
}
