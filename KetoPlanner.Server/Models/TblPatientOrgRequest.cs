using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblPatientOrgRequest
{
    public int Id { get; set; }

    public int? OrgId { get; set; }

    public int? PatientId { get; set; }

    public string? Status { get; set; }
}
