using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwDietHistory
{
    public int DietId { get; set; }

    public int? PatientId { get; set; }

    public float? IdealWeight { get; set; }

    public float? ActualCal { get; set; }

    public string? CalRatio { get; set; }

    public float? DietaryUnits { get; set; }

    public float? DailyFat { get; set; }

    public float? DailyPro { get; set; }

    public float? DailyCarb { get; set; }

    public short? MealsPerDay { get; set; }

    public DateTime? DietDate { get; set; }

    public string? Comment { get; set; }

    public string? FeedRoute { get; set; }
}
