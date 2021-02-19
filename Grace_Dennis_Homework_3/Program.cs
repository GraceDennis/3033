using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grace_Dennis_Homework_3
{
    class Program
    {
        static void Main(string[] args)
        { 
            Triangle tOne = new Triangle();
            tOne.EdgeA = 2;
            tOne.EdgeB = 2;
            tOne.Base = 5;
            tOne.Height = 4;

            //Circle cOne = new Circle(1); //I believe when I added Classes I somehow messed up

            Trapezoid trap1 = new Trapezoid();
            trap1.BaseA = 4;
            trap1.BaseB = 5;
            trap1.LegA = 3;
            trap1.LegB = 3;
            trap1.Height = 6;

            //Rectangle r1 = new Rectangle();
            //r1.Length = 5;
            //r1.Width = 4;

            Console.WriteLine("Polymorphism of Area and Perimeter: ");
            List<Shapes> sl = new List<Shapes>();
            sl.Add(tOne);
            //sl.Add(cOne);
            sl.Add(trap1);
            //sl;.Add(r1);

            foreach (Shapes l in sl)
            {
                Console.WriteLine(l.CalculateArea());
                Console.WriteLine(l.CalculatePerimeter());
            }

            Console.WriteLine("Polymorphism summaries: ");
            List<IShape> ishapes = new List<IShape>();
            ishapes.Add(tOne);
            //ishapes.Add(cOne);
            ishapes.Add(trap1);
            //ishapes.Add(r1);

            foreach (IShape s in ishapes)
            {
               // s.GetSummary();
            }

            Console.ReadKey();
        }
    }
}
