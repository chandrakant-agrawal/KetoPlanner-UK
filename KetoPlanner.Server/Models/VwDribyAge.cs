using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwDribyAge
{
    public int DriageId { get; set; }

    public int VitMinId { get; set; }

    public float? Drilow { get; set; }

    public float? Drihigh { get; set; }

    public string? VitMinDesc { get; set; }

    public float? SeqNo { get; set; }
}
