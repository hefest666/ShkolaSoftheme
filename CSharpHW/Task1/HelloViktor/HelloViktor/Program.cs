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
            Console.WriteLine("int MAX value: " + int.MaxValue);
            Console.WriteLine("int MIN value: " + int.MinValue + "\n");

            Console.WriteLine("double MAX value: " + double.MaxValue);
            Console.WriteLine("double MIN value: " + double.MinValue + "\n");

            Console.WriteLine("float MAX value: " + float.MaxValue);
            Console.WriteLine("float MIN value: " + float.MinValue + "\n");

            Console.WriteLine("short MAX value: " + short.MaxValue);
            Console.WriteLine("short MIN value: " + short.MinValue + "\n");

            Console.WriteLine("byte MAX value: " + byte.MaxValue);
            Console.WriteLine("byte MIN value: " + byte.MinValue + "\n");

            Console.WriteLine("long MAX value: " + long.MaxValue);
            Console.WriteLine("long MIN value: " + long.MinValue + "\n");
            Console.ReadKey();
        }
    }
}
