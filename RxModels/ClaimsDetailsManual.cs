using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class ClaimsDetailsManual
    {
        public long Id { get; set; }
        public long? ServerId { get; set; }
        public int? AuditUserId { get; set; }
        public string AuditedBy { get; set; }
        public string AuditUpdate { get; set; }
        public int? ProviderDataId { get; set; }
        public string InsCompany { get; set; }
        public string ProviderId { get; set; }
        public string ProviderName { get; set; }
        public string ProviderIdMaster { get; set; }
        public string MemberNo { get; set; }
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
        public double? QtyFinance { get; set; }
        public double? UnitPriceFinance { get; set; }
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
        public string RxItemName { get; set; }
        public string RxBrandName { get; set; }
        public string RxCartegory { get; set; }
        public string RxPrescriptionName { get; set; }
        public string FinanceAuditStatus { get; set; }
        public string FinancialStatus { get; set; }
        public string ProviderNameDataFor { get; set; }
        public string ReferToAuditor { get; set; }
        public string ClaimType { get; set; }
        public double? TopupAmt { get; set; }
        public string ApproveBalance { get; set; }
        public DateTime RecievedDate { get; set; }
        public string BatchNo { get; set; }
        public string PriceCurrency { get; set; }
        public string SyncBatchNo { get; set; }
        public string SyncBatchNoUpdate { get; set; }
        public string SyncBatchDelete { get; set; }
        public bool? SyncInsert { get; set; }
        public bool? SyncUpdate { get; set; }
        public bool? SyncDelete { get; set; }
        public string IdInscompany { get; set; }
        public int? SyncInsertCounts { get; set; }
        public int? SyncUpdateCounts { get; set; }
        public string InvoiceNo { get; set; }
        public string EmployerId { get; set; }
        public string FinanceDecisionStatus { get; set; }
        public string FinanceDecisionReason { get; set; }
        public string FinanceDecisionReasonOther { get; set; }
        public int? FinanceAuditUserId { get; set; }
        public string FinanceAuditedBy { get; set; }
    }
}
