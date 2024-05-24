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
        public string? PrincipalId { get; set; }
        public string? PrincipalFirstname { get; set; }
        public string? PrincipalOthernames { get; set; }
        public string? PrincipalLastname { get; set; }
    }
}
