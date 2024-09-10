using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwSnackDietCurrent
{
    public int DietSnackId { get; set; }

    public int? PatientId { get; set; }

    public DateTime? SnackStart { get; set; }

    public string? CalRatio { get; set; }

    public float? SnackFat { get; set; }

    public float? SnackUnits { get; set; }

    public int? SnackCal { get; set; }

    public string? RatioList { get; set; }
}
