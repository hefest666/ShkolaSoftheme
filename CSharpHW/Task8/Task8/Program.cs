using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Демонстрация комирования ссылочного типа.
            var us1 = new User();
            var us2 = new User("Viktor", "Pavlik", 43);

            us1.ShowInfo();
            us2.ShowInfo();

            Console.ForegroundColor = ConsoleColor.Green;            
            us1.Clone(us2);

            us1.ShowInfo();
            us2.ShowInfo();
            //Демонстрация копирования значимого типа.
            int num1 = 0;
            int num2 = 5;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Number1: {0}" ,num1);
            Console.WriteLine("Number2: {0}", num2);
            Console.WriteLine("---------------------");

            num1 = num2;           
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Number1: {0}", num1);
            Console.WriteLine("Number2: {0}", num2);
            Console.WriteLine("---------------------");


            Console.ReadKey();
        }
    }
}
