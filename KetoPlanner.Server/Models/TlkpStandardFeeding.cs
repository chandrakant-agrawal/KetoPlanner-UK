using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TlkpStandardFeeding
{
    public DateTime? HourFeeding { get; set; }

    public short? CarbLiquid { get; set; }

    public string? Supplement { get; set; }

    public short? Liquid { get; set; }

    public string? Medications { get; set; }
}
