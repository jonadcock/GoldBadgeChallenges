using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    public class EventRepo
    {
        List<Event> listOfEvents = new List<Event>();

        public void AddEventToList(Event newOutEvent)
        {
            listOfEvents.Add(newOutEvent);
        }

      
        public List<Event> GetEventList()
        {
            return listOfEvents;
        }

        public decimal CalculateAllOutings()
        {
            decimal totalCostAll = 0m;
            foreach (Event totalCostA in listOfEvents)
            {
                totalCostAll += totalCostA.PerOutCost;
                
            }
            return totalCostAll;
        }
        public decimal CalculateByType(OutType type)
        {
            decimal totalCostType = 0m;
            foreach (Event outingType in listOfEvents)
            {
                if (outingType.OutType == type)
                    totalCostType += outingType.PerOutCost;
               
            }
            return totalCostType;
            
        }

    }
}
