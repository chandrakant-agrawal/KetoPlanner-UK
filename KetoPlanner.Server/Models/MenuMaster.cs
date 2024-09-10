using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class MenuMaster
{
    public int MenuId { get; set; }

    public string MenuName { get; set; } = null!;

    public int? MenuParentId { get; set; }

    public string? MenuUrl { get; set; }

    public int? Role { get; set; }
}
