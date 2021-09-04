﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.OopsConcept
{
    class Abstraction
    { 
        
        abstract class Shape
        {
            public abstract int area();
        }

        class Rectangle : Shape
        {
            private int length;
            private int width;

            public Rectangle(int a = 0, int b = 0)
            {
                length = a;
                width = b;
            }
            public override int area()
            {
                Console.WriteLine("Rectangle class area :");
                return (width * length);
            }
        }
        class RectangleTester
        {
            static void Main(string[] args)
            {
                Rectangle r = new Rectangle(20, 15);
                double a = r.area();
                Console.WriteLine("Area: {0}", a);
                Console.ReadKey();
            }
        }
    }
}

  

