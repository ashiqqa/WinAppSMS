using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Models;

namespace SMS.DAL
{
    public class ItemRepository
    {
        Repository _mainRepository = new Repository();
        public bool SaveToDb(Item item)
        {
            string select = "SELECT * FROM Items WHERE Name = '" + item.Name + "' AND CompanyId = '"+item.CompanyId+"' ";
            string insert = "INSERT INTO Items (CategoryId, CompanyId, Name, ReorderLevel) VALUES ('"+item.CategoryId+"', '"+item.CompanyId+"', '"+item.Name+"', '"+item.ReorderLevel+"')";
            if (_mainRepository.CheckData(select))
            {
                throw new Exception(item.Name+" already exist in selected company!");
            }
            if (_mainRepository.RunQuery(insert))
            {
                return true;
            }
            return false;
        }
    }
}
