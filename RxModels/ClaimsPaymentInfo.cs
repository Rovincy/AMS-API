using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class ClaimsPaymentInfo
    {
        public int Id { get; set; }
        public string InsCompany { get; set; }
        public int? ServiceProviderId { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentDetails { get; set; }
        public string ChequeDetails { get; set; }
        public string DrCr { get; set; }
        public string Currency { get; set; }
        public double? AmountPaid { get; set; }
        public string ReceiptNo { get; set; }
        public int? UserId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? ClaimId { get; set; }
        public string IssuedBy { get; set; }
        public string ApprovedBy { get; set; }
        public string RecievedBy { get; set; }
        public string BankName { get; set; }
        public string BankCode { get; set; }
        public string BatchNo { get; set; }
        public string CheqNo { get; set; }
        public DateTime? CheqDate { get; set; }
    }
}
