using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class PolicyPlanBenefit
    {
        public int Id { get; set; }
        public string InsCompany { get; set; }
        public int? InsurancePolicyId { get; set; }
        public int? PlanId { get; set; }
        public string BenefitName { get; set; }
        public string Limits { get; set; }
        public string Coverage { get; set; }
        public int? UserId { get; set; }
    }
}
