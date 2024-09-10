using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwDietCurrent
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

    public short? SnacksPerDay { get; set; }

    public DateTime? DietDate { get; set; }

    public string? CalRatio { get; set; }

    public int? AgeId { get; set; }

    public string? Comment { get; set; }

    public string? FeedRoute { get; set; }

    public float? RecLowCal { get; set; }

    public float? RecHighCal { get; set; }

    public float? MealFat { get; set; }

    public float? MealPro { get; set; }

    public float? MealCarb { get; set; }

    public float? SnacksFat { get; set; }

    public float? SnacksPro { get; set; }

    public float? SnacksCarb { get; set; }

    public double? MealUnits { get; set; }

    public double? SnacksUnits { get; set; }

    public float? DailyMct { get; set; }

    public float? DailyLct { get; set; }

    public float? TotalCalorie { get; set; }

    public float? SnacksCalorie { get; set; }

    public float? MealCal { get; set; }

    public float? SnacksCal { get; set; }

    public string? AgeRange { get; set; }

    public int PatientId { get; set; }

    public int? SnackCal { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public int? OrgId { get; set; }

    public string? Email { get; set; }

    public string? OrgEmail { get; set; }

    public float? DailyCalories { get; set; }

    public bool? IsManualtarget { get; set; }

    public float? PerManualCalorie { get; set; }

    public float? PerManualFat { get; set; }

    public float? PerManualPro { get; set; }

    public float? PerManualCarb { get; set; }

    public bool? IsManualtargetOnly { get; set; }
}
