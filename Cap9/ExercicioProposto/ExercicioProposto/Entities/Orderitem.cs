using System.Collections.Generic;
using System.Text;
namespace ExercicioProposto.Entities
{
    internal class Orderitem
    {
        public int Quantity { get; set; }
        public double  Price { get; set; }
        public Product product { get; set; }
         
        public Orderitem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            this.product = product;
        }

     public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return product.NameProduct
                + ", $"
                + Price.ToString("F2")
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2");
        }
    }
}
