using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class Sheet1
{
    public string? FoodCode { get; set; }

    public double? CategoryId { get; set; }

    public string? FoodItem { get; set; }

    public double? FoodGrams { get; set; }

    public string? FoodPro { get; set; }

    public string? FoodFat { get; set; }

    public string? FoodCarb { get; set; }

    public double? FoodFibre { get; set; }

    public double? Liquid { get; set; }

    public double? OrgId { get; set; }

    public double? PatientId { get; set; }

    public double? IsShared { get; set; }
}
