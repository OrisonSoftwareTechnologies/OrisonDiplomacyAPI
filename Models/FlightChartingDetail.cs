using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class FlightChartingDetail
    {
        public int Id { get; set; }
        public int Fcid { get; set; }
        public int AccountId { get; set; }
        public int DesignationId { get; set; }
        public decimal Rate { get; set; }

        public virtual Account Account { get; set; }
        public virtual MastDesignation Designation { get; set; }
        public virtual FlightCharting Fc { get; set; }
    }
}
