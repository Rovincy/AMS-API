using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class ClaimsDetailsAuthCode
    {
        public long Id { get; set; }
        public string InsCompany { get; set; }
        public string ProviderId { get; set; }
        public string ProviderIdMaster { get; set; }
        public string MemberNo { get; set; }
        public string UserId { get; set; }
        public string UserFullname { get; set; }
        public string ProcessClaimNo { get; set; }
        public string InsItemCode { get; set; }
        public int? ItemId { get; set; }
        public string Item { get; set; }
        public string ItemService { get; set; }
        public double? Qty { get; set; }
        public double? UnitPrice { get; set; }
        public string AuthCode { get; set; }
        public string Status { get; set; }
        public int? UserIdRequested { get; set; }
        public string UserNameRequested { get; set; }
    }
}
