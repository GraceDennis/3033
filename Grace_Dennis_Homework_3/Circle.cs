﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grace_Dennis_Homework_3
{
    class Circle: Shapes, IShape
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 0;
        }
        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }
        public void GetSummary()
        {
            Console.WriteLine($"A circle with radius of {Radius}");
        }
    }

}
