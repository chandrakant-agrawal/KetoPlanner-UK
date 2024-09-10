using System;
using System.Collections.Generic;

namespace KetoPlanner.Server.Models;

public partial class TblActualFood
{
    public int MealId { get; set; }

    public int FoodId { get; set; }

    public float ActGrams { get; set; }
}
