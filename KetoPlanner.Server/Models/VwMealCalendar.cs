using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwMealCalendar
{
    public string? DayDesc { get; set; }

    public string? MealCode { get; set; }

    public string? PrintMeal { get; set; }

    public int DayNumber { get; set; }

    public int? PatientId { get; set; }

    public DateTime? MealDate { get; set; }

    public int? CalendarId { get; set; }

    public string? MealCodeSort { get; set; }
}
