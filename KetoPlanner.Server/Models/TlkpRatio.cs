using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TlkpRatio
{
    public string DietRatio { get; set; } = null!;

    public float? FatUnits { get; set; }

    public float? Calories { get; set; }

    public float? CarbProCal { get; set; }

    public float? Cpu { get; set; }

    public float? RatioSort { get; set; }

    public float? CreamCarb { get; set; }

    public short RatioId { get; set; }
}
