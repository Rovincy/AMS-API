using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class UsersLoginLog
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Status { get; set; }
        public string IpAddress { get; set; }
    }
}
