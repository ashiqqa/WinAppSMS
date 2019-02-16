using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Models;

namespace SMS.DAL
{
   public class SearchRepository
    {
        Repository _mainRepository = new Repository();

        public DataTable GetAllItem(Item item)
        {
            string query = "SELECT i.Name, com.Name Company, cat.Name Category, inv.Quantity, i.ReorderLevel FROM Items i JOIN Companies com ON com.Id = i.CompanyId JOIN Categories cat ON cat.Id = i.CategoryId  LEFT JOIN Inventories inv ON inv.ItemId = i.Id ORDER BY i.Id DESC ";
           
            if (item.CompanyId > 0 & item.CategoryId == 0)
            {
                query = "SELECT i.Name, com.Name Company, cat.Name Category, inv.Quantity, i.ReorderLevel FROM Items i JOIN Companies com ON com.Id = i.CompanyId JOIN Categories cat ON cat.Id = i.CategoryId LEFT JOIN Inventories inv ON inv.ItemId = i.Id WHERE CompanyId = '" +
                        item.CompanyId + "' ORDER BY i.Id DESC ";
            }
            else if (item.CompanyId == 0 & item.CategoryId > 0)
            {
                query = "SELECT i.Name, com.Name Company, cat.Name Category, inv.Quantity, i.ReorderLevel FROM Items i JOIN Companies com ON com.Id = i.CompanyId JOIN Categories cat ON cat.Id = i.CategoryId LEFT JOIN Inventories inv ON inv.ItemId = i.Id WHERE CategoryId = '" + item.CategoryId + "' ORDER BY i.Id DESC ";
            }
            else if(item.CompanyId>0 & item.CategoryId>0)
            {
                query = "SELECT i.Name, com.Name Company, cat.Name Category, inv.Quantity, i.ReorderLevel FROM Items i JOIN Companies com ON com.Id = i.CompanyId JOIN Categories cat ON cat.Id = i.CategoryId LEFT JOIN Inventories inv ON inv.ItemId = i.Id WHERE CompanyId = '" +
                        item.CompanyId + "' AND CategoryId = '" + item.CategoryId + "' ORDER BY i.Id DESC ";
            }
            return _mainRepository.GetAllItem(query);
        }

        public DataTable GetSellsItem(SellsDate date)
        {
            string fromDate = date.From.ToString("yyyy-MM-dd");
            string toDate = date.To.ToString("yyyy-MM-dd");
            int status = Convert.ToInt32(StatusEnum.Sale);
            string query =
                "SELECT i.Name Item, s.Quantity Sale_Quantity FROM StockOut s JOIN Items i ON i.Id = s.ItemId WHERE Status = '"+status+"' AND (Date BETWEEN '"+fromDate+"' AND '"+toDate+"') ORDER BY s.Id DESC ";
            return _mainRepository.GetAllItem(query);
        }
    }
}
