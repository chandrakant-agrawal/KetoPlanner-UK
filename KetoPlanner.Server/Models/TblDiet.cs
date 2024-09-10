using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblDiet
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

    public int? AgeId { get; set; }

    public string? Comment { get; set; }

    public string? FeedRoute { get; set; }

    public float? DailyMct { get; set; }

    public float? DailyLct { get; set; }

    public float? TotalCalorie { get; set; }

    public float? SnacksCalorie { get; set; }

    public short? SnacksPerDay { get; set; }

    public float? PerMealCalorie { get; set; }

    public float? PerMealFat { get; set; }

    public float? PerMealPro { get; set; }

    public float? PerMealCarb { get; set; }

    public float? PerSnackCalorie { get; set; }

    public float? PerSnackFat { get; set; }

    public float? PerSnackPro { get; set; }

    public float? PerSnackCarb { get; set; }

    public float? DailyCalories { get; set; }

    public bool? IsManualtarget { get; set; }

    public bool? IsManualtargetOnly { get; set; }

    public float? PerManualCalorie { get; set; }

    public float? PerManualFat { get; set; }

    public float? PerManualPro { get; set; }

    public float? PerManualCarb { get; set; }
}
