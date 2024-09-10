using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblLabsPerPatient
{
    public int PatientLabId { get; set; }

    public int? PatientId { get; set; }

    public DateTime? LabDate { get; set; }
}
