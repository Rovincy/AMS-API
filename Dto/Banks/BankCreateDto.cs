namespace DCI_TSP_API.Dto.Banks
{
    public class BankCreateDto
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string BranchName { get; set; } = null!;
    }
}
