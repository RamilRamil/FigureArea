using FigureArea;

namespace FigureArea.Tests
{
    public class TriangleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreateTriangle_ValidTriangle()
        {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            Triangle triangle = new Triangle(a, b, c);

            // Act & Assert
            // Assert
            Assert.DoesNotThrow(() => new Triangle(a, b, c));
        }

        [Test]
        public void TestCreateTriangle_NotValidTriangle()
        {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 8;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }

        [Test]
        public void TestCalculateArea_ValidTriangle()
        {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;
            Triangle triangle = new Triangle(a, b, c);  

            //Act
            double actual = triangle.CalculateArea();

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestIsRightTriangle_True()
        {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 5;
            Boolean expected = true;
            Triangle triangle = new Triangle(a, b, c);

            //Act
            Boolean actual = triangle.isRightTriangle();

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void TestIsRightTriangle_False()
        {
            //Arrange
            double a = 3;
            double b = 4;
            double c = 6;
            Boolean expected = false;
            Triangle triangle = new Triangle(a, b, c);

            //Act
            Boolean actual = triangle.isRightTriangle();

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}