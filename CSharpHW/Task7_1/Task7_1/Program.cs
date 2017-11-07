using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var daewo = new Car();
            daewo.Model = "Daewo Lanos";
            daewo.Color = "Yellow";
            daewo.Year = 2008;

            Console.WriteLine("\t\tTuning atelier!");
            Console.WriteLine("\tBefore tuning:");
            Console.WriteLine("Car model: {0}", daewo.Model);
            Console.WriteLine("Car color: {0}", daewo.Color);
            Console.WriteLine("Car year: {0}", daewo.Year);

            TuningAtelier.TuneCar(daewo);
            
            Console.WriteLine("\tAfter tuning:");
            Console.WriteLine("Car model: {0}", daewo.Model);
            Console.WriteLine("Car color: {0}", daewo.Color);
            Console.WriteLine("Car year: {0}", daewo.Year);

            Console.ReadKey();
        }
    }
}
