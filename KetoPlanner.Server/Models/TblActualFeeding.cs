using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblActualFeeding
{
    public int FeedId { get; set; }

    public int PatientId { get; set; }

    public DateTime? FeedDate { get; set; }

    public string? Comments { get; set; }
}
