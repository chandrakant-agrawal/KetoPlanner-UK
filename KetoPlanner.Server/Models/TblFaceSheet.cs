using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblFaceSheet
{
    public int PatientId { get; set; }

    public DateTime SheetDate { get; set; }

    public string? Fluids { get; set; }

    public string? Ketones { get; set; }

    public string? Medications { get; set; }
}
