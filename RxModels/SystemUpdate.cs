using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class SystemUpdate
    {
        public int Id { get; set; }
        public string TypeOfUpdates { get; set; }
        public string Area { get; set; }
        public string Type { get; set; }
    }
}
