using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class PaymentTable
    {
        public long Id { get; set; }
        public int? ServerId { get; set; }
        public string ProviderId { get; set; }
        public string ProviderIdMaster { get; set; }
        public string ProviderName { get; set; }
        public string InsCompany { get; set; }
        public int? Yrofclaim { get; set; }
        public int? Monthofclaim { get; set; }
        public double? ProviderClaimAmt { get; set; }
        public double? InsurerAmtPaid { get; set; }
        public double? TaxAmt { get; set; }
        public double? RejectedAmt { get; set; }
        public string PaymentStatus { get; set; }
        public string Chknumber { get; set; }
        public int? NumberOfClaims { get; set; }
        public string SystemInvoiceNo { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string TypeOfFacility { get; set; }
        public string SyncBatchNo { get; set; }
        public string SyncBatchNoUpdate { get; set; }
        public string SyncBatchNoDelete { get; set; }
        public byte? SyncInsert { get; set; }
        public byte? SyncUpdate { get; set; }
        public byte? SyncDelete { get; set; }
        public string IdInscompany { get; set; }
        public int? SyncInsertCounts { get; set; }
        public int? SyncUpdateCounts { get; set; }
        public DateTime? DateOfClaim { get; set; }
        public DateTime? DateAdded{ get; set; }
    }
}
