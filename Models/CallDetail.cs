using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class CallDetail
    {
        public int Id { get; set; }
        public string ClientCode { get; set; }
        public string ClientName { get; set; }
        public string TransferredTo { get; set; }
        public string Description { get; set; }
        public DateTime? CallingDate { get; set; }
        public string Status { get; set; }
    }
}
