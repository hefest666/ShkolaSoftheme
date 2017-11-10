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

            var daewo = new Car();            
            daewo = CarConstructor.Construct("Daewo Lanos", "Turbo: 1.9", "Red", 5);            
            daewo.ShowInfo();
            
            var mersedez = new Car();            
            mersedez = CarConstructor.Construct("Mersedez Benz" , "Standart: 2.5", "White", 6);
            mersedez.ShowInfo();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nMethod Reconstruct..\n");
            Console.ResetColor();

            CarConstructor.Reconstract(daewo, "Turbo: 2.9");
            daewo.ShowInfo();        

            Console.ReadKey();
        }
    }
}
