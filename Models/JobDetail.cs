using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class JobDetail
    {
        public int Id { get; set; }
        public int Jobid { get; set; }
        public DateTime LoginTime { get; set; }
        public string Remarks { get; set; }

        public virtual JobMain Job { get; set; }
    }
}
