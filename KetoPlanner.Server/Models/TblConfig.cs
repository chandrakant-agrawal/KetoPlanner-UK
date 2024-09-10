using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblConfig
{
    public DateTime? LastUpdate { get; set; }

    public string? FeedingComment { get; set; }

    public string? Fluids { get; set; }

    public string? Ketones { get; set; }

    public string? Medications { get; set; }

    public int? GenMedications { get; set; }

    public string? OrderEmail { get; set; }

    public string? SmtpServer { get; set; }

    public string? WordViewUrl { get; set; }

    public string? ErrorEmail { get; set; }

    public int Id { get; set; }
}
