using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class ParentTb
    {
        public ParentTb()
        {
            ParentChildtbs = new HashSet<ParentChildtb>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<ParentChildtb> ParentChildtbs { get; set; }
    }
}
