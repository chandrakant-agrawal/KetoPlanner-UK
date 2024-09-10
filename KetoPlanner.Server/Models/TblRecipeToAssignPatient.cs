using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblRecipeToAssignPatient
{
    public int PatientRecipeId { get; set; }

    public int? RecipeId { get; set; }

    public int? PatientId { get; set; }

    public DateTime? RecipeDate { get; set; }

    public string? Instructions { get; set; }

    public int? OrgId { get; set; }

    public string? CalRatio { get; set; }

    public float? RecipeFat { get; set; }

    public string? RecipeUnits { get; set; }

    public float? RecipeCal { get; set; }

    public bool? OldRecipe { get; set; }

    public float? RecipePro { get; set; }

    public float? RecipeCarb { get; set; }

    public string? RecipeName { get; set; }

    public int? NewRecipeId { get; set; }
}
