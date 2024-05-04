using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class Booking
    {
        public int Id { get; set; }
        public double? RequestedAmount { get; set; }
        public double? ApprovedAmount { get; set; }
        public string DecisionStatus { get; set; }
        public string ItemName { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public string RequestedBy { get; set; }
        public int? ProviderId { get; set; }
        public string InsCompany { get; set; }
        public DateTime? DateCreated { get; set; }
        public string MemberNo { get; set; }
        public string BookingNo { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Reason { get; set; }
    }
}
