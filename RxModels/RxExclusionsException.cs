using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class RxExclusionsException
    {
        public int Id { get; set; }
        public string InsCompany { get; set; }
        public string RxCode { get; set; }
        public string RxArea { get; set; }
        public string RxAreaCode { get; set; }
        public string RxItemName { get; set; }
        public string RxItemId { get; set; }
        public string RxPaymentType { get; set; }
        public string ApplicableArea { get; set; }
        public string ProviderId { get; set; }
        public string ProviderIdMaster { get; set; }
        public string ItemStatus { get; set; }
    }
}
