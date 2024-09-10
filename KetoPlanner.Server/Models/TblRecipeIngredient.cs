using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblRecipeIngredient
{
    public int? RecipeId { get; set; }

    public int? FoodId { get; set; }

    public string? FoodItem { get; set; }

    public string? Unit { get; set; }

    public float? Quantity { get; set; }

    public int? AddedBy { get; set; }

    public DateTime? AddedOn { get; set; }

    public int IngredientId { get; set; }
}
