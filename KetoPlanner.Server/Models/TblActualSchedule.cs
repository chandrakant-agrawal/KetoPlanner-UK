using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblActualSchedule
{
    public int FeedId { get; set; }

    public int HourId { get; set; }

    public short? CarbLiquid { get; set; }

    public string? Supplement { get; set; }

    public short? Liquid { get; set; }

    public string? Medications { get; set; }

    public int? RecipeId { get; set; }

    public string? StanMeal { get; set; }

    public int? FreeWater { get; set; }

    public int? OtherFluids { get; set; }
}
