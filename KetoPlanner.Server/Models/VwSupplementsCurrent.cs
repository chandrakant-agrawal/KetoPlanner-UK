using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwSupplementsCurrent
{
    public int PatientId { get; set; }

    public int SupplementId { get; set; }

    public float? SuppleValue { get; set; }

    public string? Supplement { get; set; }

    public string? Units { get; set; }

    public double? SupCarb { get; set; }

    public float CarbFactor { get; set; }
}
