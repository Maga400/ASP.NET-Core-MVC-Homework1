using ASP.NET_Core_MVC_Homework1.Entities;
using ASP.NET_Core_MVC_Homework1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_MVC_Homework1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(GetAllData());
        }
        public IActionResult Drinks()
        {
            return View(AllDrinks());
        }
        public IActionResult FastFoods()
        {
            return View(AllFastFoods());
        }
        public IActionResult HotMeals()
        {
            return View(AllHotMeals());
        }
        public List<Drink> AllDrinks() 
        {
            List<Drink> drinks = new List<Drink>()
            {
                new Drink(1,"Coca Cola","bad drink",3),
                new Drink(2,"Fanta","simple drink",2),
                new Drink(3,"Sprite","normal drink",4),
            };

            return drinks;
        }

        public List<FastFood> AllFastFoods()
        {
            List<FastFood> fastFoods = new List<FastFood>()
            {
                new FastFood(1,"Nuggets","Very jummy food",6,2),
                new FastFood(2,"Free","jummy food",3,1),
                new FastFood(3,"Fried Chicken","Very taisty food",10,5),

            };

            return fastFoods;
        }

        public List<HotMeal> AllHotMeals()
        {
            List<HotMeal> hotMeals = new List<HotMeal>()
            {
                new HotMeal(1,"Hot dog","normal",3,2),
                new HotMeal(2,"Sausage","jummy",15,3),
                new HotMeal(3,"Egg","standart hot meal",12,5),

            };

            return hotMeals;
        }
        public AllFoodsViewModel GetAllData()
        {
            var allFoods = new AllFoodsViewModel(AllDrinks(), AllFastFoods(), AllHotMeals());
            return allFoods;
        }

    }
}
