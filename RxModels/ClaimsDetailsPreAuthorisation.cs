using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class ClaimsDetailsPreAuthorisation
    {
        public long Id { get; set; }
        public int? ServerId { get; set; }
        public int? ProviderDataId { get; set; }
        public string InsCompany { get; set; }
        public string ProviderId { get; set; }
        public string MemberNo { get; set; }
        public string EmployerId { get; set; }
        public string UserId { get; set; }
        public string ProcessClaimNo { get; set; }
        public string ProviderRefNo { get; set; }
        public string AttendingOfficer { get; set; }
        public string Diagnosis { get; set; }
        public string EyeOptical { get; set; }
        public string Toothnos { get; set; }
        public string TypeOfVisit { get; set; }
        public DateTime? DateOfConsultation { get; set; }
        public DateTime? DateOfAdmission { get; set; }
        public DateTime? DateOfDischarge { get; set; }
        public string ProviderItemId { get; set; }
        public string InsItemCode { get; set; }
        public string AuthorizationRequired { get; set; }
        public string AuthorizationCode { get; set; }
        public string Item { get; set; }
        public string ItemService { get; set; }
        public string ItemServiceType { get; set; }
        public string ItemClass { get; set; }
        public int? ItemDaysDiff { get; set; }
        public double? Qty { get; set; }
        public double? UnitPrice { get; set; }
        public double? TotalPrice { get; set; }
        public double? QtyAwarded { get; set; }
        public double? UnitPriceAwarded { get; set; }
        public DateTime? DateAddedShort { get; set; }
        public double? Dose { get; set; }
        public string DosageForm { get; set; }
        public string Frequency { get; set; }
        public int? NoOfDays { get; set; }
        public string Status { get; set; }
        public double? Awarded { get; set; }
        public string Comment { get; set; }
        public string CurrentLocation { get; set; }
        public string ActionStatus { get; set; }
        public string Supplied { get; set; }
        public string ValidationKey { get; set; }
        public string ValidationPin { get; set; }
        public string ServerPushStatus { get; set; }
        public string SubmittedStatus { get; set; }
        public string RxMemberId { get; set; }
        public string SmsSent { get; set; }
        public string PaymentStatus { get; set; }
        public string ApprovedQueryStatus { get; set; }
        public string QueryStatus { get; set; }
        public string DelStatus { get; set; }
        public string ProviderIdDataFor { get; set; }
        public string ProviderIdDataForText { get; set; }
        public string DecisionStatus { get; set; }
        public string DecisionReason { get; set; }
        public string DecisionReasonOther { get; set; }
        public string AuditStatus { get; set; }
        public int? AuditUserId { get; set; }
        public string AuditedBy { get; set; }
        public string CaseStatus { get; set; }
        public string AuthorizationNo { get; set; }
        public string CaseNumber { get; set; }
        public string AmountUsed { get; set; }
        public string ServerPushStatusAuth { get; set; }
        public string UpdateDeleteStatus { get; set; }
        public string Company { get; set; }
        public string SyncBatchNo { get; set; }
        public string SyncBatchNoDelete { get; set; }
        public string SyncBatchNoUpdate { get; set; }
        public byte? SyncDelete { get; set; }
        public byte? SyncInsert { get; set; }
        public byte? SyncUpdate { get; set; }
        public string IdInscompany { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string ClaimType { get; set; }
        public string Notification { get; set; }
        public int? SyncInsertCounts { get; set; }
        public int? SyncUpdateCounts { get; set; }
        public string Des { get; set; }
    }
}
