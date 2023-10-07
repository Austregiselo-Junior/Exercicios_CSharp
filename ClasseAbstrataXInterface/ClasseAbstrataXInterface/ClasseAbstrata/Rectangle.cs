using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrataXInterface.ClasseAbstrata
{
    internal class Rectangle : Shape
    {
        readonly double length;

        readonly double width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public override double GetArea() { return length * width; }


        public override double GetPerimeter() { return 2 * (length + width); }
        
    }
}
