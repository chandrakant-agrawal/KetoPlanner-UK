using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class Rating
{
    public int Id { get; set; }

    public short Rating1 { get; set; }

    public int RecipeId { get; set; }
}
