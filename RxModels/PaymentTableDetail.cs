using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class PaymentTableDetail
    {
        public long Id { get; set; }
        public int? ServerId { get; set; }
        public long? ProviderDataId { get; set; }
        public string ProviderId { get; set; }
        public string ProviderIdMaster { get; set; }
        public string ProviderName { get; set; }
        public string InsCompany { get; set; }
        public int? Yrofclaim { get; set; }
        public int? Monthofclaim { get; set; }
        public double? ProviderClaimAmt { get; set; }
        public int? NumberOfClaims { get; set; }
        public int? SubmittedBeforeCloseNo { get; set; }
        public double? SubmittedBeforeCloseSum { get; set; }
        public int? SubmittedAfterCloseNo { get; set; }
        public double? SubmittedAfterCloseSum { get; set; }
        public int? NotSubmittedOutpatientNo { get; set; }
        public double? NotSubmittedOutpatientSum { get; set; }
        public int? NotSubmittedInpatientNo { get; set; }
        public double? NotSubmittedInpatientSum { get; set; }
        public int? TotalNo { get; set; }
        public double? TotalSum { get; set; }
        public int? TotalTransactions { get; set; }
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
