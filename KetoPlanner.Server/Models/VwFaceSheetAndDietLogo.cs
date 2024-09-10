using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwFaceSheetAndDietLogo
{
    public float? ActualCal { get; set; }

    public string? CalRatio { get; set; }

    public DateTime? SheetDate { get; set; }

    public string? Fluids { get; set; }

    public string? Ketones { get; set; }

    public string? Medications { get; set; }

    public int PatientId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Organization { get; set; }

    public string? LogoFileName { get; set; }

    public string? OrgEmail { get; set; }

    public string? Email { get; set; }
}
