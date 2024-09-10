using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwMedicationsPerPatient
{
    public int PatientId { get; set; }

    public int MedicationId { get; set; }

    public string? Medication { get; set; }

    public string? Prescription { get; set; }

    public float? MedValue { get; set; }

    public string? Units { get; set; }

    public string? Instructions { get; set; }

    public float? CarbContent { get; set; }

    public double? MedCarb { get; set; }

    public float? CarbFactor { get; set; }
}
