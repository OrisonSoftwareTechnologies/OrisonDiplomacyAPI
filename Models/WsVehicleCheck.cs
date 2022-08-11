using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class WsVehicleCheck
    {
        public int Id { get; set; }
        public int JobId { get; set; }
        public string PlateNo { get; set; }
        public string Eoil { get; set; }
        public string Efilter { get; set; }
        public string Goil { get; set; }
        public string Gfilter { get; set; }
        public string Fbrake { get; set; }
        public string Fdrum { get; set; }
        public string Rbrake { get; set; }
        public string Rdrum { get; set; }
        public string Ffilter { get; set; }
        public string Ffump { get; set; }
        public string AirFilter { get; set; }
        public bool? HeatingorAc { get; set; }
        public bool? Parkingbrake { get; set; }
        public bool? SlidingRoof { get; set; }
        public bool? SideMirrorFun { get; set; }
        public bool? Floormats { get; set; }
        public bool? SpacesorRubber { get; set; }
        public bool? VirtualLeaks { get; set; }
        public bool? Headlights { get; set; }
        public bool? WindowGlasses { get; set; }
        public bool? Sensors { get; set; }
        public bool? RearCamera { get; set; }
        public double? CheckinCharge { get; set; }
        public byte[] Signature { get; set; }
        public string Remarks { get; set; }
    }
}
