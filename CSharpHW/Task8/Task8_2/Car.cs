using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_2
{
    class Car
    {
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Color { get; set; }
        public byte Transmission { get; set; }

        public Car(string mod, string eng, string col, byte trans)
        {
            Model = mod;
            Engine = eng;
            Color = col;
            Transmission = trans;            
        }

        public Car()
        {
            Model = "null";
            Engine = "null";
            Color = "null";
            Transmission = 0;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Engine: {0}", Engine);
            Console.WriteLine("Color: {0}", Color);
            Console.WriteLine("Transmission: {0}", Transmission);
            Console.WriteLine("---------------------");
        }
    }
}
