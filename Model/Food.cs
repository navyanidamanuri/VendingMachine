using System;

namespace VendingMachine.Model
{
    public class Food : Product
    {
        public Food(string productName, decimal price) : base(productName, price)
        {
        }

        public override string Use()
        {
            return "Have a nice Meal!";
        }
    }
}
