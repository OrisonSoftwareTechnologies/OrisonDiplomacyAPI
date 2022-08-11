using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class HrtransportationMast
    {
        public int Id { get; set; }
        public string VehicleNo { get; set; }
        public string VehicleName { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string RegNo { get; set; }
        public string Plate { get; set; }
        public string Emirates { get; set; }
        public string ChassisNo { get; set; }
        public string EngineNo { get; set; }
        public string Supplier { get; set; }
        public int? Capacity { get; set; }
        public string Remarks { get; set; }
    }
}
