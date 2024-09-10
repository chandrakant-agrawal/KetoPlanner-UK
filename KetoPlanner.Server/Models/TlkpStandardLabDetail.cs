using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TlkpStandardLabDetail
{
    public int LabId { get; set; }

    public int? LabTypeId { get; set; }

    public string? LabName { get; set; }

    public string? Units { get; set; }

    public string? Range { get; set; }

    public int? OrgId { get; set; }
}
