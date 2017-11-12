using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8_2
{
    class CarConstructor
    {                
        public Car Construct(string mod, Color col, Engine eng, Transmission tra)
        {
            Car car = new Car() {
                Model = mod,
                col = col,
                eng = eng,
                transm = tra
            };
            return car;
        }

        public Car Reconstract(Car car, Engine eng)
        {
            car.eng = eng;            
            return car;
        }
    }
}
