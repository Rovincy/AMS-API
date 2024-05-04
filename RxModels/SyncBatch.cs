using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class SyncBatch
    {
        public int Id { get; set; }
        public string BatchNo { get; set; }
        public string DataTable { get; set; }
        public string Action { get; set; }
        public string Completion { get; set; }
        public bool? Status { get; set; }
        public byte? Init { get; set; }
    }
}
