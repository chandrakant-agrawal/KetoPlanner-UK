using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class City
{
    public int? CityId { get; set; }

    public int? StateId { get; set; }

    public string? CityName { get; set; }

    public virtual State? State { get; set; }
}
