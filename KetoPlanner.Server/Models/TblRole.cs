using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblRole
{
    public int RoleId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }
}
