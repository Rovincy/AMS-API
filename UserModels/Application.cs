using System;
using System.Collections.Generic;

namespace DCI_TSP_API.UserModels;

public partial class Application
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Userapplication> Userapplications { get; set; } = new List<Userapplication>();
}
