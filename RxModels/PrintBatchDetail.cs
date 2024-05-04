using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class PrintBatchDetail
    {
        public int Id { get; set; }
        public int Batchno { get; set; }
        public string Query { get; set; }
        public string Status { get; set; }
    }
}
