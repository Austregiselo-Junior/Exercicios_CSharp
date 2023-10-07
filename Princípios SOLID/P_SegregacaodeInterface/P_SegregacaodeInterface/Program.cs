using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_SegregacaodeInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aircrafit");
            var aircraft = new Aircraft();
            aircraft.Run();
            aircraft.Fly();
            Console.ReadLine();

            Console.WriteLine("Car");
            var car = new Car();
            car.Run();
            Console.ReadLine();
        }
    }
}
