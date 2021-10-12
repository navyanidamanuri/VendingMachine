using VendingMachine.Model;
using System;

namespace VendingMachine.Data
{
    public class VendingMachine : IVending
    {
        private int money = 0;
        public void EndTransaction()
        {
           if(money> product.Price)
            {
                decimal change = money - product.Price;
                Console.WriteLine($"PLease take your change ({change:C})");
            }
        }

        public void InsertMoney()
        {
            Console.WriteLine("Please input money to the vending machine");
            money = Convert.ToInt32(Console.ReadLine());
        }

        public void Purchase()
        {
            Product[] products = Product.GetAllProducts();
           
            InsertMoney();
            string choice = "Y";
            do
            {
                ShowAll(products);
                //Implement to show the list of Products
                Console.WriteLine("Select a product which you like to Buy!");
            int selectItem = Convert.ToInt32(Console.ReadLine());
            Product product = GetProductInformation(selectItem, products);
            if (product != null)
            {
                if (money >= product.Price)
                {
                    money = money - product.Price;
                    Console.WriteLine("\n===================");
                    Console.Write("Quit? (y or no): ");
                    choice = Console.ReadLine();
                    Console.WriteLine("===================\n");
                    EndTransaction();
                    product.Use();
                }
            }
            } while (choice.ToUpper() != "Y");

        }

        private Product GetProductInformation(int selectItem, Product[] products)
        {
            string productName = GetProductName(selectItem);
            foreach (var product in products)
            {
                if (product.ProductName == productName)
                {
                    return product;
                }
            }
            return null;
        }

        private string GetProductName(int selectItem)
        {
            switch (selectItem)
            {
                case 1:
                    return "Toy";
                case 2:
                    return "Food";
                case 3:
                    return "Drink";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        public void ShowAll(Product[] products)
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