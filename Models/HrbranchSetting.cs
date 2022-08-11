using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class HrbranchSetting
    {
        public int Id { get; set; }
        public string Branch { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? Pbno { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
    }
}
