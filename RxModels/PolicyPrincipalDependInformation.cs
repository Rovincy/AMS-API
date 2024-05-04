using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class PolicyPrincipalDependInformation
    {
        public int Id { get; set; }
        public string InsCompany { get; set; }
        public int? InsurancePolicyId { get; set; }
        public int? PrincipalId { get; set; }
        public string MemberType { get; set; }
        public string Surname { get; set; }
        public string Othernames { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Sex { get; set; }
        public string Email { get; set; }
        public string TelephoneNo { get; set; }
        public int? NoOfDependents { get; set; }
        public string Picpath { get; set; }
        public string RelationshipType { get; set; }
    }
}
