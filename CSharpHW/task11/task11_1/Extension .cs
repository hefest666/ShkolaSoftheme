using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task11;

namespace task11_1
{
    static class Extension
    {
        public static string[] PrintRows(this Printer printer)
        {
            string[] str = new string[3];
            
            for(int i = 0; i < 3; i++)
            {
                Console.Write("Enter {0} row: ", i);
                str[i] = Console.ReadLine();
            }

            return str;
        }
    }
}
