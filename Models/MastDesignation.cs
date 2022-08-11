using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class MastDesignation
    {
        public MastDesignation()
        {
            FlightChartingDetails = new HashSet<FlightChartingDetail>();
            HrempExperiences = new HashSet<HrempExperience>();
            HremployeeBackups = new HashSet<HremployeeBackup>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<FlightChartingDetail> FlightChartingDetails { get; set; }
        public virtual ICollection<HrempExperience> HrempExperiences { get; set; }
        public virtual ICollection<HremployeeBackup> HremployeeBackups { get; set; }
    }
}
