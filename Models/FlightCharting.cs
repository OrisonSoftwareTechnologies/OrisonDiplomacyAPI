using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class FlightCharting
    {
        public FlightCharting()
        {
            FlightChartingDetails = new HashSet<FlightChartingDetail>();
        }

        public int Id { get; set; }
        public string RefNo { get; set; }
        public int Ccid { get; set; }
        public int AccountId { get; set; }
        public int DeptAirportId { get; set; }
        public int ArrivalAirportId { get; set; }
        public DateTime DeptDate { get; set; }
        public DateTime DeptTime { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime ArrivalTime { get; set; }
        public string GroundTime { get; set; }
        public int? TotalPassanger { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public decimal? Rate { get; set; }
        public string NetTime { get; set; }
        public decimal? Amount { get; set; }
        public string Remarks { get; set; }
        public int? NetMinute { get; set; }
        public int? StaffNetMinute { get; set; }
        public string StaffNetTime { get; set; }
        public int? Cargo { get; set; }

        public virtual Account Account { get; set; }
        public virtual AirportMast ArrivalAirport { get; set; }
        public virtual CostCentre Cc { get; set; }
        public virtual AirportMast DeptAirport { get; set; }
        public virtual ICollection<FlightChartingDetail> FlightChartingDetails { get; set; }
    }
}
