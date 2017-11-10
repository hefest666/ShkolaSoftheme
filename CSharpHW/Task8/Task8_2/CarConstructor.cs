using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_2
{
    static class CarConstructor
    {
        public static Car Construct(string mod, string eng, string col, byte trans)
        {
            Car c1 = new Car()
            {
                Model = mod,
                Engine = eng,
                Color = col,
                Transmission = trans
            };            

            return c1;
        }

        public static void Reconstract(Car c1, string eng)
        {
            //Car c1;

            c1.Engine = eng;

            //return c1;
        }
    }
}
