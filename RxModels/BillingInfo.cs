using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class BillingInfo
    {
        public int Id { get; set; }
        public int? BillingId { get; set; }
        public string BillName { get; set; }
        public string InvoiceNo { get; set; }
        public string InsCompany { get; set; }
        public string CompanyId { get; set; }
        public int? CompanyId1 { get; set; }
        public string PlanId { get; set; }
        public int? PlanId1 { get; set; }
        public string PlanName { get; set; }
        public string Currency { get; set; }
        public double? AmountBilled { get; set; }
        public int? TotalMembersBilled { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
