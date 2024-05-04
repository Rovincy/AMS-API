using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class ProviderApiPlan
    {
        public int Id { get; set; }
        public int? ProviderId { get; set; }
        public string InsCompany { get; set; }
        public string Plan { get; set; }
        public string Status { get; set; }
        public int? PlanId { get; set; }
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
