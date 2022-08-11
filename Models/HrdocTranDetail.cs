using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class HrdocTranDetail
    {
        public int Id { get; set; }
        public int Dtid { get; set; }
        public int EmpId { get; set; }
        public string Type { get; set; }

        public virtual HrdocTransfer Dt { get; set; }
    }
}
