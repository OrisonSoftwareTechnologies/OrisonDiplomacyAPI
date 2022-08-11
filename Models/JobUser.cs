using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class JobUser
    {
        public int Id { get; set; }
        public int? StaffId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
