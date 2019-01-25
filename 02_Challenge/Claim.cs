using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge
{
    public enum ClaimType { Car, House, Theft}
    public class Claim
    {

            public int ClaimID { get; set; }
            public ClaimType ClaimType { get; set; }
            public string Description { get; set; }
            public decimal ClaimAmount { get; set; }
            public DateTime DOIncident { get; set; }
            public DateTime DOClaim { get; set; }
            public bool IsValid { get; set; }

            public Claim(int claimID, ClaimType claimType, string description, decimal claimAmount, DateTime dOIncident, DateTime dOClaim)
            {
                ClaimID = claimID;
                ClaimType = claimType;
                Description = description;
                ClaimAmount = claimAmount;
                DOIncident = dOIncident;
                DOClaim = dOClaim;
                IsValid = DOClaim - DOIncident < TimeSpan.FromDays(30);
            }
            public Claim()
            {

            }

    }

}
