using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblHcpinvitation
{
    public int Id { get; set; }

    public DateTime? InvitedOn { get; set; }

    public byte[]? Hcpemail { get; set; }

    public byte[]? PatientEmail { get; set; }

    public byte[]? Comments { get; set; }
}
