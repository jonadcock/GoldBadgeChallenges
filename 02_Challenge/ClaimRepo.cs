using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge
{
    public class ClaimRepo
    {
        private Queue<Claim> _claim = new Queue<Claim>();

        public void AddClaimToQueue(Claim newClaim)
        {

            _claim.Enqueue(newClaim);

        }
        public Queue<Claim> GetQueue()
        {
            return _claim;
        }
        public void RemoveClaimFromQueue()
        {
            _claim.Dequeue();
        }
        public Claim NextClaim()
        {
            Claim claim = _claim.Peek();
            return claim;
        }

        //public void RemoveClaimByData(int claimID)
        //{
        //    foreach(Claim claim in _claim)
        //    {
        //        if (claim.ClaimID == claimID) ;
        //        break;
        //    }
        //}

        //public bool RemoveClaimByData(int claimID, ClaimType claimType, string description, decimal claimAmount, DateTime dOIncident, DateTime dOClaim)
        //{

        //    foreach(Claim claim in _claim)
        //    {
        //        if(claim.ClaimID == claimID)
        //        {
        //            RemoveClaimFromQueue(claim);
        //            break;
        //        }
        //    }
        //}
        //    public Claim NextClaim()
        //    {
        //        Claim firstClaim = _claim.Peek();
        //        return firstClaim;
        //    }

        //}
    }
}
