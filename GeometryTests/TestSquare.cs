namespace GeometryTests
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void Square_AreaTest()
        {
            // Arrange
            var square = new Square(5);

            // Act
            var result = square.CalculateArea();

            // Assert
            Assert.AreEqual(25, result);
        }
         public void AreaOfSquare()
        {
            // Arrange
            var square = new Square(4);

            // Act
            var result = square.CalculateArea();

            // Assert
            Assert.AreEqual(16, result);
        }
        [TestMethod]
        public void PerimeterOfSquare()
        {
            // Arrange
            var square = new Square(5);

            // Act
            var result = square.CalculatePerimeter();

            // Assert
            Assert.AreEqual(20, result);
        }
          public void Square_PerimeterTest()
        {
            // Arrange
            var square = new Square(5);

            // Act
            var result = square.CalculatePerimeter();

            // Assert
            Assert.AreEqual(20, result);
        }
    }   
}
