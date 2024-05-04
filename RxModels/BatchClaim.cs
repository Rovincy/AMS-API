using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class BatchClaim
    {
        public int BatchId { get; set; }
        public DateTime? MonthOfClaim { get; set; }
        public int NumberOfClaims { get; set; }
        public string SubmittedBy { get; set; }
        public string Contact { get; set; }
        public int ProviderId { get; set; }
        public string BatchNumber { get; set; }
        public int? NumberOfProcessedClaims { get; set; }
        public DateTime? MonthClaim { get; set; }
    }
}
