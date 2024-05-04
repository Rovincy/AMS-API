using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class MembersDeactivate
    {
        public int Id { get; set; }
        public string InsCompany { get; set; }
        public int? MemberId { get; set; }
        public string Surname { get; set; }
        public string Othernames { get; set; }
        public string MemberNo { get; set; }
        public string MemberTel { get; set; }
        public string Employer { get; set; }
        public string MemberPlan { get; set; }
        public int? UserId { get; set; }
        public string UserFullname { get; set; }
    }
}
