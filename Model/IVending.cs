using System.Collections.Generic;

namespace VendingMachine.Model
{
    public interface IVending
    {
        void Purchase();
        List<Product> ShowAll();
        void InsertMoney();
        void EndTransaction();
    }
}
