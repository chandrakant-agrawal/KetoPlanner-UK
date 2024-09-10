using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TlkpStandardSupplement
{
    public int DriageId { get; set; }

    public int SupplementId { get; set; }

    public float? SupAmount { get; set; }
}
