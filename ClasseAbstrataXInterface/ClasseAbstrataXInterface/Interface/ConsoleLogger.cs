using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrataXInterface.Interface
{
    internal class ConsoleLogger : ILogger
    {
        public void log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
