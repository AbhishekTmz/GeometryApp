namespace GeometryTests
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void Square_AreaTest()
        {
            
            var square = new Square(5);

        
            var result = square.CalculateArea();

            
            Assert.AreEqual(25, result);
        }
         public void AreaOfSquare()
        {
            
            var square = new Square(4);

            
            var result = square.CalculateArea();

            
            Assert.AreEqual(16, result);
        }
        [TestMethod]
        public void PerimeterOfSquare()
        {
            
            var square = new Square(5);

            
            var result = square.CalculatePerimeter();

            
            Assert.AreEqual(20, result);
        }
          public void Square_PerimeterTest()
        {
            
            var square = new Square(5);

           
            var result = square.CalculatePerimeter();

            
            Assert.AreEqual(20, result);
        }
    }   
}
