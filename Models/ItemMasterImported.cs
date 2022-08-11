using System;
using System.Collections.Generic;

#nullable disable

namespace OrisonSPMSAPI.Models
{
    public partial class ItemMasterImported
    {
        public string Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string SellingPrice { get; set; }
        public string Oemno { get; set; }
        public string PartNo { get; set; }
        public double? CategoryId { get; set; }
        public string Manufacturer { get; set; }
        public string BarCode { get; set; }
        public string ModelNo { get; set; }
        public string Unit { get; set; }
        public string Rol { get; set; }
        public string Remarks { get; set; }
        public double? IsGroup { get; set; }
        public double? StockItem { get; set; }
        public double? Inactive { get; set; }
        public double? InvAccountId { get; set; }
        public double? CostAccountId { get; set; }
        public double? PurchaseAccountId { get; set; }
        public double? SalesAccountId { get; set; }
        public string Stock { get; set; }
        public string InvoicedStock { get; set; }
        public string AvgCost { get; set; }
        public string LastCost { get; set; }
        public string CreatedDate { get; set; }
        public string ModifiedDate { get; set; }
        public string CreatedUserId { get; set; }
        public string ModifiedUserId { get; set; }
        public string BranchId { get; set; }
        public string Location { get; set; }
        public string MajorGroup { get; set; }
        public string MiddleGroup { get; set; }
        public string MinorGroup { get; set; }
        public string CashPrice { get; set; }
        public string CreditPrice { get; set; }
        public string Roq { get; set; }
    }
}
