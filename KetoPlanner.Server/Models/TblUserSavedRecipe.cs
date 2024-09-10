using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblUserSavedRecipe
{
    public long UserSavedRecipeId { get; set; }

    public int UserId { get; set; }

    public int RecipeId { get; set; }

    public DateTime? EntryDate { get; set; }
}
