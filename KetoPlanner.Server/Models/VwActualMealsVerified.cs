using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwActualMealsVerified
{
    public int? PatientId { get; set; }

    public int? MealNumber { get; set; }

    public float? ActualCal { get; set; }

    public string? CalRatio { get; set; }

    public short? MealsPerDay { get; set; }

    public string? MealName { get; set; }

    public string? Instructions { get; set; }

    public float ActGrams { get; set; }

    public string? FoodItem { get; set; }

    public bool Liquid { get; set; }

    public string? Organization { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public int MealId { get; set; }

    public string? Email { get; set; }

    public string? OrgEmail { get; set; }

    public int? CategoryId { get; set; }

    public string? LogoFileName { get; set; }

    public bool Caregiver { get; set; }
}
