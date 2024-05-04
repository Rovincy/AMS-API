using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class ProviderPrescription
    {
        public int Id { get; set; }
        public string InsCompany { get; set; }
        public string ProcessClaimNo { get; set; }
        public string PrescriptionDocument { get; set; }
        public string Description { get; set; }
        public string ProviderId { get; set; }
        public string ProviderUserId { get; set; }
        public string Status { get; set; }
        public string SyncBatchNo { get; set; }
    }
}
