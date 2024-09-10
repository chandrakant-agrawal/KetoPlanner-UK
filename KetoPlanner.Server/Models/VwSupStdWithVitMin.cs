using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwSupStdWithVitMin
{
    public int SupplementId { get; set; }

    public string? Supplement { get; set; }

    public float SupAmount { get; set; }

    public string? Units { get; set; }

    public string? Instructions { get; set; }

    public DateTime? LastUpdated { get; set; }

    public int? VitMinId { get; set; }

    public float? SuppleValue { get; set; }

    public string? VitMinDesc { get; set; }

    public float CarbContent { get; set; }

    public float? SeqNo { get; set; }
}
