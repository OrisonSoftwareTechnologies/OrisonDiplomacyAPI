using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class HrempChequeDetail
    {
        public int Id { get; set; }
        public int? EmpId { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? ChequeDate { get; set; }
        public string CkequeNo { get; set; }
        public decimal? Amount { get; set; }
        public string Bank { get; set; }
    }
}
