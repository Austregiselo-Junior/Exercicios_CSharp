namespace ExercicioProposto1.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFree { get; set; }
      

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFree)
            : base(name, price)
        {
            CustomsFree = customsFree;
        }

        public override string PriceTag()
        {
            return $"Name: {Name}, Price: R${TotalPrice()} and customs fee: R${CustomsFree}";
        }

        public double TotalPrice()
        {
            return Price + CustomsFree;
        }
    }
}
