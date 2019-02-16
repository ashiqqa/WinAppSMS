using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Models;

namespace SMS.DAL
{
    public class UserRepository
    {
        Repository _maiRepository = new Repository();
        public bool GetUser(User user)
        {
            string query = "SELECT Id FROM Users WHERE Name = '" + user.Name + "' AND Password = '" + user.Password +
                           "' ";
            if (_maiRepository.CheckData(query))
            {
                Utility.UserId = _maiRepository.GetValue(query);
                return true;
            }
            return false;
        }
    }
}
