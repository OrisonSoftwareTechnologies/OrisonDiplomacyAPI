using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class WsJobDetailsApp
    {
        public int Id { get; set; }
        public int Idjob { get; set; }
        public string Complaint { get; set; }
        public string Aed { get; set; }
        public DateTime? Date { get; set; }
    }
}
