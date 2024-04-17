namespace GeometryTests
{
    [TestClass]
    public class TriangleTest{
        [TestMethod]
        public void AreaofTri()
        {
            var triangle = new Triangle( 2, 4, 6);
            var result =triangle.CalculateArea();
            Assert.AreEqual(4 , result);
        }
         public void AreaofTriangle()
        {
            var triangle = new Triangle( 2, 8, 6);
            var result =triangle.CalculateArea();
            Assert.AreEqual(8 , result);
        }
        [TestMethod]
        public void PerimeterofTriangle()
        {
            var triangle = new Triangle( 2, 8, 6);
            var result =triangle.CalculateArea();
            Assert.AreEqual(16 , result);
        }
          public void PerimeterofTri()
        {
            var triangle = new Triangle( 2, 4, 2);
            var result =triangle.CalculateArea();
            Assert.AreEqual(8 , result);
        }
        

    }
}