using System;

namespace VendingMachine.Model
{
    public class Toy : Product
    {
        public Toy(string productName, decimal price) : base(productName, price)
        {
        }

        public override string Use()
        {
            return "Have fun with the Toy!";
        }
    }
}
