using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwFaceSheetAndDiet
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
}
