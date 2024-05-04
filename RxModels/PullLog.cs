using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class PullLog
    {
        public long Id { get; set; }
        public string Process { get; set; }
        public long? Lastpullid { get; set; }
    }
}
