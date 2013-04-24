using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spo12h_Labb2
{
    public abstract class Vehicle
    {
        private int maxSpeed;
        private string fuel;

        #region Constructors

        public Vehicle()
            : this("Manufacturer Unknown", "Fuel Unknown", 0)
        {

        }

        public Vehicle(string manufacturer, string fuel, int maxSpeed)
        {
            this.Manufacturer = manufacturer;
            this.Fuel = fuel;
            this.MaxSpeed = maxSpeed;
        }

        #endregion

        #region Properties
        
        public string Manufacturer { get; set; }
        
        public string Fuel
        {
            get { return fuel; }
            set
            {
                if (value == "petrol" || value == "diesel" || value == "hydrogen")
                {
                    fuel = value;
                }
                else
                    fuel = "No fuel given";
            }
        }
        
        public int MaxSpeed
        {
            get { return maxSpeed; }
            set
            {
                if (value >= 0)
                {
                    maxSpeed = value;
                }
                else
                {
                    maxSpeed = 0;
                }
            }
        }
        

        #endregion

        #region Methods

        public override string ToString()
        {
            string strng;
            strng = "\nManufacturer: " + Manufacturer + "\nFuel: " + Fuel + "\nMax Speed: " + MaxSpeed; 
            return strng;
        }

        #endregion

    }
}
