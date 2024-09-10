using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblFaq
{
    public int FaqId { get; set; }

    public short FaqCatId { get; set; }

    public short FaqSubCatId { get; set; }

    public string? FaqQuestion { get; set; }

    public string? FaqResponse { get; set; }

    /// <summary>
    /// Include in screen help?
    /// </summary>
    public bool FaqHelp { get; set; }
}
