using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    public class Menu
    {
        public string MenuItem { get; set; }
        public int MealNumb { get; set; }
        public string MealName { get; set; }
        public string MealDesc { get; set; }
        public string IngrList { get; set; }
        public decimal MealPric { get; set; }
        
        public Menu(string menuItem, int mealNumb, string mealName, string mealDesc, string ingrList, decimal mealPric)
        {
            MenuItem = menuItem;
            MealNumb = mealNumb;
            MealName = mealName;
            MealDesc = mealDesc;
            IngrList = ingrList;
            MealPric = mealPric;
        }
        public Menu()
        {

        }

    }
}
