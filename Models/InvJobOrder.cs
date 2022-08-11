using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class InvJobOrder
    {
        public int Reference { get; set; }
        public string SalesDivision { get; set; }
        public DateTime? Date { get; set; }
        public string RefType { get; set; }
        public string QuotRef { get; set; }
        public string SizeOfSign { get; set; }
        public DateTime? CutOffDate { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNo { get; set; }
        public string TypeOfSign { get; set; }
        public string SalesRepId { get; set; }
        public string SalesRep { get; set; }
        public decimal? TotAmount { get; set; }
        public int? ApprovedAmount { get; set; }
        public string User { get; set; }
        public DateTime? Mdate { get; set; }
        public bool Invoiced { get; set; }
        public string Branch { get; set; }
        public decimal? Additional { get; set; }
        public string Status { get; set; }
        public string Remarks { get; set; }
        public string JobDescription { get; set; }
        public string JobType { get; set; }
        public string Activated { get; set; }
        public DateTime? ActivatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ProofApproved { get; set; }
        public string SubStatus { get; set; }
        public string Print { get; set; }
        public string InvoiceNo { get; set; }
        public short? ApprovedPrinted { get; set; }
        public short? NonApprovedPrinted { get; set; }
        public bool Cancelled { get; set; }
        public string Reason { get; set; }
        public string AccVerified { get; set; }
        public DateTime? AccVerifiedDate { get; set; }
    }
}
