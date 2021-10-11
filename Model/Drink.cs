using System;


namespace VendingMachine.Model
{
    public class Drink : Product
    {
        public Drink(string productName, decimal price) : base(productName, price)
        {
        }

        public override string Use()
        {
            return "Enjoy your Drink!";
        }
    }
}
