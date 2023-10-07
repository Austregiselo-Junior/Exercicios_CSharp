using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Logger : IObserver
    {
        private readonly ISubject _subject;
        private readonly string _filename;

        public Logger(ISubject subject, string filename)
        {
            _subject = subject;
            _subject.UnSubscrible(this);
            _subject.Subscrible(this);

            _filename = filename;
        }

        public void Update(string symbol, decimal price)
        {
            var streamWriter = File.AppendText(_filename);
            streamWriter.WriteLine($"{symbol}:{price}");

          
        }
    }
}
