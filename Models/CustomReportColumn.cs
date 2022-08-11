using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class CustomReportColumn
    {
        public int Id { get; set; }
        public int ReportId { get; set; }
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public short Width { get; set; }
        public int Alignment { get; set; }
        public int AutoSize { get; set; }
        public bool FilterEnable { get; set; }

        public virtual CustomReportManager Report { get; set; }
    }
}
