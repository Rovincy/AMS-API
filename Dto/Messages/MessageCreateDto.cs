namespace DCI_TSP_API.Dto.Messages
{
    public class MessageCreateDto
    {
        public int SenderId { get; set; }
        public int ReceiverId { get; set; }
        public string? Message { get; set; }
        public DateTime Timestamp { get; set; }
        public bool? Status { get; set; }
    }
}
