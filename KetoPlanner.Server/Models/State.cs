using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class State
{
    public int StateId { get; set; }

    public Guid StateGuid { get; set; }

    public string Name { get; set; } = null!;

    public int? CountryId { get; set; }

    public string Abbreviation { get; set; } = null!;

    public byte Published { get; set; }

    public int DisplayOrder { get; set; }

    public string? ExtensionData { get; set; }

    public DateTime CreatedOn { get; set; }

    public bool? IsRestrictedForShipment { get; set; }
}
