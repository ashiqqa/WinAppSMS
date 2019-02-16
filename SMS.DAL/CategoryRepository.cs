using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Models;

namespace SMS.DAL
{
    public class CategoryRepository
    {
        Repository _mainRepository = new Repository();
        public bool SaveToDb(Category category)
        {
            string selectQuery = "SELECT * FROM Categories WHERE Name ='" + category.Name + "' ";
            string insertQuery = "INSERT INTO Categories (Name) VALUES('" + category.Name + "')";
            if (_mainRepository.CheckData(selectQuery))
            {
                throw new Exception(category.Name+" already exist!");
            }
            if (_mainRepository.RunQuery(insertQuery))
            {
                return true;
            }
            return false;
        } //Method for save Category;

        public bool UpdateToDb(Category category, int catId, string catName)
        {
            string select = "SELECT * FROM categories WHERE Name = '" + category.Name + "' ";
            string update = "UPDATE categories SET Name = '" + category.Name + "' WHERE Id = '"+catId+"' ";
            if (category.Name == catName)
            {
                _mainRepository.RunQuery(update);
                return true;
            }
            if (_mainRepository.CheckData(select))
            {
                throw new Exception(category.Name + " already exist!");
            }
            _mainRepository.RunQuery(update);
            return true;
        }

        public bool DeleteData(int catId)
        {
            string query = "DELETE categories WHERE Id = '" + catId + "' ";
            if (_mainRepository.RunQuery(query))
            {
                return true;
            }
            return false;
        }

        public DataTable GetAllCategory()
        {
            string select = "SELECT * From Categories ORDER BY Id DESC";
            DataTable data = _mainRepository.GetAllItem(select);
            return data;
        }
        public DataTable GetCategory(int comId)
        {
            string select = "SELECT DISTINCT i.CategoryId Id, cat.Name Name From Items i JOIN Categories cat ON cat.Id = i.CategoryId WHERE CompanyId = '"+comId+"' ";
            DataTable data = _mainRepository.GetAllItem(select);
            return data;
        }
    }
}
