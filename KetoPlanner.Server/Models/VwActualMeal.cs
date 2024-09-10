using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwActualMeal
{
    public int MealId { get; set; }

    public int? PatientId { get; set; }

    public string? MealName { get; set; }

    public DateTime? MealDate { get; set; }

    public string? Instructions { get; set; }

    public bool Verified { get; set; }

    public int? MealNumber { get; set; }

    public string? ClientName { get; set; }

    public string? MealDisplay { get; set; }
}
