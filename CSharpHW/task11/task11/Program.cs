using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    class Program
    {
        static void Main(string[] args)
        {
            var commonPrint = new Printer();
            var photoPrint = new PhotoPrinter();
            var colorPrint = new ColourPrinter();

            commonPrint.Print("COMMON PRINTER\n");
            photoPrint.Print("Photo Printer", "Mountains\n");
            colorPrint.Print("Colour Printer", ConsoleColor.Cyan);

            Console.ReadKey();
        }
    }
}
