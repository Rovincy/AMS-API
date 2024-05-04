using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class ProviderApiPhoto
    {
        public int Id { get; set; }
        public string ProviderId { get; set; }
        public string Photo { get; set; }
    }
}
