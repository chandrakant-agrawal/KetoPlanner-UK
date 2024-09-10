using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblMessageBoard
{
    public int MessageId { get; set; }

    public int PatientId { get; set; }

    public int Hcpid { get; set; }

    public DateTime? TimeStamp { get; set; }

    public bool? Archived { get; set; }

    public string? Sender { get; set; }

    public bool? IsRead { get; set; }

    public DateTime? ReadOn { get; set; }

    public byte[]? Message { get; set; }
}
