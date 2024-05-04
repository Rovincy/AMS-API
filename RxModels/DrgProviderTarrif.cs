using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class DrgProviderTarrif
    {
        public long Id { get; set; }
        public string InsCompany { get; set; }
        public int? ProviderId { get; set; }
        public string DiseaseGrp { get; set; }
        public int? DiseaseId { get; set; }
        public string DiseaseCode { get; set; }
        public string DiseaseName { get; set; }
        public double? DiseasePrice { get; set; }
    }
}
