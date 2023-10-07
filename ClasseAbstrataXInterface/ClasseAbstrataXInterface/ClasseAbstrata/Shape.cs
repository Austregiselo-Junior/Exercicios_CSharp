using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrataXInterface.ClasseAbstrata
{
    abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();

        public void Display() => Console.WriteLine($"Area: {GetArea():F2}, Perimeter: {GetPerimeter():F2}");

    }
}
