using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwActualRecipe
{
    public int RecipeId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? Directions { get; set; }

    public string? Tags { get; set; }

    public int? RecipeCategoryId { get; set; }

    public float? Calories { get; set; }

    public float? Fat { get; set; }

    public float? Protein { get; set; }

    public float? Carbohydrate { get; set; }

    public string? Ratio { get; set; }

    public string? ImageName { get; set; }

    public string? ImageFileName { get; set; }

    public string? AdditionalInfo { get; set; }

    public bool? IsFeatured { get; set; }

    public bool? IsShared { get; set; }

    public int? OrgId { get; set; }

    public DateTime? AddedOn { get; set; }

    public bool DisplayOnHomePage { get; set; }

    public bool? IsFavoriteRecipe { get; set; }

    public int? PatientId { get; set; }
}
