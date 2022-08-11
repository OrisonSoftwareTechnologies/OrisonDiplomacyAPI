using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class CompanySetting
    {
        public string Keyword { get; set; }
        public string SubKeyWord { get; set; }
        public string Value { get; set; }
        public bool? Active { get; set; }
        public string Remarks { get; set; }
        public bool? AllowDelete { get; set; }
    }
}
