using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryApp_ClassLibrary;

namespace GeometryApp_Tests
{
    [TestClass]
    public class RectangleTests
    {
        [TestMethod]
        public void TestArea()
        {
            // Arrange
            var rectangle = new rectangle(4, 6);

            // Act
            var result = rectangle.CalculateArea();

            // Assert
            Assert.AreEqual(24, result);
        }

        [TestMethod]
        public void TestPerimeter()
        {
            // Arrange
            var rectangle = new rectangle(4, 6);

            // Act
            var result = rectangle.CalculatePerimeter();

            // Assert
            Assert.AreEqual(20, result);
        }
    }
}
