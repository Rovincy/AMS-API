namespace DCI_TSP_API.UserModels
{
    public class AmsCRM
    {
        public int Id { get; set; }
        public string? MemberNumber { get; set; }
        public string? CallerType {  get; set; }
        public string? RefundCode { get; set; }
        public string? CompanyType { get; set; }
        public string? CallType {  get; set; }
        public string? ReceiverName { get; set; }
        public string? AuthorizationType { get; set; }
        public string? Location { get; set; }
        public string? DeliveryDuration { get; set; }
        public decimal? Limit { get; set; }
        public string? PhoneNumber {  get; set; }
        public string? callDetails {  get; set; }
        public decimal? CallDuration {  get; set; }
        public int? UserId { get; set; }
        public int? providerId { get; set; }
        public bool? FollowUp { get; set; }
        public DateTime? Timestamp { get; set; }
    }
}
