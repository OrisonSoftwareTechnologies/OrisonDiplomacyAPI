using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class VoucherAdditionalTran
    {
        public int Id { get; set; }
        public int Vtid { get; set; }
        public string ColumnName { get; set; }
        public string LinkTable { get; set; }
        public string LinkField { get; set; }
    }
}
