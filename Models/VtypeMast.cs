using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class VtypeMast
    {
        public VtypeMast()
        {
            EntryModeMasts = new HashSet<EntryModeMast>();
            VtypeTrans = new HashSet<VtypeTran>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<EntryModeMast> EntryModeMasts { get; set; }
        public virtual ICollection<VtypeTran> VtypeTrans { get; set; }
    }
}
