using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TlkpRecipeCode
{
    public int RecipeCodeId { get; set; }

    public string? RecipeCode { get; set; }

    public short RecipeCodeSort { get; set; }
}
