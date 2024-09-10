using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TlkpMaintenance
{
    public string? TableName { get; set; }

    public string? PageName { get; set; }

    public bool Admin { get; set; }

    public string? MaintainName { get; set; }
}
