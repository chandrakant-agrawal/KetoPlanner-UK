using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class InvalidPatientEmail
{
    public int PatientId { get; set; }

    public string? Email { get; set; }
}
