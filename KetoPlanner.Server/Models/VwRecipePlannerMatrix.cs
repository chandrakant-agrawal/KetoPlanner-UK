using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwRecipePlannerMatrix
{
    public int? PrintDate { get; set; }

    public string? RecipeCode { get; set; }

    public string? PrintMeal { get; set; }

    public int? PatientId { get; set; }

    public DateTime? RecipeDate { get; set; }

    public int CalendarId { get; set; }

    public short? RecipeCodeSort { get; set; }
}
