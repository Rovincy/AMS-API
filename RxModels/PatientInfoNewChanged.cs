using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class PatientInfoNewChanged
    {
        public long Id { get; set; }
        public string InsCompany { get; set; }
        public string MemberNo { get; set; }
        public string MemberPlan { get; set; }
        public string Surname { get; set; }
        public string Othernames { get; set; }
        public string Sex { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string TelephoneNo { get; set; }
        public string Email { get; set; }
        public string Employer { get; set; }
        public string EmployerId { get; set; }
        public int? CompanyId { get; set; }
        public string EmployerType { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Status { get; set; }
        public string StatusReason { get; set; }
        public string CardSerialNum { get; set; }
        public string MemberId { get; set; }
        public string RxMemberId { get; set; }
        public string NewRxId { get; set; }
        public string PrincipalId { get; set; }
        public string MemberType { get; set; }
        public string RelationshipType { get; set; }
        public string InsertDeleteStatus { get; set; }
        public string UpdateStatus { get; set; }
        public string MemberPlanId { get; set; }
        public double? OutpatientLimit { get; set; }
        public double? InpatientLimit { get; set; }
        public double? OutpatientBalance { get; set; }
        public double? InpatientBalance { get; set; }
        public string OldMemberNo { get; set; }
        public double? OptBalance { get; set; }
        public double? DentalBalance { get; set; }
        public double? EntBalance { get; set; }
        public double? DrugBalance { get; set; }
        public double? LabBalance { get; set; }
        public double? RadBalance { get; set; }
        public double? PhysioBalance { get; set; }
        public double? AdmBalance { get; set; }
        public string BalanceType { get; set; }
        public int? FamilyNumber { get; set; }
        public string PaymentType { get; set; }
        public string PrimaryProviderId { get; set; }
        public string UsePrimaryId { get; set; }
        public string CardPin { get; set; }
        public string ApprovedStatus { get; set; }
        public string Nhis { get; set; }
        public string StaffNo { get; set; }
    }
}
