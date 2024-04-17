namespace GeometryTests
{
[TestClass]
public class RectangleTest{
    [TestMethod]
    public void AreaofRect(){
        var rectangle = new Rectangle(3, 4);

            var result = rectangle.CalculateArea();

            Assert.AreEqual(12, result);
    }
    [TestMethod]
    public void AreaofRectamgle(){
        var rectangle = new Rectangle(2, 5);

            var result = rectangle.CalculateArea();

            Assert.AreEqual(10, result);
    }
    [TestMethod]
    public void PerimeterofRect(){
        var rectangle = new Rectangle(3,4);

    var result = rectangle.CalculatePerimeter();

    Assert.AreEqual(14 , result);
    }
    [TestMethod]
 public void PerimeterofRectangle(){
        var rectangle = new Rectangle(3,4);

    var result = rectangle.CalculatePerimeter();

    Assert.AreEqual(14 , result);
    }

}
}