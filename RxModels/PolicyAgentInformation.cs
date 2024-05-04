using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class PolicyAgentInformation
    {
        public int Id { get; set; }
        public string InsCompany { get; set; }
        public int? InsurancePolicyId { get; set; }
        public string AgencyName { get; set; }
        public string AgentId { get; set; }
        public string AgentName { get; set; }
        public string AgentLicensingReview { get; set; }
        public string AgentTrainingReview { get; set; }
        public string AgentComments { get; set; }
        public int? UserId { get; set; }
    }
}
