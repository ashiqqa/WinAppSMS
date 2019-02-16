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
   public class CompanyManager
    {
        CompanyRepository _actionToDb = new CompanyRepository();
        public bool SaveData(Company company)
        {
            if (company != null)
            {
                if (company.Name == null || company.Name.Length < 3)
                {
                    throw new Exception("Company name should be more than 3 charecter!");
                }
                return _actionToDb.SaveToDb(company);
            }
            return false;
        } //Method for check data;   
        public bool UpdateData(Company company, int companyId, string companyName)
        {
            if (company != null)
            {
                if (company.Name == null || company.Name.Length < 3)
                {
                    throw new Exception("Company name should be more than 3 charecter!");
                }
                return _actionToDb.UpdateToDb(company, companyId, companyName);
            }
            return false;
        } //Method for check data;  

        public bool DeleteData(int companyId)
        {
            return _actionToDb.DeleteData(companyId);
        }
        public DataTable GetAllCompany()
        {
            return _actionToDb.GetAllCompany();
        }
    }
}
