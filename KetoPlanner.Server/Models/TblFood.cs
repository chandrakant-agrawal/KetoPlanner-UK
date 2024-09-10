using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblFood
{
    public int FoodId { get; set; }

    public int? CategoryId { get; set; }

    public string? FoodItem { get; set; }

    public float? FoodGrams { get; set; }

    public float? FoodPro { get; set; }

    public float? FoodFat { get; set; }

    public float? FoodCarb { get; set; }

    public float? FoodFibre { get; set; }

    public bool Liquid { get; set; }

    public int? OrgId { get; set; }

    public DateTime? LastUpdated { get; set; }

    public int? PatientId { get; set; }

    public int? IsShared { get; set; }

    public string? FoodCode { get; set; }

    public bool? IsSharedPatient { get; set; }
}
