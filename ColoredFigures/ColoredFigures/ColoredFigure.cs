using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColoredFigures
{
    abstract class ColoredFigure
    {
        string color;
        protected int size;

        public ColoredFigure(string color, int size)
        {
            this.color = color;
            this.size = size;
        }

        public void Show()
        {
            Console.WriteLine("Color: "+this.color);
            Console.WriteLine("Size: "+this.size);
        }

        public abstract string GetName();
        public abstract double GetArea();

    }
}
