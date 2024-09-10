using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblHelpLine
{
    public int HelplineId { get; set; }

    public DateTime? QuestionDate { get; set; }

    public string? Question { get; set; }

    public string? Response { get; set; }

    public int? OrgId { get; set; }

    public bool Notify { get; set; }

    public string? UserAsking { get; set; }
}
