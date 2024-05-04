using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class MemberDependent
    {
        public int Id { get; set; }
        public string InsCompany { get; set; }
        public int? MemberId { get; set; }
        public string Surname { get; set; }
        public string Othernames { get; set; }
        public string MemberNo { get; set; }
        public int? PrefixId { get; set; }
        public string Relationship { get; set; }
        public DateTime? Dob { get; set; }
        public string PicturePath { get; set; }
    }
}
