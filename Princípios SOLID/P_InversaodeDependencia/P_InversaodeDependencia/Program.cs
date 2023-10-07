using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_InversaodeDependencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Salvando o arquivo em data base");
            var logger = new Logger( new DataBeseService() );
            logger.Log("Hello");
            Console.ReadLine();

            Console.WriteLine("Salvando o arquivo em arquivo");
            logger = new Logger( new FileService() );
            logger.FileLog("Hello in to file");
            Console.ReadLine();

            // Dessa forma 
        }
    }
}
