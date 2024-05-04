using System;

namespace DCI_TSP_API.RxModels
{
    public class PatientInfo
    {
        public long Id { get; set; }
        public string? MemberNo { get; set; }
        public string? Surname { get; set; }
        public string? Firstname { get; set; }
        public string? Othernames { get; set; }
        public string? EmployerId { get; set; }
    }
}
