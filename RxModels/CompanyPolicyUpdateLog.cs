using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class CompanyPolicyUpdateLog
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public string CompanyId { get; set; }
        public DateTime? PolicyStartDate { get; set; }
        public DateTime? PolicyEndDate { get; set; }
        public string Username { get; set; }
    }
}
