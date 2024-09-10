using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwActuaRecipeFood
{
    public string? FoodItem { get; set; }

    public double? CalcPro { get; set; }

    public double? CalcCarb { get; set; }

    public double? CalcCal { get; set; }

    public bool Liquid { get; set; }

    public int FoodId { get; set; }

    public int RecipeId { get; set; }

    public string? FoodFacts { get; set; }

    public string? Title { get; set; }

    public bool? IsShared { get; set; }

    public float? Quantity { get; set; }

    public string Units { get; set; } = null!;

    public double? CalcFat { get; set; }

    public string? CatDesc { get; set; }

    public int? CategoryId { get; set; }

    public int? UserId { get; set; }

    public bool? IsApproved { get; set; }

    public string? UserName { get; set; }

    public int IngredientId { get; set; }

    public double? CalcFibre { get; set; }
}
