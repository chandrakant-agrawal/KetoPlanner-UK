using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TlkpFaqCategory
{
    public short FaqCatId { get; set; }

    public string? FaqCategory { get; set; }

    public bool Caregiver { get; set; }
}
