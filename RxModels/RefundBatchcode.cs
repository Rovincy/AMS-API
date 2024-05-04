using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class RefundBatchcode
    {
        public int Id { get; set; }
        public string Company { get; set; }
        public string Batchcode { get; set; }
        public DateTime DateCreated { get; set; }
        public int NoOfClaims { get; set; }
        public float TotalAmountClaimed { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public string SubmittedBy { get; set; }
        public string ContactInfo { get; set; }
        public int CompanyId { get; set; }
    }
}
