using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Point(10, 10);
            var p2 = new Point(10, 20);
            var p3 = new Point(20, 10);
            var p4 = new Point(20, 20);

            var shape1 = new ShapeDescriptor(p1);
            var shape2 = new ShapeDescriptor(p1, p2);
            var shape3 = new ShapeDescriptor(p1, p2, p3);
            var shape4 = new ShapeDescriptor(p1, p2, p3, p4);

            Console.WriteLine("Shape: {0}", shape1.ShapeType);
            Console.WriteLine("Shape: {0}", shape2.ShapeType); 
            Console.WriteLine("Shape: {0}", shape3.ShapeType); 
            Console.WriteLine("Shape: {0}", shape4.ShapeType);           

            Console.ReadKey();
        }
    }
}
