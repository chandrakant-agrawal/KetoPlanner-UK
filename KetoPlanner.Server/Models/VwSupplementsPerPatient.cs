using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwSupplementsPerPatient
{
    public int PatientId { get; set; }

    public float? SuppleValue { get; set; }

    public string? Supplement { get; set; }

    public float SupAmount { get; set; }

    public string? Units { get; set; }

    public string? Instructions { get; set; }

    public float CarbContent { get; set; }

    public float? SupCalc { get; set; }
}
