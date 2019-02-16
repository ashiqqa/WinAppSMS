using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Models;

namespace SMS.DAL
{
    public class StockOutRepository
    {
        Repository _mainRepository = new Repository();
        public void SaveToStockOut(int itemId, int quantity, int status)
        {
            string insert = "INSERT INTO StockOut (ItemId, Quantity, Status, Date, UserId) VALUES('"+itemId+"', '"+quantity+"', '"+status+"', '"+DateTime.Now.ToString("yyyy/MM/dd")+"', '"+Utility.UserId+"')";
            string select = "SELECT Quantity FROM Inventories WHERE ItemId = '" + itemId + "' ";

            int totalQuantity = _mainRepository.GetValue(select) - quantity;
            string update = "UPDATE Inventories SET Quantity = '" + totalQuantity + "' WHERE ItemId = '"+itemId+"' ";

            _mainRepository.RunQuery(insert);
            _mainRepository.RunQuery(update);
            
        }
    }
}
