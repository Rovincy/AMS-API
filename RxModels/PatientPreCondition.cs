using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class PatientPreCondition
    {
        public long Id { get; set; }
        public string InsComapny { get; set; }
        public int? InsurancePolicyId { get; set; }
        public int? PatientId { get; set; }
        public int? ParentId { get; set; }
        public string Condition { get; set; }
    }
}
