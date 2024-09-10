using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblRecipeCalendar
{
    public int CalendarId { get; set; }

    public int? PatientId { get; set; }

    public int? RecipeId { get; set; }

    public int? RecipeCodeId { get; set; }

    public DateTime? RecipeDate { get; set; }

    public int? StanMeal { get; set; }
}
