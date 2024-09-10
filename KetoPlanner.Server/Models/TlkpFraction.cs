using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TlkpFraction
{
    public string FractionText { get; set; } = null!;

    public float? FractionValue { get; set; }
}
