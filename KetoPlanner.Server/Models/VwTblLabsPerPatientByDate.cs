using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwTblLabsPerPatientByDate
{
    public int PatientLabId { get; set; }

    public DateTime? LabDate { get; set; }
}
