using Xunit;
using Shapes;
using Shapes.Shapes;

namespace UnitTests
{
    public class ShapesLibraryTests
    {
        [Fact]
        public void GetSquareCircle()
        {
            //Arrange 
            Shape circle = new Circle(5);

            //Act

            double result = circle.GetSquare();

            //Assert

            Assert.Equal(78.53981633974483, result);
        }
        [Fact]
        public void GetSquareTriangle()
        {
            //Arrange 
            Shape triangle = new Triangle(3,4,5);

            //Act

            double result = triangle.GetSquare();

            //Assert

            Assert.Equal(6, result);
        }
        [Fact]
        public void IsRectangleTriangle()
        {
            //Arrange 
            Shape triangle = new Triangle(3, 4, 5);

            //Act

            string result = triangle.Name;

            //Assert

            Assert.Equal("Треугольник прямоугольный", result);
        }

    }
}
