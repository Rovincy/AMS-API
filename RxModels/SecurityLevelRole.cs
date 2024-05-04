using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class SecurityLevelRole
    {
        public int Id { get; set; }
        public string SecurityRole { get; set; }
        public double? AuthAmount { get; set; }
    }
}
