using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class WsJobMaster
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string PlateNo { get; set; }
        public int JobId { get; set; }
        public DateTime? Date { get; set; }
        public DateTime? Time { get; set; }
        public DateTime? Rdate { get; set; }
        public DateTime? Rtime { get; set; }
        public string Advisor { get; set; }
        public string RoadTestBy { get; set; }
        public int? FuelLevel { get; set; }
        public DateTime? TestInTime { get; set; }
        public DateTime? TestOutTime { get; set; }
        public string JobModel { get; set; }
    }
}
