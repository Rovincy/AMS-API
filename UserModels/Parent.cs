using System;
using System.Collections.Generic;

namespace DCI_TSP_API.UserModels;

public partial class Parent
{
    public int Id { get; set; }

    public int? FatherId { get; set; }

    public int? MotherId { get; set; }

    public int? ParentRoleId { get; set; }

    public int? ChildId { get; set; }
}
