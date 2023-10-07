using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_SegregacaodeInterface
{
    internal class Car : IRunnable
    {
        public void Run()
        {
            Console.WriteLine("Running");
        }
    }
}
