using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TlkpMedication
{
    public int MedicationId { get; set; }

    public string? Medication { get; set; }

    public string? Prescription { get; set; }

    public float? MedAmount { get; set; }

    public string? Units { get; set; }

    public string? Instructions { get; set; }

    public DateTime? LastUpdated { get; set; }

    public float? CarbContent { get; set; }

    public int? OrgId { get; set; }

    public bool? Shared { get; set; }
}
