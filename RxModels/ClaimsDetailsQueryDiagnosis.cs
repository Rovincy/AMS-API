using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class ClaimsDetailsQueryDiagnosis
    {
        public long Id { get; set; }
        public long? ServerId { get; set; }
        public string InsCompany { get; set; }
        public long? ProviderDataId { get; set; }
        public int? ProviderId { get; set; }
        public string DiseaseGrp { get; set; }
        public int? DiseaseId { get; set; }
        public string DiseaseCode { get; set; }
        public string DiseaseName { get; set; }
        public string ProcessClaimNo { get; set; }
        public string Status { get; set; }
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
