namespace DCI_TSP_API.Dto.Members
{
    public class MembersCreateDto
    {
        public string? FirstName { get; set; }

        public string? MiddleName { get; set; }

        public string? LastName { get; set; }

        public string? Email { get; set; }

        public DateTime? DateOfBirth { get; set; }
        public int? NationalityId { get; set; }

        public string? TitheUniqueId { get; set; }

        public int? MemberRoleId { get; set; }

        public string? Sex { get; set; }

        public string? Image { get; set; }

        public string? PlaceOfBirth { get; set; }
        public IFormFile? ImageFile { get; set; }

        //Parent Dto
        public int? FatherId { get; set; }
        public int? MotherId { get; set; }
        public int? ParentRoleId { get; set; }
        public int? ChildId { get; set; }

        ////Mariage Dto
        //public int? HusbandId { get; set; }
        //public int? WifeId { get; set; }
        //public string? MariageLocation { get; set; }
        //public DateTime? MariageDate { get; set; }
    }
}
