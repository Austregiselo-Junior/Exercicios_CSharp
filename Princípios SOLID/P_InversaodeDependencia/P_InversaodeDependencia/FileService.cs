using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P_InversaodeDependencia
{
    internal class FileService : IFileService
    {
        public void SaveFile(string message)
        {
            Console.WriteLine("Save in to file");
        }
    }
}
