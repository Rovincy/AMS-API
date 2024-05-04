using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class ProviderApiOriginal
    {
        public int Id { get; set; }
        public string FacilityNumber { get; set; }
        public string FacilityName { get; set; }
        public string FacilityAddress { get; set; }
        public string FacilityLocation { get; set; }
        public string FacilityTelNumber { get; set; }
        public string FacilityContactPerson { get; set; }
        public string FacilityContactTel { get; set; }
        public string FacilityRegion { get; set; }
        public string FacilityStatus { get; set; }
        public string FacilityType { get; set; }
        public string PaymentType { get; set; }
        public string MedicalStatus { get; set; }
        public string PharmacyStatus { get; set; }
        public string DentalStatus { get; set; }
        public string LabStatus { get; set; }
        public string OpticalStatus { get; set; }
        public string PhysiotherapyStatus { get; set; }
        public string AdministrativeStatus { get; set; }
        public int? ProviderId { get; set; }
        public int? ProviderIdMaster { get; set; }
        public string Apikey { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public string ActivationSalt { get; set; }
        public string ActivationPassSalt { get; set; }
        public string ActivationKey { get; set; }
        public string FacilityZone { get; set; }
        public string TypeOfFacility { get; set; }
        public string InsCompany { get; set; }
        public string ProviderStatus { get; set; }
    }
}
