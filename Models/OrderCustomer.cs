using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class OrderCustomer
    {
        public int Id { get; set; }
        public string CustCode { get; set; }
        public string Customername { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}
