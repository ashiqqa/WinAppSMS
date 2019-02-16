using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.DAL;
using SMS.Models;

namespace SMS.BLL
{
    public class UserManager
    {
        UserRepository userRepository = new UserRepository();
        public bool GetUser(User user)
        {
            return userRepository.GetUser(user);
        }
    }
}
