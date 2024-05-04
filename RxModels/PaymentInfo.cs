using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class PaymentInfo
    {
        public int Id { get; set; }
        public string InsCompany { get; set; }
        public int? CompanyId { get; set; }
        public int? BillId { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentDetails { get; set; }
        public string ChequeDetails { get; set; }
        public string Currency { get; set; }
        public double? AmountPaid { get; set; }
        public string ReceiptNo { get; set; }
        public int? UserId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string ReceivedBy { get; set; }
    }
}
