using Microsoft.EntityFrameworkCore;

namespace DCI_TSP_API.RxModels
{
    // Model class
    public class ProviderClaim
    {
        public string? facility_name { get; set; }
        public DateTime EndOfMonth { get; set; }
        public string? Description { get; set; }
        public decimal? tax_rate { get; set; }
        public decimal? TotalAmount { get; set; }
        public decimal? AmountToPay { get; set; }
        public decimal? RejectedAmount { get; set; }
        public decimal? WithholdingTax { get; set; }
        public decimal? Balance { get; set; }
    }
    }
