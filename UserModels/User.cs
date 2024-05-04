using System;
using System.Collections.Generic;

namespace DCI_TSP_API.UserModels;

public partial class User
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Gender { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Email { get; set; }

    public int? RoleId { get; set; }

    public virtual Role? Role { get; set; }

    public virtual ICollection<Userapplication> Userapplications { get; set; } = new List<Userapplication>();

    public virtual ICollection<Userrole> Userroles { get; set; } = new List<Userrole>();
}
