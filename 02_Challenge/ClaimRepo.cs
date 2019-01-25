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
        public void RemoveClaimFromQueue(Claim claim)
        {
            _claim.Dequeue();
        }

        public bool RemoveClaimByData(int claimID, ClaimType claimType, string description, decimal claimAmount, DateTime dOIncident, DateTime dOClaim)
        {
      
            foreach(Claim claim in _claim)
            {
                if(claim.ClaimID == claimID)
                {
                    RemoveClaimFromQueue(claim);
                    break;
                }
            }
        }
        public Claim NextClaim()
        {
            Claim firstClaim = _claim.Peek();
            return firstClaim;
        }
        
    }
}
