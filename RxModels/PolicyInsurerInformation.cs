using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class PolicyInsurerInformation
    {
        public int Id { get; set; }
        public string InsCompany { get; set; }
        public int? InsurancePolicyId { get; set; }
        public string TypeOfInsurer { get; set; }
        public string Othernames { get; set; }
        public string Surname { get; set; }
        public DateTime? Dateofbirth { get; set; }
        public string Sex { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string PersonalAddress { get; set; }
        public string MaritalStatus { get; set; }
        public string Nationality { get; set; }
        public string Employer { get; set; }
        public string EmployerTel { get; set; }
        public string EmployerAddress { get; set; }
        public string Occupation { get; set; }
        public string Position { get; set; }
        public string TypeOfId { get; set; }
        public string IdNumber { get; set; }
        public int? UserId { get; set; }
    }
}
