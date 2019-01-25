using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Challenge
{
    public class Golf
    {
        public decimal OutTypeCost { get; set; }
        public string OutEvent { get; set; }
        public int OutAtte { get; set; }
        public int OutDate { get; set; }
        public decimal PerIndCost { get; set; }
        public decimal PerOutCost { get; set; }

        public Golf(decimal outTypeCost, string outEvent, int outAtte, int outDate, decimal perIndCost, decimal perOutCost)
        {

            OutTypeCost = outTypeCost;
            OutEvent = outEvent;
            OutAtte = outAtte;
            OutDate = outDate;
            PerIndCost = perIndCost;
            PerOutCost = perOutCost;
        }
        public Golf()
        {

        }
    }
}
