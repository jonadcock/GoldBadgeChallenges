using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
 
    public enum OutType { Golf, Bowling, APark, Concert}
    public class Event
    {

        public OutType OutType { get; set; }
        public string OutEvent { get; set; }
        public int OutAtte { get; set; }
        public DateTime OutDate { get; set; }
        public decimal PerIndCost { get; set; }
        public decimal PerOutCost { get; set; }

        public Event(OutType outType, string outEvent, int outAtte, DateTime outDate, decimal perIndCost, decimal perOutCost)
        {
    
            OutType = outType;
            OutEvent = outEvent;
            OutAtte = outAtte;
            OutDate = outDate;
            PerIndCost = perIndCost;
            PerOutCost = perOutCost;
        }
        public Event()
        {

        }
    }
}
