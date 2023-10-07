using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_InversaodeDependencia
{
    internal class DataBeseService : IDataService
    {
        public void Save(string message)
        {
            Console.WriteLine("Save the message into the database");
        }
    }
}
