using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spo12h_Labb2
{
    public class Car : Vehicle
    {

        #region Constructors

        public Car()
        {

        }

        public Car(int noOfDoors, int noOfseats)
            : base()
        {
            this.NoOfDoors = noOfDoors;
            this.NoOfSeats = noOfseats;
        }

        #endregion

        #region Properties
        
        public int NoOfDoors { get; set; }
        public int NoOfSeats { get; set; }

        #endregion


    }
}
