using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Method Construct..\n");
            Console.ResetColor();

            Car daewo = new Car();
            CarConstructor CC = new CarConstructor();
            
            daewo = CC.Construct("Daewo Lanos", Color.Green, Engine.Disel, Transmission.Mechanical);
            daewo.ShowInfo();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nMethod Reconstruct..\n");
            Console.ResetColor();

            daewo = CC.Reconstract(daewo, Engine.Gas);
            daewo.ShowInfo();

            Console.ReadKey();
        }
    }
}
