using System;

namespace DCI_TSP_API.UserModels
{
    public class AmsCro
    {
        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public int? PlanId { get; set; }
        public string? Officer { get; set; }
        public string? Description { get; set; }
        public decimal? OutPatientBenefit { get; set; }
        public decimal? InPatientBenefit { get; set; }
        public decimal? DentalBenefit { get; set; }
        public decimal? OpticalBenefit { get; set; }
        public decimal? MaternityDeliveryBenefit { get; set; }
        public decimal? ChronicBenefit { get; set; }
        public decimal? CancerBenefit { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
