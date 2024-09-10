using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblMealCalendar
{
    public int CalendarId { get; set; }

    public int PatientId { get; set; }

    public int MealId { get; set; }

    public int MealCodeId { get; set; }

    public DateTime? MealDate { get; set; }

    public int SnackId { get; set; }
}
