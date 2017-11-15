using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    public class ColourPrinter : Printer
    {
        public override void Print(string text)
        {           
            base.Print(text);
        }

        public void Print(string text, ConsoleColor color)
        {            
            Console.ForegroundColor = color;
            base.Print(text);
        }
    }
}
