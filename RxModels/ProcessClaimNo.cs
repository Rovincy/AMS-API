using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class ProcessClaimNo
    {
        public long Id { get; set; }
        public long? ProviderDataId { get; set; }
        public string ProviderId { get; set; }
        public string InsCompany { get; set; }
        public string MemberNo { get; set; }
        public string PassSalt { get; set; }
        public string ValidationSalt { get; set; }
        public string ProcessClaimNo1 { get; set; }
        public string InsuranceClaimNo { get; set; }
        public string BatchNo { get; set; }
        public string ValidationKey { get; set; }
        public DateTime? DateAdded { get; set; }
        public string Status { get; set; }
        public string Typeofvisit { get; set; }
        public string RequestMode { get; set; }
        public string AttendingOfficer { get; set; }
        public string GopStatus { get; set; }
        public double? AssignedAmt { get; set; }
        public string ApprovedBy { get; set; }
        public string NatureOfVisit { get; set; }
        public string Visittype { get; set; }
        public string ServiceSpeciality { get; set; }
    }
}
