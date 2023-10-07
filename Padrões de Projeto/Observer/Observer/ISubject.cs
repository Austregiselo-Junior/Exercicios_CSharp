using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal interface ISubject
    {
        void Subscrible(IObserver observer);
        void UnSubscrible(IObserver observer);
        void NotifyObserver();
    }
}
