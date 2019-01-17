using System;
using _01_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _01_Challenge_Tests
{
    [TestClass]
    public class MenuItemRepository_Tests
    {
        [TestMethod]
        public void MenuItemRepo_AddMenuItemToList_ShouldBeCorrect()
        {
            //Arrange
            Menu item = new Menu();
            Menu itemTwo = new Menu();
            MenuItemRepo repo = new MenuItemRepo();

            //Act
            repo.AddMenuItemToList(item);
            repo.AddMenuItemToList(itemTwo);

            int actual = repo.GetMenuList().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MenuItemRepo_RemoveMenuItemFromList_ShouldBeCorrect()
        {
            //Arrange
            MenuItemRepo itemRepo = new MenuItemRepo();
            Menu item = new Menu();
            Menu itemTwo = new Menu();
            Menu itemThree = new Menu();

            itemRepo.AddMenuItemToList(item);
            itemRepo.AddMenuItemToList(itemTwo);
            itemRepo.AddMenuItemToList(itemThree);

            itemRepo.RemoveMenuItemFromList(item);

            //Act

            int actual = itemRepo.GetMenuList().Count;
            int expected = 2;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MenuItemRepo_RemoveMenuItemBySpecification_ShouldBeCorrect()
        {
            MenuItemRepo itemRepo = new MenuItemRepo();
            Menu item = new Menu("chips", 1, "super chips", "fried potatos", "oil and potatos", 1.50m);
            Menu itemTwo = new Menu("chips", 1, "super chips", "fried potatos", "oil and potatos", 1.50m);
            Menu itemThree = new Menu("chips", 1, "super chips", "fried potatos", "oil and potatos", 1.50m);

            itemRepo.AddMenuItemToList(item);
            itemRepo.AddMenuItemToList(itemTwo);
            itemRepo.AddMenuItemToList(itemThree);
            itemRepo.RemoveMenuItemBySpecifications(itemTwo.MealNumb);

            int actual = itemRepo.GetMenuList().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);


        }


        
    }
}
