using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_2
{
    class Human
    {
        public string BirthDay { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        readonly int Age;

        public Human()
        {           
            BirthDay = "0.0.0";
            LastName = "null";
            FirstName = "null";
            Age = 0;
        }

        public Human(string birthDay, string firstName, string lastName, int age)
        {            
            BirthDay = birthDay;
            LastName = lastName;
            FirstName = firstName;
            Age = age;
        }

        public void HumanGetInfo()
        {
            Console.WriteLine("First name: {0}", FirstName);
            Console.WriteLine("Last name: {0}", LastName);
            Console.WriteLine("Birth day: {0}", BirthDay);
            Console.WriteLine("Age: {0}", Age);
        }

        public void Compare(Human human)
        {
            if (BirthDay == human.BirthDay &&
                    FirstName == human.FirstName &&
                    LastName == human.LastName &&
                    Age == human.Age)
            {
                Console.WriteLine("{0} and {1} are indentical.", FirstName, human.FirstName);
            }
            else
            {
                Console.WriteLine("{0} and {1} are NOT indentical.", FirstName, human.FirstName);
            }             
        }

        //===========================================================================================

        public static bool operator ==(Human human, Human human1)
        {
            return (human.BirthDay == human1.BirthDay &&
                    human.FirstName == human1.FirstName &&
                    human.LastName == human1.LastName &&
                    human.Age == human1.Age);
        }

        public static bool operator !=(Human human, Human human1)
        {
            return !(human.BirthDay == human1.BirthDay &&
                     human.FirstName == human1.FirstName &&
                     human.LastName == human1.LastName &&
                     human.Age == human1.Age);
        }
    }
}
