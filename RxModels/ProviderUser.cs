using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class ProviderUser
    {
        public double Id { get; set; }
        public int? ProviderUserDataId { get; set; }
        public string Title { get; set; }
        public string Firstnames { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public int? ProviderId { get; set; }
        public string Security { get; set; }
        public string LicenceNo { get; set; }
    }
}
