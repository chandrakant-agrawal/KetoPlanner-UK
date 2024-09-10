using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwRecipeCalendar
{
    public string? DayDesc { get; set; }

    public string? RecipeCode { get; set; }

    public string? PrintMeal { get; set; }

    public int DayNumber { get; set; }

    public int? PatientId { get; set; }

    public DateTime? RecipeDate { get; set; }

    public int? CalendarId { get; set; }

    public string? RecipeCodeSort { get; set; }
}
