using System;
using _03_Challenge;
using _03_Challenge_Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _03_Challenge_Tests
{
    [TestClass]
    public class EventRepo_Tests
    {
        [TestMethod]
        public void EventRepo_AddEventToList_ShouldBeCorrect()
        {
            Event outing = new Event();
            Event outingTwo = new Event();
            EventRepo repo = new EventRepo();

            repo.AddEventToList(outing);
            repo.AddEventToList(outingTwo);

            int actual = repo.GetEventList().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void EventRepo_CalculateAllOutings_ShouldBeCorrect()
        {
            EventRepo eventRepo = new EventRepo();
            Event cost = new Event();
            cost.PerOutCost = 5m;
            Event outing = new Event();
            outing.PerOutCost = 5m;
            Event outingTwo = new Event();
            outingTwo.PerOutCost = 5m;

            eventRepo.AddEventToList(cost);
            eventRepo.AddEventToList(outing);
            eventRepo.AddEventToList(outingTwo);

            decimal actual = eventRepo.CalculateAllOutings();
            decimal expected = 15;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void EventRepo_CalculateByType_ShouldBeCorrect()
        {
            EventRepo eventRepo = new EventRepo();

            Event cost = new Event();
            cost.PerOutCost = 5m;
            cost.OutType = OutType.APark;
            Event outing = new Event();
            outing.PerOutCost = 5m;
            outing.OutType = OutType.APark;
            Event outingTwo = new Event();
            outingTwo.PerOutCost = 5m;

            eventRepo.AddEventToList(cost);
            eventRepo.AddEventToList(outing);
            eventRepo.AddEventToList(outingTwo);

            decimal actual = eventRepo.CalculateByType(OutType.APark);
            decimal expected = 10m;

            Assert.AreEqual(expected, actual);
        }
    }
}
