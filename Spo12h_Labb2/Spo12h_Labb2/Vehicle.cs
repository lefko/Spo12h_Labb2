using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spo12h_Labb2
{
    public abstract class Vehicle
    {
        public string Manufacturer { get; set; }
        public string Fuel { get; set; }
        public int MaxSpeed { get; set; }

        public Vehicle()
        {
            
        }

        public Vehicle(string manufacturer, string fuel, int maxSpeed)
        {
            this.Manufacturer = manufacturer;
            this.Fuel = fuel;
            this.MaxSpeed = maxSpeed;
        }

    }
}
