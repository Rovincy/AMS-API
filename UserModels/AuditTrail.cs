namespace DCI_TSP_API.UserModels
{
    public class AuditTrail
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Action { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
