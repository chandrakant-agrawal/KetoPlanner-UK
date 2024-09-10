using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblActualMeal
{
    public int MealId { get; set; }

    public int? PatientId { get; set; }

    public string? MealName { get; set; }

    public DateTime? MealDate { get; set; }

    public string? Instructions { get; set; }

    public bool Verified { get; set; }

    public int? MealNumber { get; set; }

    public bool Caregiver { get; set; }
}
