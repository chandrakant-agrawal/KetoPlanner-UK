using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TlkpMeal
{
    public int StanMeal { get; set; }

    public string? MealName { get; set; }

    public string? Instructions { get; set; }

    public DateTime? LastUpdated { get; set; }

    public short? MealType { get; set; }
}
