using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7_3
{
    class ShapeDescriptor
    {
        private int countPoints;

        public ShapeDescriptor(Point p1, Point p2, Point p3, Point p4)
        {
            countPoints = 4;
        }

        public ShapeDescriptor(Point p1, Point p2, Point p3)
        {
            countPoints = 3;
        }

        public ShapeDescriptor(Point p1, Point p2)
        {
            countPoints = 2;
        }

        public ShapeDescriptor(Point p1)
        {
            countPoints = 1;
        }

        public ShapeDescriptor()
        {
            countPoints = 0;
        }

        public string ShapeType
        {
            get
            {
                switch(countPoints)
                {
                    case 1:
                        return "Dot";                        
                    case 2:
                        return "Line";                       
                    case 3:
                        return "Triangle";                       
                    case 4:
                        return "Quadrilateral";                        

                    default: return "null";
                }              
            }
        }
    }
}
