using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwActualMealFood
{
    public int MealId { get; set; }

    public DateTime? MealDate { get; set; }

    public string? Instructions { get; set; }

    public bool Verified { get; set; }

    public short? MealsPerDay { get; set; }

    public string? FoodFacts { get; set; }

    public string? FoodItem { get; set; }

    public float ActGrams { get; set; }

    public double? CalcFat { get; set; }

    public double? CalcPro { get; set; }

    public double? CalcCarb { get; set; }

    public double? CalcCal { get; set; }

    public double? MealCal { get; set; }

    public double? MealUnits { get; set; }

    public double? MealFat { get; set; }

    public double? MealPro { get; set; }

    public double? MealCarb { get; set; }

    public string? CalRatio { get; set; }

    public string? MealName { get; set; }

    public int? MealNumber { get; set; }

    public int FoodId { get; set; }

    public int? CategoryId { get; set; }

    public float? CreamCarb { get; set; }

    public bool Liquid { get; set; }

    public string? ClientName { get; set; }
}
