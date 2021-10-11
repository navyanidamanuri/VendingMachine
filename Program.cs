using System;
using VendingMachine.Model;
using Vending = VendingMachine.Data;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = InitializeProducts();
            Console.WriteLine("Welcome!");
            Console.WriteLine("Choose the option which you would like to perform!");
            Console.WriteLine("1. Show all Products");
            Console.WriteLine("2. Purchase a Product");
            Console.WriteLine("3. End Transaction");
            int option = Convert.ToInt32(Console.ReadLine());
            InitializeVendingMachine(option, products);
        }

        private static Product[] InitializeProducts()
        {
            
            Toy toy = new Toy("Toy", 150);
            Drink drink = new Drink("Drink", 15);
            Food food = new Food("Food", 100);
            Product[] products = new Product[] { toy, drink, food };
            return products;
        }

        private static void InitializeVendingMachine(int option, Product[] products)
        {
            Vending.VendingMachine vendingMachine = new Vending.VendingMachine();
            switch (option)
            {
                case 1:
                    ShowAllProducts(products);
                    break;
            }
        }

        private static void ShowAllProducts(Product[] products)
        {
            int i = 1;
            Console.WriteLine($"========================================");

            foreach (var product in products)
            {
                Console.WriteLine(product.Examine());
                Console.WriteLine($"========================================");
                i++;
            }
        }
    }
}
