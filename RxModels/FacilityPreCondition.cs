using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class FacilityPreCondition
    {
        public int Id { get; set; }
        public int? FacilityId { get; set; }
        public string Condition { get; set; }
    }
}
