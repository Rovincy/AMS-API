namespace DCI_TSP_API.UserModels
{
    public class AmsCrmCreateDto
    {
        public int Id { get; set; }
        public string? MemberNumber { get; set; }
        public string CallType { get; set; }
        public string? RefundCode { get; set; }
        public string CallerType { get; set; }
        public string CallDetails { get; set; }
        public int? providerId { get; set; }
        public string PhoneNumber { get; set; }
        public decimal CallDuration { get; set; }
        public int UserId { get; set; }
        public bool? FollowUp { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
