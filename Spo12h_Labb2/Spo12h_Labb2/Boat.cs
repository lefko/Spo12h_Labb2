using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spo12h_Labb2
{
    public class Boat : Vehicle
    {

        #region Constructors

        public Boat()
        {

        }

        public Boat(string model, int hP)
            : base()
        {
            this.Model = model;
            this.HP = hP;
        }

        public Boat(string model, int hP, string manufacturer, string fuel, int maxSpeed)
            : base(manufacturer, fuel, maxSpeed)
        {
            this.Model = model;
            this.HP = hP;
        }

        #endregion


        #region Properties
        
        public string Model { get; set; }
        public int HP { get; set; }

        #endregion


    }
}

 
