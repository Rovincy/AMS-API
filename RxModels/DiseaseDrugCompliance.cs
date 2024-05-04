using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class DiseaseDrugCompliance
    {
        public long Id { get; set; }
        public string DiseaseCode { get; set; }
        public int? DiseaseId { get; set; }
        public string DiseaseName { get; set; }
        public string Drugclass { get; set; }
        public string DrugClassCode { get; set; }
        public string Atccode1 { get; set; }
        public string Atccode2 { get; set; }
        public string Atccode3 { get; set; }
        public string Atccode4 { get; set; }
        public string GenericName { get; set; }
        public string Drugname { get; set; }
        public int? Maxpreamble { get; set; }
        public string InsCompany { get; set; }
    }
}
