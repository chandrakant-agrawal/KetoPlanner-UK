using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblMedicationsPerPatient
{
    public int PatientId { get; set; }

    public int MedicationId { get; set; }

    public float? MedValue { get; set; }
}
