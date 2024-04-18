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
            
            var rectangle = new rectangle(5, 6);

            
            var result = rectangle.CalculateArea();

            
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void TestPerimeter()
        {
            
            var rectangle = new rectangle(5, 6);

           
            var result = rectangle.CalculatePerimeter();

            
            Assert.AreEqual(22, result);
        }
    }
}
