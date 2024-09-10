using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwActualSnacksVerified
{
    public int SnackId { get; set; }

    public string? SnackName { get; set; }

    public string? Instructions { get; set; }

    public bool Verified { get; set; }

    public int? SnackNumber { get; set; }

    public float? SnackGrams { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? Organization { get; set; }

    public string? LogoFileName { get; set; }

    public string? FoodItem { get; set; }

    public string? CalRatio { get; set; }

    public int? SnackCal { get; set; }

    public int? PatientId { get; set; }

    public string? Email { get; set; }

    public string? OrgEmail { get; set; }

    public bool? Caregiver { get; set; }

    public int? CategoryId { get; set; }
}
