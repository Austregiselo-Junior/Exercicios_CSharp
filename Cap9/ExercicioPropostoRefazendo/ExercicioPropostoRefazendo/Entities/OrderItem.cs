namespace ExercicioPropostoRefazendo.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product product { get; set; }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            this.product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {


            return "Product name: " + product.Name + ", " + "Price: " + Price + ", " + "Quantity: " + Quantity + ", " + "Subtotal: " + "RS" + SubTotal();

        }
    }
}
