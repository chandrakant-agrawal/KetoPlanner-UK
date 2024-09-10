using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwUnverifiedMeal
{
    public int PatientId { get; set; }

    public string? PatientName { get; set; }

    public int? UnverifiedMeals { get; set; }

    public int OrgId { get; set; }
}
