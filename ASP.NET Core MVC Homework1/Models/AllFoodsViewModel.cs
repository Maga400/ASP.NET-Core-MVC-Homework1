using ASP.NET_Core_MVC_Homework1.Entities;
using System.Collections.Generic;

namespace ASP.NET_Core_MVC_Homework1.Models
{
    public class AllFoodsViewModel
    {
        public List<Drink> Drinks { get; set; }
        public List<FastFood> FastFoods { get; set; }
        public List<HotMeal> HotMeals { get; set; }

        public AllFoodsViewModel() 
        {
        
        }

        public AllFoodsViewModel(List<Drink> drinks, List<FastFood> fastFoods, List<HotMeal> hotMeals)
        {
            Drinks = drinks;
            FastFoods = fastFoods;
            HotMeals = hotMeals;
        }
    }
}
