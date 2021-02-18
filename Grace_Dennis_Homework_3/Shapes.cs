using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grace_Dennis_Homework_3
{
    abstract class Shapes
    {
        public virtual double CalculateArea()
        {
            return 0;
        }

        public abstract double CalculatePerimeter();
    }
}
