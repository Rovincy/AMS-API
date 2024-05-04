using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class ProviderApiReview
    {
        public int ReviewId { get; set; }
        public int ReviewerId { get; set; }
        public int ProviderId { get; set; }
        public byte Rating { get; set; }
        public string ReviewDescription { get; set; }
    }
}
