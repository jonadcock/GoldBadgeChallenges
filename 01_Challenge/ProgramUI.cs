using System;
using System.Collections.Generic;

namespace _01_Challenge
{
    class ProgramUI
    {
        MenuItemRepo _menuItemRepo = new MenuItemRepo();


        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Komodo Cafe User Interface. Press any key and choose one of the following options.");
                Console.ReadKey();

                Console.Clear();
                Console.WriteLine("1. Create menu item\n" +
                    "2. Delete menu item\n" +
                    "3. Display all menu items.");

                string input = Console.ReadLine();
                int choice = int.Parse(input);


                switch (choice)
                {
                    case 1:
                        AddMenuItemToList();
                        break;
                    case 2:
                        DeleteItemFromList();
                        break;
                    case 3:
                        DisplayListOfMenuItems();
                        break;
                        // case 4: running = false
                        //        break;


                }
            }
        }
        private void AddMenuItemToList()
        {
            Menu newMenuItem = new Menu();

            Console.WriteLine("Enter meal number:");
            string mealNumbAsString = Console.ReadLine();
            newMenuItem.MealNumb = int.Parse(mealNumbAsString);

            Console.WriteLine("Enter meal name:");
            newMenuItem.MealName = Console.ReadLine();

            Console.WriteLine("Enter meal description");
            newMenuItem.MealDesc = Console.ReadLine();

            Console.WriteLine("Enter list of ingredients");
            newMenuItem.IngrList = Console.ReadLine();

            Console.WriteLine("Enter meal price");
            string mealPriceAsString = Console.ReadLine();
            newMenuItem.MealPric = decimal.Parse(mealPriceAsString);

            _menuItemRepo.AddMenuItemToList(newMenuItem);
        }
        private void DeleteItemFromList()
        {
            Console.Clear();
            DisplayListOfMenuItems();

            Console.WriteLine("Which menu item would you like to delete?");
            int menuItem = int.Parse(Console.ReadLine());

            _menuItemRepo.RemoveMenuItemBySpecifications(menuItem);

            Console.WriteLine($"The {menuItem} was successfully removed.");
            Console.ReadKey();

            //Console.WriteLine($"The {menuItem} was unable to be removed at this time.");
            //Console.ReadKey();
            Console.Clear();
            Run();


        }


        private void DisplayListOfMenuItems()
        {
            List<Menu> menuItemList = _menuItemRepo.GetMenuList();

            foreach (Menu list in menuItemList)
            {
                Console.WriteLine($"#{list.MealNumb}. {list.MealName} is a {list.MealDesc} with {list.IngrList}. Price {list.MealPric}");

                Console.WriteLine();
            }
            Console.ReadKey();

        }

    }

}


