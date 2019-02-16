using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.DAL;
using SMS.Models;

namespace SMS.BLL
{
    public class StockInManager
    {
        StockInRepository _stockInRepository = new StockInRepository();
        public DataTable GetAllItem(int companyId)
        {
            return _stockInRepository.GetAllItem(companyId);
        }

        public string GetReorderLevel(int itemId)
        {
            return _stockInRepository.GetReorderLevel(itemId).ToString();
        }

        public string GetAvailableQuantity(int itemId)
        {
            return _stockInRepository.GetAvailableQuantity(itemId).ToString();
        }

        public bool SaveToStockIn(Stock stockIn)
        {
            if (stockIn != null)
            {
                if (stockIn.CompanyId == 0)
                {
                    throw new Exception("Select Company!");
                }
                if (stockIn.ItemId == 0)
                {
                    throw new Exception("Select Item!");
                }

                if (stockIn.Quantity == 0)
                {
                    throw new Exception("Insert quantity value!");
                }
                return _stockInRepository.SaveToStockIn(stockIn);
            }
            return false;
        }

        public bool SaveItemQuantity(int inQuantity, int itemId)
        {
           return _stockInRepository.SaveItemQuantity(inQuantity, itemId);
        }
    }
}
