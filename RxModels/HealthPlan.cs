using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class HealthPlan
    {
        public int Id { get; set; }
        public string PlanId { get; set; }
        public string PlanName { get; set; }
        public string InsCompany { get; set; }
        public int? UserId { get; set; }
        public float? OutPatientLimit { get; set; }
        public float? OutPatientLimit1 { get; set; }
        public float? OutPatientLimit2 { get; set; }
        public float? OutPatientLimit3 { get; set; }
        public float? OutPatientLimit4 { get; set; }
        public float? OutPatientLimit5 { get; set; }
        public float? InPatientLimit { get; set; }
        public float? InPatientLimit1 { get; set; }
        public float? InPatientLimit2 { get; set; }
        public float? InPatientLimit3 { get; set; }
        public float? InPatientLimit4 { get; set; }
        public float? InPatientLimit5 { get; set; }
        public string AmountCoverage { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string Prefix { get; set; }
        public string SyncBatchNo { get; set; }
        public string SyncBatchNoUpdate { get; set; }
        public string SyncBatchNoDelete { get; set; }
        public byte? SyncInsert { get; set; }
        public byte? SyncUpdate { get; set; }
        public byte? SyncDelete { get; set; }
        public string IdInscompany { get; set; }
        public int? SyncInsertCounts { get; set; }
        public int? SyncUpdateCounts { get; set; }
    }
}
