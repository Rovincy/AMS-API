using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class RxMemberBenefit
    {
        public int Id { get; set; }
        public string InsCompany { get; set; }
        public string PlanId { get; set; }
        public int? PlanId1 { get; set; }
        public string CompanyId { get; set; }
        public int? CompanyId1 { get; set; }
        public int? BenefitGroupId { get; set; }
        public string RxCode { get; set; }
        public string RxArea { get; set; }
        public string RxAreaCode { get; set; }
        public string RxItemName { get; set; }
        public string RxItemId { get; set; }
        public string RxPaymentType { get; set; }
        public double? AmountLimit1 { get; set; }
        public double? AmountLimit2 { get; set; }
        public double? AmountLimit3 { get; set; }
        public double? AmountLimit4 { get; set; }
        public double? AmountLimit5 { get; set; }
        public float? NoOfUnits1 { get; set; }
        public float? NoOfUnits2 { get; set; }
        public float? NoOfUnits3 { get; set; }
        public float? NoOfUnits4 { get; set; }
        public float? NoOfUnits5 { get; set; }
        public int? NoOfSessions1 { get; set; }
        public int? NoOfSessions2 { get; set; }
        public int? NoOfSessions3 { get; set; }
        public int? NoOfSessions4 { get; set; }
        public int? NoOfSessions5 { get; set; }
        public int? NoOfTimes1 { get; set; }
        public int? NoOfTimes2 { get; set; }
        public int? NoOfTimes3 { get; set; }
        public int? NoOfTimes4 { get; set; }
        public int? NoOfTimes5 { get; set; }
        public int? Duration1 { get; set; }
        public int? Duration2 { get; set; }
        public int? Duration3 { get; set; }
        public int? Duration4 { get; set; }
        public int? Duration5 { get; set; }
        public string DurationTag1 { get; set; }
        public string DurationTag2 { get; set; }
        public string DurationTag3 { get; set; }
        public string DurationTag4 { get; set; }
        public string DurationTag5 { get; set; }
        public string RepeatMode { get; set; }
        public string ApplicableArea { get; set; }
        public string AmountCoverage { get; set; }
        public string VisitType { get; set; }
        public string ItemStatusMeaning { get; set; }
        public string AuthorizationRequired { get; set; }
        public string Pregnancy { get; set; }
        public string SyncBatchNo { get; set; }
        public string SyncBatchNoUpdate { get; set; }
        public string SyncBatchDelete { get; set; }
        public bool? SyncInsert { get; set; }
        public bool? SyncUpdate { get; set; }
        public bool? SyncDelete { get; set; }
        public string IdInscompany { get; set; }
        public string MemberNo { get; set; }
        public int? SyncInsertCounts { get; set; }
        public int? SyncUpdateCounts { get; set; }
    }
}
