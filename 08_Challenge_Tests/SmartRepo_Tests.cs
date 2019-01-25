using System;
using _08_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _08_Challenge_Tests
{
    [TestClass]
    public class SmartRepo_Tests
    {
        [TestMethod]
        public void SmartRepo_CalculateSpeedPen_ShouldBeCorrect()
        {
            SmartRepo repo = new SmartRepo();
            Smart data = new Smart("car", true, true, true, true);

            data.Speed = true;

            int actual = repo.CalculateSpeedPen(true);
            int expected = 10;


            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SmartRepo_CalculateLanePen_ShouldBeCorrect()
        {
            SmartRepo repo = new SmartRepo();
            Smart data = new Smart("car", true, true, true, true);

            data.Lane = true;

            int actual = repo.CalculateLanePen(true);
            int expected = 25;


            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SmartRepo_CalculateStopPen_ShouldBeCorrect()
        {
            SmartRepo repo = new SmartRepo();
            Smart data = new Smart("car", true, true, true, true);

            data.Stop = true;

            int actual = repo.CalculateStopPen(true);
            int expected = 7;


            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SmartRepo_CalculateFollowPen_ShouldBeCorrect()
        {
            SmartRepo repo = new SmartRepo();
            Smart data = new Smart("car", true, true, true, true);

            data.Follow = true;

            int actual = repo.CalculateFollowPen(true);
            int expected = 500;


            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SmartRepo_CalculatePremTotal_ShouldBeCorrect()
        {
            SmartRepo smartRepo = new SmartRepo();
            Smart cost = new Smart();

            smartRepo.CalculateSpeedPen(true);
            smartRepo.CalculateLanePen(true);
            smartRepo.CalculateStopPen(true);
            smartRepo.CalculateFollowPen(true);


            int expected = smartRepo.CalculatePremTotal(10, 25, 7, 500);
            int actual = 552;

            Assert.AreEqual(expected, actual);
        }

    }
}
