using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblClientMedication
{
    public int MedicationId { get; set; }

    public int PatientId { get; set; }

    public string? Medication { get; set; }

    public string? Dosage { get; set; }

    public string? CarbContent { get; set; }
}
