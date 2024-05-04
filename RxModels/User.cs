using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class User
    {
        public double Id { get; set; }
        public string Title { get; set; }
        public string Firstnames { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public int? ProviderId { get; set; }
        public string InsCompany { get; set; }
        public string Security { get; set; }
        public string LicenceNo { get; set; }
        public int? PermRoleId { get; set; }
        public string Lastloginip { get; set; }
        public DateTime? PasswordExpirydate { get; set; }
        public int? LoginAttempt { get; set; }
        public string Status { get; set; }
        public string ChangePswdRequired { get; set; }
        public string PasswordResetToken { get; set; }
        public bool? Firsttime { get; set; }
        public string Securitystaff { get; set; }
        public int PostalId { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Postcode { get; set; }
        public string Shortname { get; set; }
        public string Prefix { get; set; }
        public string Company { get; set; }
    }
}
