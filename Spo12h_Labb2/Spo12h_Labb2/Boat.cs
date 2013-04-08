using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spo12h_Labb2
{
    internal class Boat : Vehicle
    {
        public string Model { get; set; }
        public int Hp { get; set; }

        public Boat()
        {
            
        }

        public Boat(string mod, int horsepower):base()
        {
            this.Model = mod;
            this.Hp = horsepower;
        }
    }
}

 
