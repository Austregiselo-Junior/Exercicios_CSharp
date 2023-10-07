using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Display : IObserver
    {
        private readonly ISubject _subject;

        public Display(ISubject subject) 
        {
            _subject = subject;
            _subject.UnSubscrible(this);
            _subject.Subscrible(this);
        }

        public void Update(string symbol, decimal price)
        {
            Console.WriteLine($"symbol: {symbol}, price: {price}.");
        }
    }
}
