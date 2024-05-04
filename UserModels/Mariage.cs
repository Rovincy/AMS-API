using System;
using System.Collections.Generic;

namespace DCI_TSP_API.UserModels;

public partial class Mariage
{
    public int Id { get; set; }

    public int? HusbandId { get; set; }

    public int? WifeId { get; set; }

    public string? MariageLocation { get; set; }

    public DateTime? MariageDate { get; set; }
}
