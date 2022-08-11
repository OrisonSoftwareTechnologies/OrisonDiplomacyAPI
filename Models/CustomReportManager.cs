using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class CustomReportManager
    {
        public CustomReportManager()
        {
            CustomReportColumns = new HashSet<CustomReportColumn>();
        }

        public int Id { get; set; }
        public string ReportName { get; set; }
        public string SqlQuery { get; set; }

        public virtual ICollection<CustomReportColumn> CustomReportColumns { get; set; }
    }
}
