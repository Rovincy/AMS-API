using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class ClaimsDetailsDel
    {
        public long Id { get; set; }
        public long? ServerId { get; set; }
        public int? ProviderDataId { get; set; }
        public string InsCompany { get; set; }
        public string ProviderId { get; set; }
        public string MemberNo { get; set; }
        public string ProviderName { get; set; }
        public string ProviderIdMaster { get; set; }
        public string EmployerId { get; set; }
        public string EmployerCode { get; set; }
        public string UserId { get; set; }
        public string ProcessClaimNo { get; set; }
        public string ProviderRefNo { get; set; }
        public string AttendingOfficer { get; set; }
        public string Diagnosis { get; set; }
        public string DiagnosisCode { get; set; }
        public string IcdCode { get; set; }
        public string EyeOptical { get; set; }
        public string Toothnos { get; set; }
        public string TypeOfVisit { get; set; }
        public DateTime? DateOfConsultation { get; set; }
        public DateTime? DateOfAdmission { get; set; }
        public DateTime? DateOfDischarge { get; set; }
        public string ProviderItemId { get; set; }
        public string InsItemCode { get; set; }
        public string Item { get; set; }
        public string ItemService { get; set; }
        public string ItemServiceType { get; set; }
        public string ItemClass { get; set; }
        public double? Qty { get; set; }
        public double? UnitPrice { get; set; }
        public DateTime? DateAddedShort { get; set; }
        public double? Dose { get; set; }
        public string DosageForm { get; set; }
        public string Frequency { get; set; }
        public int? NoOfDays { get; set; }
        public string ServerPushStatus { get; set; }
        public string SubmittedStatus { get; set; }
        public string ProviderIdDataFor { get; set; }
        public string ProviderIdDataForText { get; set; }
        public string RxItemName { get; set; }
        public string PregnancyStatus { get; set; }
        public string PregnancyWeeks { get; set; }
        public DateTime? PregnancyExpectedDelivery { get; set; }
        public string Deleteby { get; set; }
    }
}
