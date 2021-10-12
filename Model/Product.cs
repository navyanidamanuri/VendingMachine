using Vending = VendingMachine.Data;

namespace VendingMachine.Model
{
    public abstract class Product : Vending.VendingMachine
    {
        public virtual decimal Price { get; set; }
        public virtual string ProductName { get; set; }
        public Product[] productArray = new Product[] { };

        public Product(string productName, decimal price)
        {
            ProductName = productName;
            Price = price;
        }
        public string Examine()
        {
            return $"--- {this.GetType().Name} Info ---\nName: {ProductName}\nPrice: {Price} ";
        }
        public abstract string Use();
        
        
    }
}
