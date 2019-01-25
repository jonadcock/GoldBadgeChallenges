using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Challenge
{
    public class ClaimUI
    {
        ClaimRepo _claimRepo = new ClaimRepo();
        private Queue<Claim> _claim;

        public ClaimUI()
        {
            _claimRepo = new ClaimRepo();
            _claim = _claimRepo.GetQueue();

        }

        public void Run()
        {
            bool running = true;
            while (running)
            {

                Console.WriteLine("Komodo Claims Department.\n" +
                    "Press any key to access menu");
                Console.ReadKey();

                Console.WriteLine("Choose from the following options\n" +
                    "1. Enter new claim\n" +
                    "2. See all claims\n" +
                    "3. Remove claim\n" +
                    "4. Take care of next claim");

                string input = Console.ReadLine();
                int choice = int.Parse(input);

                switch (choice)
                {
                    case 1:
                        AddClaimToQueue();
                         break;
                    case 2:
                        DisplayQueue();
                        break;
                    case 3:
                        NextClaim();
                        break;
            //        case 4:
             //           NextClaim();
              //          break;
                }

            }
        }
        private void AddClaimToQueue()
        {
            Claim newClaim = new Claim();
         

            Console.WriteLine("Enter claim ID number.");
            string newClaimAsString = Console.ReadLine();
            newClaim.ClaimID = int.Parse(newClaimAsString);

            Console.WriteLine("Select claim type:\n" +
                "1. Car\n" +
                "2. House\n" +
                "3. Theft");

            string input = Console.ReadLine();
            int claimType = int.Parse(input);

            
            switch (claimType)
            {
                default:
                case 1:
                    newClaim.ClaimType = ClaimType.Car;
                    break;
                case 2:
                    newClaim.ClaimType = ClaimType.House;
                    break;
                case 3:
                    newClaim.ClaimType = ClaimType.Theft;
                    break;
            }
            Console.WriteLine("Enter claim description.");
            Console.ReadLine();

            Console.WriteLine("Enter claim amount");
            newClaim.ClaimAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter date of incident");
            newClaim.DOIncident = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter Date of claim");
            newClaim.DOClaim = DateTime.Parse(Console.ReadLine());

            _claimRepo.AddClaimToQueue(newClaim);

        }
        private void DisplayQueue()
        {
            Queue<Claim> _claim = _claimRepo.GetQueue();

            Console.WriteLine($"ClaimID   Type   Description     Amount   DateOfAccident   DateOfClaim    IsValid");
            
                foreach (Claim newClaim in _claim)
            {
                Console.WriteLine($"{newClaim.ClaimID}        {newClaim.ClaimType}     {newClaim.Description}    {newClaim.ClaimAmount}   {newClaim.DOIncident.ToShortDateString()}     {newClaim.DOClaim.ToShortDateString()}     {newClaim.IsValid}");
            }

        }
        private void NextClaim()
        {
            Claim claim = _claimRepo.NextClaim();

            Console.WriteLine($"{claim.ClaimID} {claim.ClaimType} {claim.Description} {claim.ClaimAmount}  {claim.DOIncident.ToShortDateString()} {claim.DOClaim.ToShortDateString()}  {claim.IsValid}");

            Console.WriteLine("Would you like to work on this claim?\n" +
                "1. Yes\n" +
                "2. No\n");

            int input = int.Parse(Console.ReadLine());
            if(input == 1)
            {
                _claimRepo.RemoveClaimFromQueue();
            }

        }
        
        //private void RemoveClaimFromQueue()
        //{
        //    Console.Clear();
        //    _claimRepo.GetQueue();

        //    Console.WriteLine("Which claim would you like to remove? Enter claimID of claim to be removed.");
        //    int claim = int.Parse(Console.ReadLine());

        //    _claimRepo.RemoveClaimByData(claim);

        //    Console.WriteLine($"The {claim} was successfully removed.");
        //    Console.ReadKey();

        //    Console.Clear();
        //    Run();
        //}
        //{
        //    Console.Clear();
        //    _claimRepo.GetQueue();

        //    Console.WriteLine("Which claim would you like to remove?  Enter claim ID number and press enter.");
        //    int claimID = int.Parse(Console.ReadLine());

        //    ClaimType claimType = ClaimType.Car;
        //    string description = "any";
        //    decimal claimAmount = 0m;
        //    DateTime dOIncident = default(DateTime);
        //    DateTime dOClaim = default(DateTime);

        //    bool success = _claimRepo.RemoveClaimByData(claimID, claimType, description, claimAmount, dOIncident, dOClaim);
        //    if (success == true)
        //    {
        //        Console.WriteLine($"Claim #{claimID} has been removed.");
        //        Console.ReadKey();
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Claim #{claimID} was unable to be removed at this time.");
        //        Console.ReadKey();
        //        Console.Clear();
        //    }
        //}
    }
}
