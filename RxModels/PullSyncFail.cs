using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class PullSyncFail
    {
        public int Id { get; set; }
        public long? ItemId { get; set; }
        public string DataTable { get; set; }
    }
}
