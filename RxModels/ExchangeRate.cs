using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class ExchangeRate
    {
        public int Id { get; set; }
        public string Currency { get; set; }
        public double? ExchangeRate1 { get; set; }
        public string Username { get; set; }
        public DateTime? DateTime { get; set; }
        public string EmployerId { get; set; }
    }
}
