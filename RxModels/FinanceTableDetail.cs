using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class FinanceTableDetail
    {
        public long Id { get; set; }
        public string ProviderId { get; set; }
        public string ProviderIdMaster { get; set; }
        public string ProviderName { get; set; }
        public string InsCompany { get; set; }
        public int? Yrofclaim { get; set; }
        public int? Monthofclaim { get; set; }
        public double? SumOfClaims { get; set; }
        public int? NumberOfClaims { get; set; }
        public double? SumOfClaimsAwarded { get; set; }
        public double? SumOfClaimsRejected { get; set; }
        public int? UserId { get; set; }
        public string PostedBy { get; set; }
        public string BatchNumber { get; set; }
        public double? TaxRate { get; set; }
        public double? TaxAmount { get; set; }
        public DateTime? DateOfClaim { get; set; }
        public string Status { get; set; }
        public string UserFinance { get; set; }
        public string DateTimeFinance { get; set; }
    }
}
