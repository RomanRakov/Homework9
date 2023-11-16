using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class Rectangle : Point
    {
        public Rectangle(string color, bool isVisible, double width, double height) : base(color, isVisible)
        {
            Width = width;
            Height = height;
        }
        public double Width { get; set; }
        public double Height { get; set; }
        public double CalculateArea()
        {
            return Width * Height;
        }
    }
}
