using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class VwSnackStdWithFood
{
    public string? FoodItem { get; set; }

    public int? FoodId { get; set; }

    public int StanSnack { get; set; }

    public string? StanName { get; set; }

    public string? Instructions { get; set; }

    public float? DefGrams { get; set; }
}
