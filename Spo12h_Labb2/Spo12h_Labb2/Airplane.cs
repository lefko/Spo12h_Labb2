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
            : base()
        {

        }

        public Airplane(double length, double width)
            : base()
        {
            this.Length = length;
            this.Width = width;
        }

        #endregion

        #region Properties
        
        public double Length { get; set; }
        public double Width { get; set; }

        #endregion



    }
}
