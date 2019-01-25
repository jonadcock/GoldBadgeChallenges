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

        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Komodo Claims Department. Press any key to access menu");
                Console.ReadKey();

                Console.WriteLine("Choose from the following options\n" +
                    "1. Enter new claim\n" +
                    "2. See all claims\n" +
                    "3. Take care of next claim");

                int input = ParseInput();

                switch (input)
                {
                    case 1: AddCla
                         break;
                }
            }
        }
    }
}
