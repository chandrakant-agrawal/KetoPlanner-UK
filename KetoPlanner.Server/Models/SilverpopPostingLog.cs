using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class SilverpopPostingLog
{
    public int Id { get; set; }

    public string? Event { get; set; }

    public string? Request { get; set; }

    public string? Response { get; set; }

    public DateTime? DateTimeStamp { get; set; }

    public byte[]? Email { get; set; }

    public byte[]? Error { get; set; }
}
