using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TlkpSupplement
{
    public int SupplementId { get; set; }

    public string? Supplement { get; set; }

    public float SupAmount { get; set; }

    public string? Units { get; set; }

    public string? Instructions { get; set; }

    public DateTime? LastUpdated { get; set; }

    public float CarbContent { get; set; }

    public int? OrgId { get; set; }

    public bool? Shared { get; set; }
}
