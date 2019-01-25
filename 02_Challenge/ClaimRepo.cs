using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge
{
    public class ClaimRepo
    {
        Queue<Claim> _data = new Queue<Claim>();

        public void AddClaimToQueue(Claim newClaim)
        {
            _data.Enqueue(newClaim);
        }
        public void RemoveClaimFromQueue()
        {
            _data.Dequeue();
        }
        public Claim NextClaim()
        {
            Claim firstClaim = _data.Peek();
            return firstClaim;
        }
        
    }
}
