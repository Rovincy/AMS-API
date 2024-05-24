namespace DCI_TSP_API.UserModels
{
    public class Files
    {
        public int Id { get; set; }
        //public string? Name { get; set; }
        public string RefundCode { get; set; }
        public bool? IsApproved { get; set; }
        public string? Path {  get; set; }
        public int UploadedBy { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
