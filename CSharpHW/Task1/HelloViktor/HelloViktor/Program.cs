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
            const char symb = '*';

            for(int i = 0; i <= 10; i++)
            {
                
                Console.Write(symb + " ");
                
                
                Console.WriteLine();
                
            }
            
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
