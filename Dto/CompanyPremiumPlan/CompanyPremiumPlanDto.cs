namespace DCI_TSP_API.Dto.CompanyPremiumPlan
{
    public class CompanyPremiumPlanDto
    {
        public int CompanyId { get; set; }
        public string Product { get; set; }
        public string InvoiceType { get; set; }
        public string Category { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        //public decimal CardFees { get; set; }
        public int NumberOfLife { get; set; }
        public decimal FinalCardFees { get; set; }
        public int DaysDifference { get; set; }
        public decimal amount { get; set; }
    }
}
