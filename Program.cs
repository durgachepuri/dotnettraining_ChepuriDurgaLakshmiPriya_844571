using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cirle
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle cir = new Circle();
            cir.r = 10;
            cir.c.x = 6;
            cir.c.y = 3;
            Console.WriteLine(cir.area() + "" + cir.c.y);      
        }
        public class Circle
        {
            public int r;
            public point c = new point();
            public double area()
            {
                return r * r * 3.14;
            }
        }
        public class point
        {
            public int x;
            public int y;
        }
    }   
}
