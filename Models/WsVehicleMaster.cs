using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class WsVehicleMaster
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string PlateNo { get; set; }
        public string Km { get; set; }
        public string Model { get; set; }
        public string Colour { get; set; }
        public string Vim { get; set; }
        public string Company { get; set; }
    }
}
