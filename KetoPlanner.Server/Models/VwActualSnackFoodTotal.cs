using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwActualSnackFoodTotal
{
    public double? TotLiq { get; set; }

    public double? TotCal { get; set; }

    public double? TotFat { get; set; }

    public double? TotUnits { get; set; }

    public int SnackId { get; set; }
}
