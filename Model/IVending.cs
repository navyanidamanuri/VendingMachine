using System.Collections.Generic;

namespace VendingMachine.Model
{
    public interface IVending
    {
        void Purchase();
        void ShowAll();
        void InsertMoney();
        void EndTransaction();
    }
}
