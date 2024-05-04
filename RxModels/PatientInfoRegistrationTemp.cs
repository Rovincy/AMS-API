using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class PatientInfoRegistrationTemp
    {
        public long Id { get; set; }
        public string InsCompany { get; set; }
        public string MemberNo { get; set; }
        public string MemberPlan { get; set; }
        public string Surname { get; set; }
        public string Firstname { get; set; }
        public string Othernames { get; set; }
        public string Sex { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? NoOfDependents { get; set; }
        public string TelephoneNo { get; set; }
        public string OtherPhoneNo { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Employer { get; set; }
        public string EmployerId { get; set; }
        public int? CompanyId { get; set; }
        public string EmployerType { get; set; }
        public string Department { get; set; }
        public string Region { get; set; }
        public string Branch { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string Status { get; set; }
        public string StatusReason { get; set; }
        public string CardPin { get; set; }
        public string MemberId { get; set; }
        public string RxMemberId { get; set; }
        public string InsertMemberStatus { get; set; }
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
        public DateTime? JoinDate { get; set; }
        public string PaymentType { get; set; }
        public string PrimaryProviderId { get; set; }
        public string ApprovedStatus { get; set; }
        public string Picpath { get; set; }
        public string StaffNo { get; set; }
        public string Comments { get; set; }
        public string Company { get; set; }
        public string RegistrationStatus { get; set; }
        public string RegisterTag { get; set; }
        public string CountryOfOrigin { get; set; }
        public string DecisionStatus { get; set; }
        public string MemberImportId { get; set; }
        public string BatchNumber { get; set; }
        public string DocumentName { get; set; }
        public string NhiaNumber { get; set; }
        public int? RowNumber { get; set; }
        public int? OnlineId { get; set; }
        public DateTime? BalanceStartDate { get; set; }
    }
}
