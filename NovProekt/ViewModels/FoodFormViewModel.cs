using NovProekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NovProekt.ViewModels
{
    public class FoodFormViewModel
    {
        public Food Food { get; set; }
        public IEnumerable<Restaurant> Restaurants { get; set; }
    }
}