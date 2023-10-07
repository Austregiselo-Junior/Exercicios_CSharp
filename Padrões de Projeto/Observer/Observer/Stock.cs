using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class Stock : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        public string Symbol { get; set; }
        private decimal _price;
        public decimal Price
        {
            get { return _price; }
            set
            {
                if (_price != value)
                {
                    _price = value;
                    NotifyObserver();
                }
            }
        }

        public Stock(string symbol, decimal price)
        {
            Symbol = symbol;
            Price = price;
        }

        public void NotifyObserver() => _observers.ForEach(ob => ob.Update(Symbol, Price)); // Pega a lista de observadores, percorre todos eles atualizando um por um 

        public void Subscrible(IObserver observer) => _observers.Add(observer);

        public void UnSubscrible(IObserver observer) => _observers.Remove(observer);
    }
}
