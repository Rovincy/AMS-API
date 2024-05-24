namespace DCI_TSP_API.UserModels
{
    public class AmsRefund
    {
        public int? Id { get; set; }
        public string? RefundCode { get; set; }
        public string? BatchCode { get; set; }
        public string? MemberNumber { get; set; }
        public string? PhoneNumber { get; set; }
        public decimal? AmountClaimed { get; set; }
        public decimal? AmountAwarded { get; set; }
        public string? CRMOfficerComments { get; set; }
        public int? RefundOfficer { get; set; }
        public string? RefundOfficerComments { get; set; }
        public DateTime? RefundOfficerTimestamp { get; set; }
        public int? ClaimRefundOfficer { get; set; }
        public string? ClaimRefundOfficerComments { get; set; }
        public string? ClaimRefundOfficerDecision { get; set; }
        public DateTime? ClaimRefundOfficerTimestamp { get; set; }
        public int? AuditOfficer { get; set; }
        public string? AuditOfficerComments { get; set; }
        public string? AuditOfficerDecision { get; set; }
        public DateTime? AuditOfficerTimestamp { get; set; }
        public int? FinanceOfficer { get; set; }
        public string? FinanceOfficerComments { get; set; }
        public DateTime? FinanceOfficerTimestamp { get; set; }
        public int? VettingOfficer { get; set; }
        public string? VettingStatus { get; set; }
        public DateTime? VettingTimestamp { get; set; }
        public int? FrontDeskOfficer { get; set; }
        public DateTime? FrontDeskTimestamp { get; set; }
        public string? Dispatch { get; set; }
        public DateTime? DispatchTimestamp { get; set; }
        public string? Receipient { get; set; }
        public DateTime? ReceptionDate { get; set; }
        public string? PaymentMethod { get; set; }
        public string? CompanyType { get; set; }
        public int? LastWorkedOnBy { get; set; }
        public DateTime? LastWorkedOnAt {get;set;}
    }
}
