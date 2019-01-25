using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Challenge
{
    public class SmartUI
    {
        SmartRepo _smartRepo = new SmartRepo();

        public void Run()
        {
            bool running = true;
            while (running)
            {
                int speedPen = 0;
                int lanePen = 0;
                int stopPen = 0;
                int followPen = 0;

                Console.WriteLine("Welcome to Smart Insurance interface. Press any button to begin");
                Console.ReadKey();
                

                Console.WriteLine("Does this car exceed the speed limit?\n" +
                    "1. True\n" +
                    "2. False");

                bool input = bool.Parse(Console.ReadLine());
              

                switch (input)
                {
                    case true:
                        speedPen = _smartRepo.CalculateSpeedPen(input);
                        break;
                    case false:
                       
                         break;
                }

                Console.WriteLine("Does this car swerve out of its lane?\n" +
                    "1. True\n" +
                    "2. False");


                bool inputTwo = bool.Parse(Console.ReadLine());
                

                switch (inputTwo)
                {
                    case true:
                        lanePen = _smartRepo.CalculateLanePen(inputTwo);
                            break;
                    case false:
                            break;
                }

                Console.WriteLine("Does this car roll through stop signs?\n" +
                    "1. True\n" +
                    "2. False");

                bool inputThree = bool.Parse(Console.ReadLine());
                

                switch (inputThree)
                {
                    case true:
                        stopPen = _smartRepo.CalculateStopPen(inputThree);
                            break;
                    case false: 
                            break;
                }

                Console.WriteLine("Is this car's follow distance unsafe?\n" +
                    "1. True\n" +
                    "2. False");

                bool inputFour = bool.Parse(Console.ReadLine());
              

                switch (inputFour)
                {
                    case true:
                        followPen = _smartRepo.CalculateFollowPen(inputFour);
                            break;
                    case false: 
                            break;
                }

                Console.WriteLine("Press enter to show calculated premium");
           
                Console.ReadKey();

                int basePremTotal = _smartRepo.CalculatePremTotal(speedPen, lanePen, stopPen, followPen);



                Console.WriteLine($"The total premium for this car is {basePremTotal}");


                
            }
        }
    }
}
