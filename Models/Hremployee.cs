using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class Hremployee
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public DateTime? BirthDate { get; set; }
        public string BloodGroup { get; set; }
        public string MaritalStatus { get; set; }
        public string Religion { get; set; }
        public string BankAccount { get; set; }
        public int? BankName { get; set; }
        public DateTime? JoiningDate { get; set; }
        public string VisaType { get; set; }
        public string VisaDesignation { get; set; }
        public string Gender { get; set; }
        public string Status { get; set; }
        public string LeaveSalary { get; set; }
        public string Wbranch { get; set; }
        public DateTime? Mdate { get; set; }
        public string Muser { get; set; }
        public string SalaryMode { get; set; }
        public DateTime? IncremantDate { get; set; }
        public int? ProjectTranId { get; set; }
        public int? LeavePerYear { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public decimal? MinistrySalary { get; set; }
        public int? SeniorityNo { get; set; }
        public string MinistryStatus { get; set; }
        public DateTime? Eosdate { get; set; }
        public string Grade { get; set; }
        public string RemarksFinancial { get; set; }
        public string Ticket { get; set; }
        public int? LeaveOpeningBalance { get; set; }
        public DateTime? OnDate { get; set; }
        public int? LeaveTaken { get; set; }
        public decimal? BasicSalary { get; set; }
        public DateTime? FromDateTemp { get; set; }
        public DateTime? ToDateTemp { get; set; }
        public string PaymentMode { get; set; }

        public virtual Account Emp { get; set; }
    }
}
