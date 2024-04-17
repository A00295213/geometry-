using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryApp_ClassLibrary;

namespace GeometryApp_Tests
{
    [TestClass]
    public class SquareTests
    {
        [TestMethod]
        public void TestArea()
        {
            // Arrange
            var square = new square(5);

            // Act
            var result = square.CalculateArea();

            // Assert
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void TestPerimeter()
        {
            // Arrange
            var square = new square(5);

            // Act
            var result = square.CalculatePerimeter();

            // Assert
            Assert.AreEqual(20, result);
        }
    }
}
