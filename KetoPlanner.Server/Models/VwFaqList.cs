using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwFaqList
{
    public short FaqCatId { get; set; }

    public string? FaqCategory { get; set; }

    public int? FaqId { get; set; }

    public short? FaqSubCatId { get; set; }

    public string? FaqQuestion { get; set; }

    public string? FaqResponse { get; set; }
}
