using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblPatient
{
    public int PatientId { get; set; }

    public short StatusId { get; set; }

    public int DietId { get; set; }

    public DateTime? StartDiet { get; set; }

    public DateTime? EndDiet { get; set; }

    public int OrgIdOld { get; set; }

    public string? CaregiverLogin { get; set; }

    public byte? SendToSilverPop { get; set; }

    public string? SilverPopRecipientId { get; set; }

    public string? Country { get; set; }

    public bool? IsCaregiver { get; set; }

    public string? DietVersion { get; set; }

    public string? DietRatio { get; set; }

    public bool? HideMeds { get; set; }

    public bool? HideSupp { get; set; }

    public string? InActive { get; set; }

    public bool? UpcomingEvents { get; set; }

    public int? IsCookies { get; set; }

    public int? IsRecipes { get; set; }

    public DateTime? IsRecipesDate { get; set; }

    public byte[]? FirstName { get; set; }

    public byte[]? MiddleName { get; set; }

    public byte[]? LastName { get; set; }

    public string? Dob { get; set; }

    public byte[]? Email { get; set; }

    public byte[]? Gender { get; set; }

    public byte[]? CaregiverPw { get; set; }

    public byte[]? HomeAddress { get; set; }

    public byte[]? City { get; set; }

    public byte[]? State { get; set; }

    public byte[]? ZipCode { get; set; }

    public byte[]? CaregiverFirstName { get; set; }

    public byte[]? CaregiverLastName { get; set; }
}
