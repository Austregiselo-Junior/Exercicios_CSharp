using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasseAbstrataXInterface.Interface
{
    internal class FileLogger : ILogger
    {
        private readonly string filePath;

        public FileLogger(string filePath)
        {
            this.filePath = filePath;
        }

        public void log(string message)
        {
            StreamWriter writer = new StreamWriter(filePath, true);
            writer.WriteLine(message);
        }
    }
}
