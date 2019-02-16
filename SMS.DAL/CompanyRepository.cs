using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Models;

namespace SMS.DAL
{
    public class CompanyRepository
    {
        Repository _mainRepository = new Repository();
        public bool SaveToDb(Company company)
        {
            string selectQuery = "SELECT * FROM Companies WHERE Name ='" + company.Name + "' ";
            string insertQuery = "INSERT INTO Companies (Name) VALUES('" + company.Name + "')";
            if (_mainRepository.CheckData(selectQuery))
            {
                throw new Exception(company.Name+" already exist!");
            }
            if (_mainRepository.RunQuery(insertQuery))
            {
                return true;
            }
            return false;
        } //Method for save Category;

        public bool UpdateToDb(Company company, int companyId, string companyName)
        {
            string select = "SELECT * FROM Companies WHERE Name = '" + company.Name + "' ";
            string update = "UPDATE Companies SET Name = '" + company.Name + "' WHERE Id = '" + companyId + "' ";
            if (company.Name == companyName)
            {
                _mainRepository.RunQuery(update);
                return true;
            }
            if (_mainRepository.CheckData(select))
            {
                throw new Exception(company.Name + " already exist!");
            }
            _mainRepository.RunQuery(update);
            return true;
        }

        public bool DeleteData(int companyId)
        {
            string query = "DELETE Companies WHERE Id = '" + companyId + "' ";
            if (_mainRepository.RunQuery(query))
            {
                return true;
            }
            return false;
        }

        public DataTable GetAllCompany()
        {
            string select = "SELECT * From Companies ORDER BY Id DESC";
            DataTable data = _mainRepository.GetAllItem(select);
            return data;
        }
    }
}
