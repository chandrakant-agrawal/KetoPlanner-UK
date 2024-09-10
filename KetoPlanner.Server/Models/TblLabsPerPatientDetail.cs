using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblLabsPerPatientDetail
{
    public int PatientLabId { get; set; }

    public int LabId { get; set; }

    public float? LabValue { get; set; }
}
