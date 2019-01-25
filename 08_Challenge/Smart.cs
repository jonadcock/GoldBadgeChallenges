using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Challenge
{
    public class Smart
    {
        public string Car { get; set; }
        public bool Speed { get; set; }
        public bool Lane { get; set; }
        public bool Stop { get; set; }
        public bool Follow { get; set; }

        public Smart(string car, bool speed, bool lane, bool stop, bool follow)
        {
            Car = car;
            Speed = speed;
            Lane = lane;
            Stop = stop;
            Follow = follow;
        }
        public Smart()
        {

        }
    }
}
