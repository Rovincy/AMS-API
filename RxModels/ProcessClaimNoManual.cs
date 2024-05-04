using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class ProcessClaimNoManual
    {
        public long Id { get; set; }
        public int? ProviderDataId { get; set; }
        public string ProviderId { get; set; }
        public string InsCompany { get; set; }
        public string MemberNo { get; set; }
        public string PassSalt { get; set; }
        public string ValidationSalt { get; set; }
        public DateTime? Datetimeend { get; set; }
        public string ProcessClaimNo { get; set; }
        public string ValidationKey { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? DateOfActualConsultation { get; set; }
        public string Status { get; set; }
        public string PatientStatus { get; set; }
        public string Typeofvisit { get; set; }
        public string NatureOfVisit { get; set; }
        public string RequestMode { get; set; }
        public string AttendingOfficer { get; set; }
        public string AreaOfSpecialisation { get; set; }
        public string ProviderIdDataFor { get; set; }
        public string ProviderIdDataForText { get; set; }
        public string UserSubmitted { get; set; }
        public string HmsVisitNo { get; set; }
        public string PaymentType { get; set; }
        public int UserId { get; set; }
        public string PregnancyStatus { get; set; }
        public string PregnancyWeeks { get; set; }
        public DateTime? PregnancyExpectedDelivery { get; set; }
        public string AuthorisationStatus { get; set; }
        public string AuthAckUser { get; set; }
        public string Visittype { get; set; }
        public string ServiceSpeciality { get; set; }
        public string InsuranceClaimNo { get; set; }
        public string BatchNo { get; set; }
        public DateTime? RecievedDate { get; set; }
    }
}
