using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spo12h_Labb2
{
    public class Airplane : Vehicle
    {
        #region Constructors

        public Airplane()
            : this(0, 0)
        {

        }

        public Airplane(double length, double width)
            : base()
        {
            this.Length = length;
            this.Width = width;
        }

        public Airplane(double length, double width, string manufacturer, string fuel, int maxSpeed )
            : base(manufacturer, fuel, maxSpeed )
        {
            this.Length = length;
            this.Width = width;
        }

        #endregion

        #region Properties
        
        public double Length { get; set; }
        public double Width { get; set; }

        #endregion

        #region Methods

        public override string ToString()
        {
            string strg;
            strg = "This is an Airplane" + base.ToString() + "\nLength: " + Length + "Width: " + Width;
            return strg;
        }

        #endregion



    }
}
