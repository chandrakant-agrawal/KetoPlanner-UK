using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwRecipeDietCurrent
{
    public int PatientRecipeId { get; set; }

    public int? PatientId { get; set; }

    public DateTime? RecipeDate { get; set; }

    public string? CalRatio { get; set; }

    public float? RecipeFat { get; set; }

    public string? RecipeUnits { get; set; }

    public float? RecipeCal { get; set; }

    public string? RatioList { get; set; }
}
