using Microsoft.VisualStudio.TestTools.UnitTesting;
using GeometryApp_ClassLibrary;

namespace GeometryApp_Tests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void TestArea()
        {
            
            var triangle = new triangle(4, 5 ,2);

            
            var result = triangle.CalculateArea();

            
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestPerimeter()
        {
          
            var triangle = new triangle(4, 5 ,2); 

           
            var result = triangle.CalculatePerimeter();

           
            Assert.AreEqual(12 + 4 * Math.Sqrt(2), result, 0.001); 
        }
    }
}
