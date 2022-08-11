using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class HrempQualificationImage
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int? PageNo { get; set; }
        public byte[] Picture { get; set; }
        public int? QualifyId { get; set; }

        public virtual HrempQualification Qualify { get; set; }
    }
}
