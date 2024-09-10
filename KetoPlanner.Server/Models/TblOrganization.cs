using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblOrganization
{
    public int OrgId { get; set; }

    public DateTime? Expiration { get; set; }

    public bool Admin { get; set; }

    public string? LogoFileName { get; set; }

    public string? OrgState { get; set; }

    public string? OrgCountry { get; set; }

    public DateTime? LastLogon { get; set; }

    public bool? IsAllow { get; set; }

    public byte? SendToSilverPop { get; set; }

    public string? SilverPopRecipientId { get; set; }

    public DateTime? AllowedOn { get; set; }

    public bool? DisableMsg { get; set; }

    public bool? IsEmployee { get; set; }

    public bool? UpcomingEvents { get; set; }

    public int? IsCookies { get; set; }

    public int? IsRecipes { get; set; }

    public DateTime? IsRecipesDate { get; set; }

    public string? InActive { get; set; }

    public byte[]? Organization { get; set; }

    public byte[]? OrgUserName { get; set; }

    public byte[]? OrgPword { get; set; }

    public byte[]? OrgIdshs { get; set; }

    public byte[]? OrgContact { get; set; }

    public byte[]? OrgEmail { get; set; }

    public byte[]? OrgAddress { get; set; }

    public byte[]? OrgAddress2 { get; set; }

    public byte[]? OrgCity { get; set; }

    public byte[]? OrgPhone { get; set; }

    public byte[]? OrgPostalCode { get; set; }

    public byte[]? FirstName { get; set; }

    public byte[]? LastName { get; set; }
}
