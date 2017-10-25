using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloViktor
{
    class Program
    {
        static void Main(string[] args)
        {
            const string myName = "Viktor";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(myName);
            
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
