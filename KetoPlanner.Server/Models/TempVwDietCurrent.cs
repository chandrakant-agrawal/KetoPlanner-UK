using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TempVwDietCurrent
{
    public int DietId { get; set; }

    public float? IdealWeight { get; set; }

    public float? ActualCal { get; set; }

    public string? RatioList { get; set; }

    public string? AgeRangeList { get; set; }

    public float? DietaryUnits { get; set; }

    public float? DailyFat { get; set; }

    public float? DailyPro { get; set; }

    public float? DailyCarb { get; set; }

    public short? MealsPerDay { get; set; }

    public DateTime? DietDate { get; set; }

    public string? CalRatio { get; set; }

    public int? AgeId { get; set; }

    public string? Comment { get; set; }

    public string? FeedRoute { get; set; }

    public float? RecLowCal { get; set; }

    public float? RecHighCal { get; set; }

    public double? MealFat { get; set; }

    public double? MealPro { get; set; }

    public double? MealCarb { get; set; }

    public double? MealUnits { get; set; }

    public string? AgeRange { get; set; }

    public int PatientId { get; set; }

    public int? SnackCal { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public int OrgId { get; set; }

    public string? Email { get; set; }

    public string? OrgEmail { get; set; }
}
