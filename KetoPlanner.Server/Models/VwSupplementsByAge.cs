using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwSupplementsByAge
{
    public int SupplementId { get; set; }

    public string? Supplement { get; set; }

    public int DriageId { get; set; }

    public float? SupAmount { get; set; }

    public string? Units { get; set; }

    public string? UnitText { get; set; }
}
