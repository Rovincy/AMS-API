using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class UsersLog
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Fullname { get; set; }
        public string TableName { get; set; }
        public string Action { get; set; }
        public string DataId { get; set; }
    }
}
