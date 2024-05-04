using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class MemberReportsGraph
    {
        public int Id { get; set; }
        public string Reportname { get; set; }
        public string Reportcode { get; set; }
        public int? Reportorder { get; set; }
        public string Typeofrep { get; set; }
    }
}
