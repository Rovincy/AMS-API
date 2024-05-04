using System;
using System.Collections.Generic;

namespace DCI_TSP_API.UserModels;

public partial class Bank
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string BranchName { get; set; } = null!;
}
