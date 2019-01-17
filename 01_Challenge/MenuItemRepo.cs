using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Challenge
{
    public class MenuItemRepo
    {
        List<Menu> listOfMenuItems = new List<Menu>();

        public void AddMenuItemToList(Menu menuItem)
        {
            listOfMenuItems.Add(menuItem);
        }

        public void RemoveMenuItemFromList(Menu menuItem)
        {
            listOfMenuItems.Remove(menuItem);
        }
        public void RemoveMenuItemBySpecifications(int menuItem)
        {
            foreach(Menu menu in listOfMenuItems)
            {
                if (menu.MealNumb == menuItem)
                {
                    RemoveMenuItemFromList(menu);

                        break;
                }
            }
        }

        public List<Menu> GetMenuList()
        {
            return listOfMenuItems;
        }

    }
}
