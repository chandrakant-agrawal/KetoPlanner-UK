using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwMealPlannerMatrix
{
    public int? PrintDate { get; set; }

    public string? MealCode { get; set; }

    public string? PrintMeal { get; set; }

    public int PatientId { get; set; }

    public DateTime? MealDate { get; set; }

    public int CalendarId { get; set; }

    public short? MealCodeSort { get; set; }
}
