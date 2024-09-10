using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwVitMinValuesCurrent
{
    public int PatientId { get; set; }

    public string? VitMinDesc { get; set; }

    public float? SeqNo { get; set; }

    public float? Drilow { get; set; }

    public double? ActValue { get; set; }

    public float? Drihigh { get; set; }

    public int DriageId { get; set; }
}
