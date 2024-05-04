namespace DCI_TSP_API.Dto.Parents
{
    public class ParentCreateDto
    {
        public int Id { get; set; }

        public int? FatherId { get; set; }

        public int? MotherId { get; set; }

        public int? ParentRoleId { get; set; }

        public int? ChildId { get; set; }
    }
}
