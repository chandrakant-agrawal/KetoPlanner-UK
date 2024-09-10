using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblPatientOrg
{
    public int Id { get; set; }

    public int? OrgId { get; set; }

    public int? PatientId { get; set; }
}
