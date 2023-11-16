using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab10
{
    public class Circle : Point
    {     
        public Circle(string color, bool isVisible, double radius) : base(color, isVisible)
        {
            Radius = radius;
        }
        public double Radius { get; set; }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
