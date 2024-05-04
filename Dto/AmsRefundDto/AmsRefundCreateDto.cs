using Google.Protobuf.WellKnownTypes;

namespace DCI_TSP_API.UserModels
{
    public class AmsRefundCreateDto
    {
        public int? Id { get; set; }
        public string? RefundCode { get; set; }
        public string? MemberNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public decimal? AmountClaimed { get; set; }
        public decimal? AmountAwarded { get; set; }
        public string? Comments { get; set; }
        public int? RefundOfficer { get; set; }
        public DateTime? RefundOfficerTimestamp { get; set; }
        public int? ClaimRefundOfficer { get; set; }
        public DateTime? ClaimRefundOfficerTimestamp { get; set; }
        public int? AuditOfficer { get; set; }
        public DateTime? AuditOfficerTimestamp { get; set; }
        public int? FinanceOfficer { get; set; }
        public DateTime? FinanceOfficerTimestamp { get; set; }
        public string? Dispatch { get; set; }
        public DateTime? DispatchTimestamp { get; set; }
        public string? Role { get; set; }
    }
}
