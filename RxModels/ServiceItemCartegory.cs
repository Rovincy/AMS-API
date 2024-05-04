using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class ServiceItemCartegory
    {
        public int Id { get; set; }
        public string CartegoryName { get; set; }
        public string CartegoryCode { get; set; }
        public string GeneralCartegoryCode { get; set; }
    }
}
