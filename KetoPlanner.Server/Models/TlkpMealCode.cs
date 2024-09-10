using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TlkpMealCode
{
    public int MealCodeId { get; set; }

    public string? MealCode { get; set; }

    public short MealCodeSort { get; set; }
}
