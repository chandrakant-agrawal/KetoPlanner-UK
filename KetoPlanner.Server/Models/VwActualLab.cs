using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwActualLab
{
    public string? LabName { get; set; }

    public string? Units { get; set; }

    public string? Range { get; set; }

    public float? LabValue { get; set; }

    public int LabId { get; set; }

    public int? PatientLabId { get; set; }

    public DateTime? LabDate { get; set; }

    public int? LabTypeId { get; set; }
}
