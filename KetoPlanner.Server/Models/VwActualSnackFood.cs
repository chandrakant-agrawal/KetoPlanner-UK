using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwActualSnackFood
{
    public int SnackId { get; set; }

    public string? SnackName { get; set; }

    public int? PatientId { get; set; }

    public DateTime? SnackDate { get; set; }

    public string? Instructions { get; set; }

    public bool Verified { get; set; }

    public int? SnackNumber { get; set; }

    public string? CalRatio { get; set; }

    public float? SnackFat { get; set; }

    public float? SnackUnits { get; set; }

    public int? SnackCal { get; set; }

    public int FoodId { get; set; }

    public float? SnackGrams { get; set; }

    public double? CalcFat { get; set; }

    public double? CalcUnits { get; set; }

    public double? CalcCal { get; set; }

    public string? FoodItem { get; set; }

    public int? CategoryId { get; set; }

    public string? FoodFacts { get; set; }

    public bool Liquid { get; set; }

    public float? CreamCarb { get; set; }

    public string? ClientName { get; set; }

    public double? CalcPro { get; set; }

    public double? CalcCarb { get; set; }
}
