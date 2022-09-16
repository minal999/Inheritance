using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            c1.Area();
            Console.WriteLine(c1);


            Rectangle r1 = new Rectangle(12, 5);
            r1.Area();
            Console.WriteLine(r1);
        }
    }
}
