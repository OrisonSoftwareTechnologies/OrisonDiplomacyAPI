using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class AirportMast
    {
        public AirportMast()
        {
            FlightChartingArrivalAirports = new HashSet<FlightCharting>();
            FlightChartingDeptAirports = new HashSet<FlightCharting>();
        }

        public int Id { get; set; }
        public string AirportCode { get; set; }
        public string Name { get; set; }
        public string Remarks { get; set; }

        public virtual ICollection<FlightCharting> FlightChartingArrivalAirports { get; set; }
        public virtual ICollection<FlightCharting> FlightChartingDeptAirports { get; set; }
    }
}
