using System;
using System.Collections.Generic;

namespace DCI_TSP_API.RxModels;

public partial class PaymentAdvice
{
    public int Id { get; set; }

    public int ProviderId { get; set; }

    public double Amount { get; set; }

    public string Description { get; set; } = null!;

    public DateTime Month { get; set; }

    public DateTime Timestamp { get; set; }

    public string? Type { get; set; }

    public int? BankId { get; set; }

    public string? CheckNumber { get; set; }
}
