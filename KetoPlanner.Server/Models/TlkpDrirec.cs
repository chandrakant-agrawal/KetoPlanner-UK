using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TlkpDrirec
{
    public int DriageId { get; set; }

    public int VitMinId { get; set; }

    public float? Drilow { get; set; }

    public float? Drihigh { get; set; }
}
