using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class Reminder
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
