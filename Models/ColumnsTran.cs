using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class ColumnsTran
    {
        public ColumnsTran()
        {
            ColumnsTranLists = new HashSet<ColumnsTranList>();
        }

        public int Id { get; set; }
        public int Vtid { get; set; }

        public virtual ICollection<ColumnsTranList> ColumnsTranLists { get; set; }
    }
}
