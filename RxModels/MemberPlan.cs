using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class MemberPlan
    {
        public int Id { get; set; }
        public string MemberNo { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyId1 { get; set; }
        public string Company { get; set; }
        public int? PlanId { get; set; }
        public string PlanId1 { get; set; }
        public string Plan { get; set; }
        public string InsCompany { get; set; }
        public double? InpatientLimit { get; set; }
        public double? InpatientLimit1 { get; set; }
        public double? InpatientLimit2 { get; set; }
        public double? InpatientLimit3 { get; set; }
        public double? InpatientLimit4 { get; set; }
        public double? InpatientLimit5 { get; set; }
        public double? OutpatientLimit { get; set; }
        public double? OutpatientLimit1 { get; set; }
        public double? OutpatientLimit2 { get; set; }
        public double? OutpatientLimit3 { get; set; }
        public double? OutpatientLimit4 { get; set; }
        public double? OutpatientLimit5 { get; set; }
        public string AmountCoverage { get; set; }
        public double? InpatientLimitPercentage { get; set; }
        public double? OutpatientLimitPercentage { get; set; }
        public string TableType { get; set; }
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
