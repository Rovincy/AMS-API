using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class ProviderApi
    {
        public int Id { get; set; }
        public int? ServerId { get; set; }
        public string FacilityNumber { get; set; }
        public string FacilityName { get; set; }
        public string FacilityNameOld { get; set; }
        public string FacilityAddress { get; set; }
        public string FacilityLocation { get; set; }
        public string FacilityTelNumber { get; set; }
        public string FacilityTelNumber2 { get; set; }
        public string FacilityContactPerson { get; set; }
        public string FacilityContactTel { get; set; }
        public string FacilityRegion { get; set; }
        public string RxZone { get; set; }
        public string Area { get; set; }
        public string SubArea { get; set; }
        public string FacilityPhoto { get; set; }
        public string Cordinate { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public double? AverageRates { get; set; }
        public int? RatedSum { get; set; }
        public int? RatedTotal { get; set; }
        public string Ratings { get; set; }
        public string FacilityStatus { get; set; }
        public string FacilityType { get; set; }
        public string MedicalStatus { get; set; }
        public string PharmacyStatus { get; set; }
        public string DentalStatus { get; set; }
        public string LabStatus { get; set; }
        public string OpticalStatus { get; set; }
        public string PhysiotherapyStatus { get; set; }
        public string AdministrativeStatus { get; set; }
        public string PaymentType { get; set; }
        public int? ProviderId { get; set; }
        public int? ProviderIdMaster { get; set; }
        public int? ProviderIdBranchHead { get; set; }
        public string Apikey { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
        public string ActivationSalt { get; set; }
        public string TypeOfFacility { get; set; }
        public string ActivationPassSalt { get; set; }
        public string ActivationKey { get; set; }
        public string FacilityZone { get; set; }
        public string PreviousApikey { get; set; }
        public string PreviousUsername { get; set; }
        public string PreviousPassword { get; set; }
        public string Version { get; set; }
        public string OutOfNetwork { get; set; }
        public string ApCode { get; set; }
        public string InsCompany { get; set; }
        public string UpdateDeleteStatus { get; set; }
        public string ProviderStatus { get; set; }
        public string FacilityContactEmail { get; set; }
        public string FacilitySite { get; set; }
        public string HmsFacilityStatus { get; set; }
        public string SyncBatchNo { get; set; }
        public string SyncBatchNoUpdate { get; set; }
        public string SyncBatchNoDelete { get; set; }
        public byte? SyncInsert { get; set; }
        public byte? SyncUpdate { get; set; }
        public byte? SyncDelete { get; set; }
        public string IdInscompany { get; set; }
        public int? SyncInsertCounts { get; set; }
        public int? SyncUpdateCounts { get; set; }
        public string CustomerId { get; set; }
        public double? TaxRate { get; set; }
    }
}
