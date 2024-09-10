using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblActualSnackFood
{
    public int SnackId { get; set; }

    public int FoodId { get; set; }

    public float? SnackGrams { get; set; }
}
