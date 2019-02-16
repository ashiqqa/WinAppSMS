using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Models;

namespace SMS.DAL
{
    public class StockInRepository
    {
        Repository _mainRepository = new Repository();
        public DataTable GetAllItem(int companyId)
        {
            string select = "SELECT * FROM Items WHERE CompanyId = '"+ companyId + "' ";
           return _mainRepository.GetAllItem(select);
        } //Method for get all items of selected company;

        public int GetReorderLevel(int itemId)
        {
            string query = "SELECT ReorderLevel FROM Items WHERE Id = '" +itemId + "' ";
            return _mainRepository.GetValue(query);
        } //Method for get Reorder level;

        public int GetAvailableQuantity(int itemId)
        {
            string query = "SELECT Quantity FROM Inventories WHERE ItemId = '" + itemId + "' ";
            return _mainRepository.GetValue(query);
        } //Method for get Available Quantity;

        public bool SaveToStockIn(Stock stockIn)
        {
            string query = "INSERT INTO StockIn (ItemId, Quantity, Date, UserId) VALUES ('" + stockIn.ItemId + "', '" +
                           stockIn.Quantity + "', '"+DateTime.Now.ToString("yyyy-MM-dd")+"', '"+Utility.UserId+"')";
            if (_mainRepository.RunQuery(query))
            {
                return true;
            }
            return false;
        }

        public bool SaveItemQuantity(int inQuantity, int itemId)
        {
            string getQuantityQuery = "SELECT Quantity FROM Inventories WHERE ItemId = '" + itemId + "' ";
            string insertQuantity = "INSERT INTO Inventories (ItemId, Quantity) VALUES('"+itemId+"', '"+inQuantity+"')";
            
            if (_mainRepository.CheckData(getQuantityQuery))
            {
                int totalQuantity = _mainRepository.GetValue(getQuantityQuery) + inQuantity;
                string updateQuantity = "UPDATE Inventories SET Quantity = '" + totalQuantity + "' WHERE ItemId = '" + itemId +
                                        "' ";
                return _mainRepository.RunQuery(updateQuantity);
            }

            return _mainRepository.RunQuery(insertQuantity);
        }
    }
}
