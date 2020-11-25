using System;

namespace Primeiro {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Olár mundo!");
            Console.WriteLine("Olár mundo!cdcdscd");


            double a = 1, b = -3, c = -4, Delta, R1, R2;
            Delta = Math.Pow(b, 2) - 4 * a * c;
            R1 = (-b + Math.Sqrt(Delta)) / (2 * a);
            R2 = (-b - Math.Sqrt(Delta)) / (2 * a);
          

            Console.WriteLine("O delta é " + Delta + " e os resultados são " + R1 + " e " + R2);
            Console.Read();

        }

    }
}
