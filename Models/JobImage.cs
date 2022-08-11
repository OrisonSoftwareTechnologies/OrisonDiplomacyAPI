using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class JobImage
    {
        public int Id { get; set; }
        public long? Vid { get; set; }
        public string Description { get; set; }
        public string FileName { get; set; }
    }
}
