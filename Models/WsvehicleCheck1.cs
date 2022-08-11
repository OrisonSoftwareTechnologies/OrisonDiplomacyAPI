using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class WsvehicleCheck1
    {
        public int Id { get; set; }
        public string PlateNo { get; set; }
        public int? JobId { get; set; }
        public int? Description { get; set; }
        public bool? Value { get; set; }
    }
}
