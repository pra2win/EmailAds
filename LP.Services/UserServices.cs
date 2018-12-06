using Lp.Services.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LP.Services
{
    public class UserServices
    {
        /// <summary>
        /// Get user by userName/Email 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public User Get(User user)
        {
            return DataAccess.ExecuteSPGetItem<User>(DataAccess.ConnectionStrings.LandingPages, "Login", new { EmailId = user.EmailId, Password = user.Password });
        }
    }
}
