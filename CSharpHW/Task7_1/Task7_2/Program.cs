using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var alex = new Human();
            var simon = new Human("14.01.1991", "Simon", "Pashkevich", 26);
            var simonClone = new Human("14.01.1991", "Simon", "Pashkevich", 26);

            Console.WriteLine("============================");
            alex.HumanGetInfo();
            Console.WriteLine("============================");
            simon.HumanGetInfo();
            Console.WriteLine("============================");
            simonClone.HumanGetInfo();
            Console.WriteLine("============================");

            alex.Compare(simon);
            simon.Compare(simonClone);


            //if (alex == simon)
            //{
            //    Console.WriteLine(alex.FirstName + " and " + simon.FirstName + " are indentical.");
            //}
            //else
            //{
            //    Console.WriteLine(alex.FirstName + " and " + simon.FirstName + " are NOT indentical.");
            //}

            //if (simon == simonClone)
            //{
            //    Console.WriteLine(simon.FirstName + " and " + simonClone.FirstName + " are indentical.");
            //}
            //else
            //{
            //    Console.WriteLine(simon.FirstName + " and " + simonClone.FirstName + " are NOT indentical.");
            //}

            Console.ReadKey();
        }
    }
}
