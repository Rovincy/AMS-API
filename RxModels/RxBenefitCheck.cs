using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class RxBenefitCheck
    {
        public int Id { get; set; }
        public string RxServiceArea { get; set; }
        public string RxCheckArea { get; set; }
        public string RxCheckAreacode { get; set; }
        public string RxCheckAreaField { get; set; }
    }
}
