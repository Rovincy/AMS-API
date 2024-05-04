using System;
using System.Collections.Generic;

namespace DCI_TSP_API.UserModels;

public partial class ClaimsDetail
{
    public long Id { get; set; }

    public long? ServerId { get; set; }

    public string? ReferralNo { get; set; }

    public string? UpdateStatus { get; set; }

    public string? IdInscompany { get; set; }

    public string? SyncBatchNo { get; set; }

    public string? SyncBatchNoUpdate { get; set; }

    public string? SyncBatchDelete { get; set; }

    public bool? SyncInsert { get; set; }

    public bool? SyncUpdate { get; set; }

    public bool? SyncDelete { get; set; }

    public string? PriceCurrency { get; set; }

    public DateOnly? CurrencyRateDate { get; set; }

    public double? CurrencyUsdRate { get; set; }

    public double? CurrencyOriginalRate { get; set; }

    public uint? ClaimsDetailsId { get; set; }

    public string? InvoiceNo { get; set; }

    public string? ClaimTypeRe { get; set; }

    public double? DiscPercent { get; set; }

    public double? DiscAmount { get; set; }

    public double? CoPaymentPercent { get; set; }

    public double? CoPaymentAmount { get; set; }

    public string? NatureofvisitLimit { get; set; }

    public string? TypeofvisitLimit { get; set; }

    public string? Visittype { get; set; }

    public string? ServiceSpeciality { get; set; }

    public string? IsDisputed { get; set; }

    public DateTime? DisputedDate { get; set; }

    public string? UpdateDeleteStatus { get; set; }

    public string? Company { get; set; }

    public string? AuditUpdate { get; set; }

    public int? ProviderDataId { get; set; }

    public string? InsCompany { get; set; }

    public string? ProviderId { get; set; }

    public string? MemberNo { get; set; }

    public string? ProviderName { get; set; }

    public string? ProviderIdMaster { get; set; }

    public string? EmployerId { get; set; }

    public string? EmployerCode { get; set; }

    public string? UserId { get; set; }

    public string? ProcessClaimNo { get; set; }

    public string? ProviderRefNo { get; set; }

    public string? AttendingOfficer { get; set; }

    public string? Diagnosis { get; set; }

    public string? DiagnosisCode { get; set; }

    public string? IcdCode { get; set; }

    public string? EyeOptical { get; set; }

    public string? Toothnos { get; set; }

    public string? TypeOfVisit { get; set; }

    public string? NatureOfVisit { get; set; }

    public DateOnly? DateOfConsultation { get; set; }

    public DateOnly? DateOfActualConsultation { get; set; }

    public DateOnly? DateOfAdmission { get; set; }

    public DateOnly? DateOfDischarge { get; set; }

    public string? ProviderItemId { get; set; }

    public string? InsItemCode { get; set; }

    public string? AuthorizationRequired { get; set; }

    public string? AuthorizationCode { get; set; }

    public string? Item { get; set; }

    public string? ItemService { get; set; }

    public string? ItemServiceType { get; set; }

    public string? ItemClass { get; set; }

    public int? ItemDaysDiff { get; set; }

    public double? Qty { get; set; }

    public double? UnitPrice { get; set; }

    public double? TotalPrice { get; set; }

    public double? QtyAwarded { get; set; }

    public double? UnitPriceAwarded { get; set; }

    public double? QtyFinance { get; set; }

    public double? UnitPriceFinance { get; set; }

    public DateTime? DateAdded { get; set; }

    public DateOnly? DateAddedShort { get; set; }

    public double? Dose { get; set; }

    public string? DosageForm { get; set; }

    public string? Frequency { get; set; }

    public int? NoOfDays { get; set; }

    public string? Status { get; set; }

    public double? Awarded { get; set; }

    public string? Comment { get; set; }

    public string? CurrentLocation { get; set; }

    public string? ActionStatus { get; set; }

    public string? Supplied { get; set; }

    public string? ValidationKey { get; set; }

    public string? ValidationPin { get; set; }

    public string? ServerPushStatus { get; set; }

    public DateTime? PushTime { get; set; }

    public string? SubmittedStatus { get; set; }

    public DateTime? SubmitTime { get; set; }

    public string RxMemberId { get; set; } = null!;

    public string? SmsSent { get; set; }

    public string? PaymentStatus { get; set; }

    public string? ApprovedQueryStatus { get; set; }

    public string? QueryStatus { get; set; }

    public DateTime? ServerTimeUpdate { get; set; }

    public string? DelStatus { get; set; }

    public string? ProviderIdDataFor { get; set; }

    public string? ProviderIdDataForText { get; set; }

    public string? DecisionStatus { get; set; }

    public string? DecisionReason { get; set; }

    public string? DecisionReasonOther { get; set; }

    public string? AuditStatus { get; set; }

    public string? RxItemName { get; set; }

    public string? RxBrandName { get; set; }

    public string? RxCartegory { get; set; }

    public string? RxPrescriptionName { get; set; }

    public string? FinanceAuditStatus { get; set; }

    public DateTime? AuditTime { get; set; }

    public int? AuditUserId { get; set; }

    public string? AuditedBy { get; set; }

    public string? PaymentType { get; set; }

    public string? PregnancyStatus { get; set; }

    public string? PregnancyWeeks { get; set; }

    public DateOnly? PregnancyExpectedDelivery { get; set; }

    public string? FinanceDecisionStatus { get; set; }

    public string? FinanceDecisionReason { get; set; }

    public string? FinanceDecisionReasonOther { get; set; }

    public string? FinancialStatus { get; set; }

    public string? ProviderNameDataFor { get; set; }

    public string? ReferToAuditor { get; set; }

    public string? ClaimType { get; set; }

    public double? TopupAmt { get; set; }

    public string? ApproveBalance { get; set; }

    public string? BatchNo { get; set; }

    public DateTime? FinanceAuditTime { get; set; }

    public int? FinanceAuditUserId { get; set; }

    public string? FinanceAuditedBy { get; set; }

    public int? SyncInsertCounts { get; set; }

    public int? SyncUpdateCounts { get; set; }

    public string? BookingNo { get; set; }

    public DateTime? InterAuditTime { get; set; }

    public int? InterAuditUserId { get; set; }

    public string? InterAuditedBy { get; set; }

    public string? InterAuditStatus { get; set; }

    public string? InterDecisionStatus { get; set; }

    public decimal? OriginalUnitPrice { get; set; }

    public decimal? CopaymentAmount1 { get; set; }

    public decimal? CopaymentPercent1 { get; set; }

    public string? DrugType { get; set; }
}
