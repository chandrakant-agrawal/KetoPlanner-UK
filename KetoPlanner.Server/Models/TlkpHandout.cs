using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TlkpHandout
{
    public int DocId { get; set; }

    public string? HandTitle { get; set; }

    public string? HandDocLoc { get; set; }
}
