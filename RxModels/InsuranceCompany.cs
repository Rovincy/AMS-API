using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class InsuranceCompany
    {
        public int Id { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string CompanyAddress { get; set; }
        public string CompanyTel { get; set; }
        public string ContactPerson { get; set; }
        public string ApiKey { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? DateAdded { get; set; }
        public string Status { get; set; }
        public string Siteprefix { get; set; }
        public string SmsName { get; set; }
        public string AppAddress { get; set; }
        public string TypeOfCompany { get; set; }
        public string UseFamilyNumber { get; set; }
        public string UseBalance { get; set; }
        public string AccountStatus { get; set; }
        public string UsePin { get; set; }
        public string Showlimits { get; set; }
        public string GenerateMemberNo { get; set; }
        public string VersionNumber { get; set; }
        public string FamilyBenefitStatus { get; set; }
    }
}
