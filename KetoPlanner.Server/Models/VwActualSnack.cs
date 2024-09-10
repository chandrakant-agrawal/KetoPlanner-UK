using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwActualSnack
{
    public int SnackId { get; set; }

    public string? SnackName { get; set; }

    public int? PatientId { get; set; }

    public DateTime? SnackDate { get; set; }

    public string? Instructions { get; set; }

    public bool Verified { get; set; }

    public int? SnackNumber { get; set; }

    public int? DietSnackId { get; set; }

    public string? ClientName { get; set; }

    public string? SnackDisplay { get; set; }
}
