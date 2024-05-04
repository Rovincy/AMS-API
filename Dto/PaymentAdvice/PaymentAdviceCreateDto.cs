namespace DCI_TSP_API.Dto.PaymentAdvice
{
    public class PaymentAdviceCreateDto
    {
        public int? Id { get; set; }

        public int? ProviderId { get; set; }

        public double? Amount { get; set; }
        public string? Type { get; set; }

        public int? BankId { get; set; }

        public string? CheckNumber { get; set; }

        public string? Description { get; set; }

        public DateTime? Month { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
