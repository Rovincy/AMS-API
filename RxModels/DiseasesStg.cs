using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class DiseasesStg
    {
        public int Id { get; set; }
        public int? Icd10DiseaseId { get; set; }
        public string Icd10Code { get; set; }
        public string Icd10Disease { get; set; }
        public int? Icd10DiseaseGroupId { get; set; }
        public string Icd10DiseaseGroupCode { get; set; }
        public string Icd10BlockCode { get; set; }
        public string TgDiseaseName { get; set; }
        public string Tg1 { get; set; }
        public string Tg2 { get; set; }
        public string Tg3 { get; set; }
        public string Tg4 { get; set; }
    }
}
