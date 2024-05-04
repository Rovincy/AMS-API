using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class SalesAgency
    {
        public int Id { get; set; }
        public string InsCompany { get; set; }
        public string SalesName { get; set; }
        public string AgencyName { get; set; }
        public string AgencyAddress { get; set; }
        public int AgencyTel { get; set; }
        public string ContactPerson { get; set; }
        public int ContactPersonTel { get; set; }
        public string ContactPersonEmail { get; set; }
        public string DefaultCommission { get; set; }
        public string CommissionType { get; set; }
    }
}
