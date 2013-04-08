using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Spo12h_Labb2
{
    class Airplane : Vehicle
    {

        public double Length { get; set; }
        public double Width { get; set; }

        public Airplane()
        {
            
        }

        public Airplane(double length, double width):base()
        {
            this.Length = length;
            this.Width = width;
        }
    }
}
