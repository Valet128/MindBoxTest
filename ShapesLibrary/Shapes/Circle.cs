using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    public class Circle : Shape
    {
        public override string Name { get; set; } = "Круг";
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetSquare()
        {
            double square = Math.PI * Math.Pow(Radius, 2);
            return square;
        }
        
    }
}
