using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class User
    {
        private string firstName;
        private string lastName;
        private int age;        

        public User()
        {
            firstName = null;
            lastName = null;
            age = 0;            
        }

        public User(string fName, string lName, int ag)
        {
            firstName = fName;
            lastName = lName;
            age = ag;            
        }

        public void Clone(User user1)
        {
            firstName = user1.firstName;
            lastName = user1.lastName;
            age = user1.age;           
        }

        public void ShowInfo()
        {
            Console.WriteLine("Name: {0}\nLast Name: {1}\nAge: {2}", firstName, lastName, age);
            Console.WriteLine("---------------------");
        }
    }
}
