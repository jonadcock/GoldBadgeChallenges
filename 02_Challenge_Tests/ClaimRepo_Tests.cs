using System;
using _02_Challenge;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _02_Challenge_Tests
{
    [TestClass]
    public class ClaimRepo_Tests
    {
        [TestMethod]
        public void ClaimRepo_AddClaimToQueue_ShouldBeCorrect()
        {
            Claim claim = new Claim();
            Claim claimTwo = new Claim();
            ClaimRepo repo = new ClaimRepo();

            repo.AddClaimToQueue(claim);
            repo.AddClaimToQueue(claimTwo);

            int actual = repo.GetQueue().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);
            
        }
        [TestMethod]
        public void RemoveClaimFromQueue()
        {
            ClaimRepo claimRepo = new ClaimRepo();
            Claim claim = new Claim();
            Claim claimTwo = new Claim();
            Claim claimThree = new Claim();

            claimRepo.AddClaimToQueue(claim);
            claimRepo.AddClaimToQueue(claimTwo);
            claimRepo.AddClaimToQueue(claimThree);

            claimRepo.RemoveClaimFromQueue();

            int actual = claimRepo.GetQueue().Count;
            int expected = 2;

            Assert.AreEqual(expected, actual);
        }
    }
}
