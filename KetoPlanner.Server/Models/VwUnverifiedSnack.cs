using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwUnverifiedSnack
{
    public int PatientId { get; set; }

    public string? PatientName { get; set; }

    public int? UnverifiedSnacks { get; set; }

    public int OrgId { get; set; }
}
