using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwFoodsAndCategory
{
    public string? CatDesc { get; set; }

    public int FoodId { get; set; }

    public int? CategoryId { get; set; }

    public string? FoodItem { get; set; }

    public float? FoodGrams { get; set; }

    public float? FoodPro { get; set; }

    public float? FoodFat { get; set; }

    public float? FoodCarb { get; set; }

    public bool Liquid { get; set; }

    public int? OrgId { get; set; }

    public DateTime? LastUpdated { get; set; }

    public double? Calories { get; set; }
}
