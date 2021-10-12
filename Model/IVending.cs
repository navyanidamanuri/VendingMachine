using System.Collections.Generic;

namespace VendingMachine.Model
{
    public interface IVending
    {
        void Purchase();
        void ShowAll(Product[] products);
        void InsertMoney();
        void EndTransaction();
    }
}
