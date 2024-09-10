using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwActualSchedulePrint
{
    public int FeedId { get; set; }

    public int PatientId { get; set; }

    public DateTime? FeedDate { get; set; }

    public string? Comments { get; set; }

    public DateTime DefHours { get; set; }

    public int HourId { get; set; }

    public short? CarbLiquid { get; set; }

    public string? Supplement { get; set; }

    public short? Liquid { get; set; }

    public string? Medications { get; set; }

    public string? FeedRoute { get; set; }

    public float? IdealWeight { get; set; }

    public string RecFluid { get; set; } = null!;

    public float? RecCc { get; set; }

    public string? LogoFileName { get; set; }

    public string? Organization { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? OrgEmail { get; set; }
}
