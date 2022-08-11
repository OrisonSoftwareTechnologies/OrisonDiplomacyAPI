using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class SubGroupTranList
    {
        public int Id { get; set; }
        public int Sgid { get; set; }
        public int SubGroupId { get; set; }

        public virtual SubGroupTran Sg { get; set; }
    }
}
