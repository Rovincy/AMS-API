using System;
using System.Collections.Generic;

#nullable disable

namespace DCI_TSP_API.RxModels
{
    public partial class SecurityRolesPermission
    {
        public int Id { get; set; }
        public int? PermRoleId { get; set; }
        public int? SecuritylevelId { get; set; }
    }
}
