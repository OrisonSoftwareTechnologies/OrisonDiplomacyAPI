using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class WsImage
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public int ComplaintId { get; set; }
        public int VoucherId { get; set; }
        public string Imagename { get; set; }
    }
}
