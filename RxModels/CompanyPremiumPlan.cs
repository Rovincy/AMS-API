using System;

public class CompanyPremiumPlan
{
    public int Id { get; set; }
    public int CompanyId { get; set; }
    public string Product { get; set; }
    public string InvoiceType { get; set; }
    public string Category { get; set; }
    public string InvoiceNumber { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public decimal CardFees { get; set; }
    public int NumberOfLife { get; set; }
    public decimal FinalCardFees { get; set; }
    public int DaysDifference { get; set; }
    public decimal Amount { get; set; }
    public decimal PremiumAmount { get; set; }
    public decimal AmountPerMonth { get; set; }
    public int? Year { get; set; }
    public decimal January { get; set; }
    public decimal February { get; set; }
    public decimal March { get; set; }
    public decimal April { get; set; }
    public decimal May { get; set; }
    public decimal June { get; set; }
    public decimal July { get; set; }
    public decimal August { get; set; }
    public decimal September { get; set; }
    public decimal October { get; set; }
    public decimal November { get; set; }
    public decimal December { get; set; }
}
