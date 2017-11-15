using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task11
{
    public class PhotoPrinter : Printer
    {
        public override void Print(string text)
        {            
            base.Print(text);
        }

        public void Print(string text, string photo)
        {           
            base.Print(text);
            Console.WriteLine("Photo: " + photo);
        }
    }
}
