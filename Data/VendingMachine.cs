using System.Collections.Generic;
using VendingMachine.Model;
using System;

namespace VendingMachine.Data
{
    public class VendingMachine : IVending
    {
        public void EndTransaction()
        {
            throw new System.NotImplementedException();
        }

        public void InsertMoney()
        {
            throw new System.NotImplementedException();
        }

        //public void Purchase(Product[] products)
        //{
        //    int selectIteam;
        //    bool selectionComplete;
        //    do
        //    {
        //        selectionComplete = false;
        //        Console.Clear();
        //        Console.WriteLine("Current Balance:" + coustmerData.moneyInserted + "$");
        //        Console.WriteLine("please input money to the vending mechine");
        //        Console.WriteLine("1)" + products[0].name + " " + products[0].cost + "$");
        //        Console.WriteLine("2)" + products[1].name + " " + products[1].cost + "$");
        //        Console.WriteLine("3)" + products[2].name + " " + products[2].cost + "$");
        //        Console.WriteLine("4)" + products[3].name + " " + products[3].cost + "$");
        //        Console.WriteLine("5)" + products[4].name + " " + products[4].cost + "$");
        //        Console.WriteLine("6) cancel");
        //        selectIteam = int.Parse(Console.ReadLine());
        //        switch (selectIteam)
        //        {
        //            case 1:
        //                if (customerData.moneyInserted >= products[0].Price)
        //                {
        //                    customerData.moneyInserted -= products[0].cost;
        //                    Console.WriteLine("product:" + produts[0].name + "has been dispenced");
        //                    Console.WriteLine("thank you your purchage");
        //                    Console.WriteLine(custmerData.moneyInserted + "has been returned");
        //                    selectionComplete = true;
        //                }
        //                else
        //                {
        //                    Console.WriteLine("insuficiant amount");
        //                    selectionComplete = false;
        //                    Console.ReadLine();
        //                }
        //                break;
        //            case 2:
        //                if (customerData.moneyInserted >= Product[1].cost)
        //                {
        //                    customerData.moneyInserted -= Product[1].cost;
        //                    Console.WriteLine("product:" + produts[1].name + "has been dispenced");
        //                    Console.WriteLine("thank you your purchage");
        //                    Console.WriteLine(custmerData.moneyInserted + "has been returned");
        //                    selectionComplete = true;
        //                }
        //                else
        //                {
        //                    Console.WriteLine("insuficiant amount");
        //                    selectionComplete = false;
        //                    Console.ReadLine();
        //                }
        //                break;
        //            case 3:
        //                if (customerData.moneyInserted >= Product[2].cost)
        //                {
        //                    customerData.moneyInserted -= Product[2].cost;
        //                    Console.WriteLine("product:" + produts[2].name + "has been dispenced");
        //                    Console.WriteLine("thank you your purchage");
        //                    Console.WriteLine(custmerData.moneyInserted + "has been returned");
        //                    selectionComplete = true;
        //                }
        //                else
        //                {
        //                    Console.WriteLine("insuficiant amount");
        //                    selectionComplete = false;
        //                    Console.ReadLine();
        //                }
        //                break;
        //            case 4:
        //                if (customerData.moneyInserted >= Product[3].cost)
        //                {
        //                    customerData.moneyInserted -= Product[3].cost;
        //                    Console.WriteLine("product:" + produts[3].name + "has been dispenced");
        //                    Console.WriteLine("thank you your purchage");
        //                    Console.WriteLine(custmerData.moneyInserted + "has been returned");
        //                    selectionComplete = true;
        //                }
        //                else
        //                {
        //                    Console.WriteLine("insuficiant amount");
        //                    selectionComplete = false;
        //                    Console.ReadLine();
        //                }
        //                break;
        //            case 5:
        //                if (customerData.moneyInserted >= Product[4].cost)
        //                {
        //                    customerData.moneyInserted -= Product[4].cost;
        //                    Console.WriteLine("product:" + produts[4].name + "has been dispenced");
        //                    Console.WriteLine("thank you your purchage");
        //                    Console.WriteLine(custmerData.moneyInserted + "has been returned");
        //                    selectionComplete = true;
        //                }
        //                else
        //                {
        //                    Console.WriteLine("insuficiant amount");
        //                    selectionComplete = false;
        //                    Console.ReadLine();
        //                }
        //                break;
        //            case 6:
        //                selectionComplete = true;
        //                Console.WriteLine("your money will be returned shortly");
        //                Console.ReadLine();
        //                break;
        //            default:
        //                Console.WriteLine("invalid produt selection!");
        //                break;

        //        }
        //    } while (selectionComplete != true);
        //}
        //public void Purchase(Product[] products)
        public void Purchage()
        {
           string choice = "Y";
            do
            {
                ShowAll();
                Console.Write("\nItem? ");
                string itemName = Console.ReadLine();

                Item item = Lookup(itemName);
                if (item != null)
                {
                    if (item.Quantity > 0)
                    {
                       Console.Write("Enter money: $");
                        decimal amountPaid = decimal.Parse(Console.ReadLine());
                      while (item.Price > amountPaid)
                        {
                            decimal totalLeft = item.Price - amountPaid;
                            Console.Write($"Enter {totalLeft:C} more: $");
                            amountPaid += decimal.Parse(Console.ReadLine());
                        }
                      Console.WriteLine($"Please take your {itemName}.");
                        if (amountPaid > item.Price)
                        {
                            decimal change = amountPaid - item.Price;
                            Console.WriteLine($"PLease take your change ({change:C})");
                        }

                        item.Quantity -= 1;

                    }
                    else
                    {
                        Console.WriteLine("Item sold out.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid item.");
                }
                Console.WriteLine("\n===================");
                Console.Write("Quit? (y or no): ");
                choice = Console.ReadLine();
                Console.WriteLine("===================\n");

            } while (choice.ToUpper() != "Y");

        }
        public Item Lookup(string itemName)
        {
            Item itemFound = null;
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Name.ToLower() == itemName.ToLower())
                {
                    itemFound = items[i];
                }
            }
            return itemFound;
        } 


        public void ShowAll()
        {
            foreach (Item item in items)
            {
                item.showall();
            }

        }
       
    }
}
