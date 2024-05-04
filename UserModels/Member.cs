using System;
using System.Collections.Generic;

namespace DCI_TSP_API.UserModels;

public partial class Member
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public string? PlaceOfBirth { get; set; }

    public int? NationalityId { get; set; }

    public string? TitheUniqueId { get; set; }

    public int? MemberRoleId { get; set; }

    public string? Sex { get; set; }

    public string? Image { get; set; }
}
