using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Challenge
{
    public class SmartRepo
    {
        List<Smart> listOfData = new List<Smart>();


        public void AddDataToCar(Smart newCar)
        {
            listOfData.Add(newCar);
        }

        public int CalculateSpeedPen(bool input)
        {
            
            int basePenOne = 0;
            if (input == true)
            {
                basePenOne += 10;
            }
            
            return basePenOne;
        }
    
        public int CalculateLanePen(bool input)
        {
            int basePenTwo = 0;
            if (input == true)
            {
                basePenTwo += 25;
            }
           
            return basePenTwo;
            
        }


        public int CalculateStopPen(bool input)
        {
            int basePenThree = 0;
            if (input == true)
            {
                basePenThree += 7;
            }
            return basePenThree;
            
        }


        public int CalculateFollowPen(bool input)
        {
            int basePenFour = 0;
            if (input == true)
            {
                basePenFour += 500;
            }
            
            return basePenFour;
        }
  

        public int CalculatePremTotal(int speedPen, int lanePen, int stopPen, int followPen)
        {
            int basePremTotal = 10;

            basePremTotal = basePremTotal + speedPen + lanePen + stopPen + followPen;

                return basePremTotal;
        }
    }
}
