﻿using FoodOrdering.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodOrdering.Web.ServiceContracts
{
    interface IFoodsService
    {
        List<Food_Items> GetAllFoodItems();
    }
}
