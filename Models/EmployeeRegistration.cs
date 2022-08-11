using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class EmployeeRegistration
    {
        public int Id { get; set; }
        public string Department { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public int Staffid { get; set; }
    }
}
