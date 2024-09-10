using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwCalcage
{
    public int PatientId { get; set; }

    public string? Gender { get; set; }

    public DateTime? Dob { get; set; }

    public int? CalcYears { get; set; }

    public int? Checkmo { get; set; }

    public int? Checkday { get; set; }

    public int? Checkyear { get; set; }

    public int DefaultAgeId { get; set; }

    public int DefaultDriageId { get; set; }
}
