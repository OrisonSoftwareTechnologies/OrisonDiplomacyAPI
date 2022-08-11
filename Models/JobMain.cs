using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class JobMain
    {
        public JobMain()
        {
            JobDetails = new HashSet<JobDetail>();
        }

        public int Id { get; set; }
        public string JobNo { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int Staffid { get; set; }

        public virtual ICollection<JobDetail> JobDetails { get; set; }
    }
}
