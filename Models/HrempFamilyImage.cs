﻿using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class HrempFamilyImage
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int? PageNo { get; set; }
        public byte[] Picture { get; set; }
        public int? FamilyId { get; set; }

        public virtual HrempFamily Family { get; set; }
    }
}
