using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioProposto1.Entities
{
    class UsedProduct : Product
    {
        public DateTimeOffset ManufactureDate  { get; set; }

       public UsedProduct()
        {
                    }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name,price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"Name: {Name}, (used) - R${Price}, ManufatureDate: {ManufactureDate} "; 
        }
    }
}
