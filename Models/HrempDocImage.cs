using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class HrempDocImage
    {
        public int Id { get; set; }
        public int? SlNo { get; set; }
        public string Type { get; set; }
        public int? DocId { get; set; }
        public string FileName { get; set; }
        public string Path { get; set; }
        public string DocType { get; set; }

        public virtual HrempDocument Doc { get; set; }
    }
}
