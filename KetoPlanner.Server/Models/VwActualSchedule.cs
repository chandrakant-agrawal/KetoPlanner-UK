using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwActualSchedule
{
    public int FeedId { get; set; }

    public int PatientId { get; set; }

    public DateTime? FeedDate { get; set; }

    public string? Comments { get; set; }

    public DateTime DefHours { get; set; }

    public int HourId { get; set; }

    public short? CarbLiquid { get; set; }

    public string? Supplement { get; set; }

    public short? Liquid { get; set; }

    public string? Medications { get; set; }

    public string? FeedRoute { get; set; }

    public float? IdealWeight { get; set; }

    public int? RecipeId { get; set; }

    public string? StanMeal { get; set; }

    public string RecipeName { get; set; } = null!;

    public int? FreeWater { get; set; }

    public int? OtherFluids { get; set; }

    public string RecFluid { get; set; } = null!;

    public string? RecCc { get; set; }
}
