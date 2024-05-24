using System;

namespace DCI_TSP_API.UserModels
{
    public class AmsHsp
    {
        public int? Id { get; set; }
        public int? ProviderId { get; set; }
        public int? UserId { get; set; }
        public string? Status { get; set; }
        public DateTime? LastUpdate { get; set; }
    }
}
