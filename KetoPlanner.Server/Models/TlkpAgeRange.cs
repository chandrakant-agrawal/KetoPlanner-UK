using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TlkpAgeRange
{
    public string? AgeRange { get; set; }

    public int AgeId { get; set; }

    public int? CalLow { get; set; }

    public int? CalHigh { get; set; }

    public float? Protein { get; set; }

    public decimal AgeFrom { get; set; }

    public decimal AgeTo { get; set; }

    public string? Gender { get; set; }
}
