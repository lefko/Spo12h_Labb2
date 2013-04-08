using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spo12h_Labb2
{
    class Car : Vehicle
    {
        public int NoOfDoors { get; set; }
        public int NoOfSeats { get; set; }

        public Car()
        {
            
        }

        public Car(int numberOfDoors, int numberOfseats):base()
        {
            this.NoOfDoors = numberOfDoors;
            this.NoOfSeats = numberOfseats;
        }
    }
}
