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
    public class SearchManager
    {
        SearchRepository _search = new SearchRepository();

        public DataTable GetAllItem(Item item)
        {
            return _search.GetAllItem(item);
        }

        public DataTable GetSellsItem(SellsDate date)
        {
            if (date.From > date.To)
            {
                throw new Exception("Input should be like FromDate<ToDate");
            }
            return _search.GetSellsItem(date);
        }
    }
}
