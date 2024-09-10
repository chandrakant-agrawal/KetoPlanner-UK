using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblEvent
{
    public int EvId { get; set; }

    public DateTime EvDate { get; set; }

    /// <summary>
    /// Abbreviated event name for calendar
    /// </summary>
    public string EvAbbr { get; set; } = null!;

    /// <summary>
    /// Full event title
    /// </summary>
    public string? EvTitle { get; set; }

    public string? EvNotes { get; set; }

    /// <summary>
    /// Is there online registration?
    /// </summary>
    public bool OnlineRegister { get; set; }

    /// <summary>
    /// hyperlink for event related site (if any)
    /// </summary>
    public string? EvLink { get; set; }

    /// <summary>
    /// Event phone number
    /// </summary>
    public string? EvPhone { get; set; }

    /// <summary>
    /// Location of event
    /// </summary>
    public string? EvLocation { get; set; }

    /// <summary>
    /// Org to show this event (0=all)
    /// </summary>
    public int OrgId { get; set; }

    /// <summary>
    /// City of event
    /// </summary>
    public string? EvCity { get; set; }

    /// <summary>
    /// State/Province of event
    /// </summary>
    public string? EvState { get; set; }
}
