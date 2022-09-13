using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredFigures
{
    class Square : ColoredFigure
    {
        public Square(string color, int size) :
            base(color, size)
        {

        }

        public override string GetName()
        {
            return "Square";
        }

        public override double GetArea()
        {
            return size*size;
        }
    }
}
