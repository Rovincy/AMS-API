using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class PolicyUnderwriting
    {
        public int Id { get; set; }
        public string InsCompany { get; set; }
        public DateTime? DateOfApplication { get; set; }
        public string UnderwritingNo { get; set; }
        public string UnderwritingStatus { get; set; }
        public string UnderwritingPriority { get; set; }
        public string AssignedUnderwriter { get; set; }
        public string Agent { get; set; }
        public DateTime? DueDate { get; set; }
        public int? UserId { get; set; }
        public string Commission { get; set; }
        public string CommissionType { get; set; }
    }
}
