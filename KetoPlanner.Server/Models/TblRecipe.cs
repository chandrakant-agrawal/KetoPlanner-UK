using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblRecipe
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

    public string? Author { get; set; }

    public bool? IsHhunit { get; set; }

    public bool? IsReviewed { get; set; }

    public int? ReviewedBy { get; set; }

    public DateTime? ReviewedOn { get; set; }

    public bool? IsAccept { get; set; }

    public bool? IsAgree { get; set; }

    public string? TargetType { get; set; }

    public bool? IsVerifyMailHcp { get; set; }

    public float? Targetfat { get; set; }

    public float? Targetpro { get; set; }

    public float? TargetCarbo { get; set; }

    public string? TargetRatio { get; set; }

    public float? TargetFibre { get; set; }

    public float? TargetCalorie { get; set; }
}
