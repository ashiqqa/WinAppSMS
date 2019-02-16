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
   public class CategoryManager
    {
        CategoryRepository _actionToDb = new CategoryRepository();

        public bool SaveData(Category category)
        {
            if (category != null)
            {
                if (category.Name == null || category.Name.Length < 3)
                {
                    throw new Exception("Category name should be more than 3 charecter!");
                }
                return _actionToDb.SaveToDb(category);
            }
            return false;
        } //Method for check data;   
        public bool UpdateData(Category category, int catId, string catName)
        {
            if (category != null)
            {
                if (category.Name == null || category.Name.Length < 3)
                {
                    throw new Exception("Name should be more than 3 charecter!");
                }
                return _actionToDb.UpdateToDb(category, catId, catName);
            }
            return false;
        } //Method for check data;  

        public bool DeleteData(int catId)
        {
            return _actionToDb.DeleteData(catId);
        }
        public DataTable GetAllCategory()
        {
            return _actionToDb.GetAllCategory();
        }
        public DataTable GetCategory(int comId)
        {
            return _actionToDb.GetCategory(comId);
        }
    }
}
