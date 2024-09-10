using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class Result
{
    public string? Instructions { get; set; }

    public int? SortOrder { get; set; }

    public int? SupAmount { get; set; }

    public string? Supplement { get; set; }

    public int SupplementId { get; set; }

    public string? Units { get; set; }
}
