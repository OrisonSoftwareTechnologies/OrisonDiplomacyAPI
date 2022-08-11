using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class Image
    {
        public long Id { get; set; }
        public string Type { get; set; }
        public long? ImageId { get; set; }
        public int? PageNo { get; set; }
        public byte[] Picture { get; set; }
    }
}
