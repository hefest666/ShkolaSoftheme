using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_2
{
    struct Car
    {
        public string Model { get; set; }
        
        public Engine eng;
        public Transmission transm;
        public Color col;

        public void ShowInfo()
        {
            Console.WriteLine("Model: {0}", Model);
            Console.WriteLine("Engine: {0}", eng);
            Console.WriteLine("Color: {0}", col);
            Console.WriteLine("Transmission: {0}", transm);
            Console.WriteLine("---------------------");
        }
    }
}
