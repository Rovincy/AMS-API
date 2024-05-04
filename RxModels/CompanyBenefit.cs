using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class CompanyBenefit
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string CompanyId { get; set; }
        public int? CompanyId1 { get; set; }
        public string PlanId { get; set; }
        public int? PlanId1 { get; set; }
        public string BenefitId { get; set; }
        public int? BenefitId1 { get; set; }
        public string Plans { get; set; }
        public string Benefit { get; set; }
        public string Coverage { get; set; }
        public string Limits { get; set; }
        public string InsCompany { get; set; }
        public string UserId { get; set; }
    }
}
