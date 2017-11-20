using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_12
{
    class User : IUser, IAuthenticate
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string GetFullInfo()
        {
            string info = " User name: " + Name + "\n User Email: " + Email + "\n User Password: " + Password;
            return info;
        }        

        public void AuthenticateUser(IUser user)
        {            
            user.Name = Name;
            user.Email = Email;
            user.Password = Password;
        }
    }
}
