using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes.Shapes
{
    public class Triangle : Shape
    {
        public override string Name { get; set; } = "Треугольник не прямоугольный";
        private double SideA { get; set; }
        private double SideB { get; set; }
        private double SideC { get; set; }
        public bool IsRectangular { get; set; }
        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;

            double maxValue = (new double[] { a, b, c }).Max();
            double maxValueSquare = Math.Pow(maxValue, 2);

            IsRectangular = maxValueSquare + maxValueSquare == a * a + b * b + c * c;
            if (IsRectangular) Name = "Треугольник прямоугольный";
        }

        public override double GetSquare()
        {
            
            double p = (SideA + SideB + SideC) / 2;
            double square = Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
            
            return square;
        }
    }
}
