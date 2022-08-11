using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class AgingMonthwise
    {
        public int? StartDay { get; set; }
        public int? EndDay { get; set; }
        public int? Priority { get; set; }
        public string Title { get; set; }
    }
}
