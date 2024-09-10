using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwActualFoodTotal
{
    public int MealId { get; set; }

    public double? TotLiq { get; set; }

    public double? TotCal { get; set; }

    public double? TotFat { get; set; }

    public double? TotPro { get; set; }

    public double? TotCarb { get; set; }
}
