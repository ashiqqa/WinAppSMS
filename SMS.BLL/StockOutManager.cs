using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SMS.DAL;
using SMS.Models;

namespace SMS.BLL
{
    public class StockOutManager
    {
        StockInRepository _stockIn = new StockInRepository();
        StockOutRepository _stockOut = new StockOutRepository();
        Stock _stock = new Stock();
        DataTable ItemTable = new DataTable();
        List<int> itemIdList = new List<int>();
        List<int> quantityList = new List<int>();

        public bool NotAvailable(int itemId)
        {
            if (_stockIn.GetAvailableQuantity(itemId) < _stockIn.GetReorderLevel(itemId))
            {
                return true;
            }
            return false;
        } //Method for compare between Reorder level and available quantity;
        
        public void CreateItemTable()
        {
            ItemTable.Columns.Add("Item", typeof(string));
            ItemTable.Columns.Add("Company", typeof(string));
            ItemTable.Columns.Add("Quantity", typeof(int));
        }
        
        public void AddItem(Item item)
        {
            if (item.CompanyId == 0)
            {
                throw new Exception("Select Company");
            }

            if (item.Id == 0)
            {
                throw  new Exception("Select Item!");
            }

            if (item.Quantity == 0)
            {
                throw new Exception("Insert quantity value!");
            }
            ItemTable.Rows.Add(item.Name, item.CompanyName, item.Quantity);
        }
        public void AddToList(Stock stock)
        {
            if (stock.ItemId == 0)
            {
                throw new Exception("Select Item!");
            }

            if (stock.Quantity == 0)
            {
                throw new Exception("Insert Item quantity");
            }
            itemIdList.Add(stock.ItemId);
            quantityList.Add(stock.Quantity);
        }

        public DataTable GetItemTable()
        {
            return ItemTable;
        }
        public void ClearItemTable(string quantity)
        {
            ItemTable.Rows.Clear();
            itemIdList.Clear();
            quantityList.Clear();
            quantity = "";
        }

        public void StockOut(int status)
        {
            int i = 0;
            foreach (int itemId in itemIdList)
            {
                for (; i < quantityList.Count;)
                {
                    _stockOut.SaveToStockOut(itemId, quantityList[i], status);
                    i++;
                    break;
                }
            }
        }
    }
}
