using System;
using Vending = VendingMachine.Data;

namespace VendingMachine.Model
{
    public abstract class Product : Vending.VendingMachine
    {
        public static Product[] products = new Product[] { };
        public virtual int Price { get; set; }
        public virtual string ProductName { get; set; }

        public Product(string productName, int price)
        {
            ProductName = productName;
            Price = price;
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = this;
        }
        public string Examine()
        {
            return $"--- {this.GetType().Name} Info ---\nName: {ProductName}\nPrice: {Price} ";
        }
        public abstract string Use();

        public static Product[] GetAllProducts()
        {
            return products;
        }


    }
}