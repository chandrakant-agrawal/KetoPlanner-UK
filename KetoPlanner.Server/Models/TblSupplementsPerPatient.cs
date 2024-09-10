using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblSupplementsPerPatient
{
    public int PatientId { get; set; }

    public int SupplementId { get; set; }

    public float? SuppleValue { get; set; }
}
