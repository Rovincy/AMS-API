using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class ProviderApiInsCompany
    {
        public int Id { get; set; }
        public int? ProviderId { get; set; }
        public string InsCompany { get; set; }
        public string CardPinStatus { get; set; }
        public string InsCompanyStatus { get; set; }
        public int? DaysClosingAccount { get; set; }
        public int? DaysClosingAccount2 { get; set; }
        public int? DaysBeforeNotification { get; set; }
        public int? DaysForClaim { get; set; }
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
