using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblOrgPatientRequest
{
    public long Id { get; set; }

    public long? OrgId { get; set; }

    public string? Status { get; set; }

    public byte[]? InviteEmail { get; set; }
}
