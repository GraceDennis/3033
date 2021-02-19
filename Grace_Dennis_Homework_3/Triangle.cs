using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grace_Dennis_Homework_3
{
    class Triangle:Shapes, IShape
    {
        public double EdgeA { get; set; }
        public double EdgeB { get; set; }
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle()
        { 
            EdgeA = 0;
            EdgeB = 0;
            Base = 0;
            Height = 0;
        }

        public Triangle(double edgeA, double edgeB, double basee, double height)
        {
            EdgeA = edgeA;
            EdgeB = edgeB;
            Base = basee;
            Height = height;
        }

        public override double CalculateArea()
        {
            double area = (0.50 * Height * Base);
            return area;
        }

        public override double CalculatePerimeter()
        {
            return (EdgeA + EdgeB + Base);
        }

        public void GetSummary()
        {
            Console.WriteLine($"This is a triangle with Edge A length of {EdgeA}, Edge B length of {EdgeB}, Base of {Base}, and Height of {Height}");
        }


    }

    internal interface IShape
    {
    }
}
