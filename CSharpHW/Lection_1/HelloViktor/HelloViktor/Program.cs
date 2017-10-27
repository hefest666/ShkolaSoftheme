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
            string symb = "***************";
            
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            for(int i = 0; i <= symb.Length; i++)
            {                
                Console.WriteLine(symb.Remove(symb.Length - i, i));                     
            }
                        
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
