using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spo12h_Labb2
{
    public class Car : Vehicle
    {

        #region Constructors

        public Car():this(0,0)
        {

        }

        public Car(int noOfDoors, int noOfseats)
            : base()
        {
            this.NoOfDoors = noOfDoors;
            this.NoOfSeats = noOfseats;
        }

        public Car(int noOfDoors, int noOfseats, string manufacturer, string fuel, int maxSpeed)
            : base(manufacturer, fuel, maxSpeed)
        {
            this.NoOfDoors = noOfDoors;
            this.NoOfSeats = noOfseats;
        }

        #endregion

        #region Properties
        
        public int NoOfDoors { get; set; }
        public int NoOfSeats { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            string strg;
            strg = "\nThis is a Car" + base.ToString() + "\nNo of Doors: " + NoOfDoors + "No of Seats: " + NoOfSeats;
            return strg;
        }
        #endregion


    }
}
