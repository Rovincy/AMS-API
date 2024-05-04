using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class RxPlanBenefitGroup
    {
        public int Id { get; set; }
        public string InsCompany { get; set; }
        public string PlanId { get; set; }
        public int? PlanId1 { get; set; }
        public int? ParentId { get; set; }
        public int? BenefitGroupId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string RxBenefitGroupCode { get; set; }
        public float? LimitAmount1 { get; set; }
        public float? LimitAmount2 { get; set; }
        public float? LimitAmount3 { get; set; }
        public float? LimitAmount4 { get; set; }
        public float? LimitAmount5 { get; set; }
        public double? Percentage1 { get; set; }
        public double? Percentage2 { get; set; }
        public double? Percentage3 { get; set; }
        public double? Percentage4 { get; set; }
        public double? Percentage5 { get; set; }
        public string GroupStatus { get; set; }
        public string VisitType { get; set; }
        public string AmountCoverage { get; set; }
        public string ShowGroupLimit { get; set; }
        public int? UserId { get; set; }
        public string SyncBatchNo { get; set; }
        public string SyncBatchNoUpdate { get; set; }
        public string SyncBatchDelete { get; set; }
        public bool? SyncInsert { get; set; }
        public bool? SyncUpdate { get; set; }
        public bool? SyncDelete { get; set; }
        public string IdInscompany { get; set; }
        public int? SyncInsertCounts { get; set; }
        public int? SyncUpdateCounts { get; set; }
    }
}
