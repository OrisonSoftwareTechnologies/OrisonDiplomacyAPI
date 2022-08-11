using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class MgntSponsorMast
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Name { get; set; }
        public string PassportNo { get; set; }
        public string Nationality { get; set; }
        public string MobileNo { get; set; }
        public string Type { get; set; }
        public int? TypeId { get; set; }
        public DateTime? IssueDate { get; set; }
        public DateTime? ExpDate { get; set; }
        public string IssuePlace { get; set; }
        public string DocNo { get; set; }
    }
}
