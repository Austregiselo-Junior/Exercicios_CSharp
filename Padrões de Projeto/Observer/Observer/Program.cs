using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stock = new Stock("ABC", 100m); // Instancia da classe sujeito

            var display = new Display(stock);
            var logger = new Logger(stock, "stock.txt");
       
            stock.Price += 2;
            stock.Price -= 1;
            Console.ReadLine();

            //  No Main()método, criamos um objeto de estoque como sujeito e os objetos Displaye Loggercomo observadores.
        }
    }
}
