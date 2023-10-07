using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_SegregacaodeInterface
{
    internal class Aircraft : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("Flying");
        }

        public void Run()
        {
            Console.WriteLine("Running");
        }
    }
}
