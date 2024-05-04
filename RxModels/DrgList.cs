using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class DrgList
    {
        public string DrgDiseaseGrp { get; set; }
        public string DrgCode { get; set; }
        public string DrgDiseaseName { get; set; }
        public string Icd10Code { get; set; }
        public string IcdDiseaseName { get; set; }
        public string Level1 { get; set; }
        public string Level2 { get; set; }
        public string Level3 { get; set; }
    }
}
