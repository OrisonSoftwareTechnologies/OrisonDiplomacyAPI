using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class CostCentre
    {
        public CostCentre()
        {
            FlightChartings = new HashSet<FlightCharting>();
            FlightInvoiceTrans = new HashSet<FlightInvoiceTran>();
            HrempProjects = new HashSet<HrempProject>();
            TranCostCentres = new HashSet<TranCostCentre>();
            VentryCostCentres = new HashSet<VentryCostCentre>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public bool? InActive { get; set; }
        public string Ptype { get; set; }

        public virtual CostCentreDetail CostCentreDetail { get; set; }
        public virtual ICollection<FlightCharting> FlightChartings { get; set; }
        public virtual ICollection<FlightInvoiceTran> FlightInvoiceTrans { get; set; }
        public virtual ICollection<HrempProject> HrempProjects { get; set; }
        public virtual ICollection<TranCostCentre> TranCostCentres { get; set; }
        public virtual ICollection<VentryCostCentre> VentryCostCentres { get; set; }
    }
}
