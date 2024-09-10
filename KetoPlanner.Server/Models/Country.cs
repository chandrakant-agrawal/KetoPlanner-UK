using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class Country
{
    public int CountryId { get; set; }

    public Guid CountryGuid { get; set; }

    public string Name { get; set; } = null!;

    public string? TwoLetterIsocode { get; set; }

    public string? ThreeLetterIsocode { get; set; }

    public string? NumericIsocode { get; set; }

    public byte Published { get; set; }

    public int DisplayOrder { get; set; }

    public string? ExtensionData { get; set; }

    public DateTime CreatedOn { get; set; }

    public byte PostalCodeRequired { get; set; }

    public string? PostalCodeRegex { get; set; }

    public string? PostalCodeExample { get; set; }
}
