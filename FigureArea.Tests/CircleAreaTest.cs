using FigureArea;

namespace FigureArea.Tests
{
    public class CircleTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreateCircle_ValidCircle()
        {
            //Arrange
            double radius = 3;

            // Act & Assert
            // Assert
            Assert.DoesNotThrow(() => new Circle(radius));
        }

        [Test]
        public void TestCreateCircle_NotValidCircle()
        {
            //Arrange
            double radius = -3;

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Test]
        public void TestCalculateArea_ValidCircle()
        {
            //Arrange
            double radius = 3;
            double expected = 28.274;
            Circle circle = new Circle(radius);  

            //Act
            double actual = circle.CalculateArea();

            //Assert
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}