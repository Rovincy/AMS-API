using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class ServiceSpeciality
    {
        public string NatureOfVisit { get; set; }
        public string Speciality { get; set; }
        public string SpecCode { get; set; }
        public int Id { get; set; }
        public string FieldName { get; set; }
    }
}
