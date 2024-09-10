using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwActualRecipeFood
{
    public short? RecipePerDay { get; set; }

    public float? Cal { get; set; }

    public double? Units { get; set; }

    public float? Fat { get; set; }

    public float? Pro { get; set; }

    public float? Carb { get; set; }

    public float? SnacksFat { get; set; }

    public float? SnacksPro { get; set; }

    public float? SnacksCarb { get; set; }

    public float? SnacksCal { get; set; }

    public string? CalRatio { get; set; }

    public float? CreamCarb { get; set; }

    public int? PatientId { get; set; }

    public DateTime? DietDate { get; set; }

    public float? PerManualCalorie { get; set; }

    public float? PerManualFat { get; set; }

    public float? PerManualPro { get; set; }

    public float? PerManualCarb { get; set; }
}
