using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task11;

namespace task11_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();

            string[] str = printer.PrintRows();
            Console.WriteLine("\nOutput: \n");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(str[i]);
            }
            Console.ReadKey();
        }
    }
}
