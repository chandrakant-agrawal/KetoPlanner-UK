using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TlkpSnack
{
    public int StanSnack { get; set; }

    public string? StanName { get; set; }

    public string? Instructions { get; set; }

    public DateTime? LastUpdated { get; set; }
}
