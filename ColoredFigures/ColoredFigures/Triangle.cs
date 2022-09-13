using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredFigures
{
    class Triangle : ColoredFigure
    {
        public Triangle(string color, int size)
            : base(color, size)
        {

        }

        public override string GetName()
        {
            return "Triangle";
        }

        public override double GetArea()
        {
            return (Math.Pow(size, 2) * Math.Sqrt(3)) / 2;
        }

    }
}
