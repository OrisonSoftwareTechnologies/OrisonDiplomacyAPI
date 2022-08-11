using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class ColumnsTranList
    {
        public int Id { get; set; }
        public int Cid { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public bool Visible { get; set; }
        public bool AllowNull { get; set; }

        public virtual ColumnsTran CidNavigation { get; set; }
    }
}
