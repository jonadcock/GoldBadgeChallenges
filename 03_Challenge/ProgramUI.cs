using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    public class ProgramUI
    {
        EventRepo eventRepo = new EventRepo();


        public void Run()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Komodo Outings User Interface. Press any button and choose one of the following options");
                Console.ReadKey();



                Console.WriteLine("1. Display all outings\n" +
                    "2. Add an outing\n" +
                    "3. Display total outings cost" +
                    "\n" +
                    "5. Exit\n");

                Console.ReadKey();
                Console.Clear();
                string input = Console.ReadLine();
                int choice = int.Parse(input);

                switch (choice)
                {
                    case 1:
                        DisplayAllOutings();
                        break;
                    case 2:
                        AddEventToList();
                        break;
                    case 3:
                        DisplayCostOfAll();
                        break;
                    case 4:
                        DisplayOutingCost();
                        break;
                    case 5:
                        running = false;
                        break;
                }
            }
        }
        private void DisplayAllOutings()
        {
            List<Event> listOfEvents = eventRepo.GetEventList();

            foreach (Event newEvent in listOfEvents)
            {
                Console.WriteLine($"{newEvent.OutEvent} on {newEvent.OutDate} had {newEvent.OutAtte} people in attendance. The outing cost ${newEvent.PerIndCost} per person and a total event cost of ${newEvent.PerOutCost}");

            }
            Console.ReadKey();

        }
        private void AddEventToList()
        {
            Event newOutEvent = new Event();

            Console.WriteLine("Enter the number for the type of event:\n" +
                "1. Golf\n" +
                "2. Bowling\n" +
                "3. Amusement Park\n" +
                "4. Concert");

            int outType = int.Parse(Console.ReadLine());

            switch (outType)
            {
                default:
                case 1:
                    newOutEvent.OutType = OutType.Golf;
                    Console.WriteLine("Golf Outing");
                    break;
                case 2:
                    newOutEvent.OutType = OutType.Bowling;
                    Console.WriteLine("Bowling Outing");
                    break;
                case 3:
                    newOutEvent.OutType = OutType.APark;
                    Console.WriteLine("Amusement Park Outing");
                    break;
                case 4:
                    newOutEvent.OutType = OutType.Concert;
                    Console.WriteLine("Concert Outing");
                    break;
            }

            Console.WriteLine("Enter event name");
            newOutEvent.OutEvent = Console.ReadLine();

            Console.WriteLine("How many people attended?");
            newOutEvent.OutAtte = int.Parse(Console.ReadLine());

            Console.WriteLine("What was the date of the event? Please enter date as MM/DD/YYYY");
            newOutEvent.OutDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("What was the cost per person?");
            newOutEvent.PerIndCost = decimal.Parse(Console.ReadLine());

            Console.WriteLine("What was the cost of the event?");
            newOutEvent.PerOutCost = decimal.Parse(Console.ReadLine());

            eventRepo.AddEventToList(newOutEvent);
            Run();
        }
        private void DisplayCostOfAll()
        {
            decimal costOfAll = eventRepo.CalculateAllOutings();
            Console.WriteLine($"This is the cost of all event is {costOfAll}");

        }
        private void DisplayOutingCost()
        {


            Console.WriteLine("Enter the number for the type of event:\n" +
     "1. Golf\n" +
     "2. Bowling\n" +
     "3. Amusement Park\n" +
     "4. Concert");

            int outType = int.Parse(Console.ReadLine());

            OutType type = OutType.Golf;

            switch (outType)
            {
                default:
                case 1:
                    type = OutType.Golf;
                    break;
                case 2:
                    type = OutType.Bowling;
                    break;
                case 3:
                    type = OutType.APark;
                    break;
                case 4:
                    type = OutType.Concert;
                    break;

            }
            decimal costByType = eventRepo.CalculateByType(type);
            Console.WriteLine($"Total Cost of the event: {costByType}");

        }
    }
}
