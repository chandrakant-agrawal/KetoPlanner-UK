using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblSharedRecipe
{
    public int? UserId { get; set; }

    public bool? IsApproved { get; set; }

    public string? UserName { get; set; }

    public int? RecipeId { get; set; }

    public bool? Caregiver { get; set; }
}
