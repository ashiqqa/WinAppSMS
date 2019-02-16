using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.DAL;
using SMS.Models;

namespace SMS.BLL
{
    public class ItemManager
    {
        ItemRepository _item = new ItemRepository();
        public bool SaveItem(Item item)
        {
            if (item != null)
            {
                if (item.CategoryId == 0)
                {
                    throw new Exception("Select Category!");
                }

                if (item.CompanyId == 0)
                {
                    throw new Exception("Select Company");
                }
                if (item.Name == null || item.Name.Length < 3)
                {
                    throw new Exception("Item name should be more than 3 charecter!");
                }
               return _item.SaveToDb(item);
            }
            return false;
        }
    }
}
