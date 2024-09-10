using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwMealsStdWithFood
{
    public int StanMeal { get; set; }

    public int? FoodId { get; set; }

    public string? MealName { get; set; }

    public string? Instructions { get; set; }

    public DateTime? LastUpdated { get; set; }

    public string? FoodItem { get; set; }

    public float? DefGrams { get; set; }

    public short? MealType { get; set; }
}
