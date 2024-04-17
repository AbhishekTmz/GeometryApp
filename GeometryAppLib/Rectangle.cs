public class Rectangle : IShape {
    private double length;
    private double breadth;

    public Rectangle(double length, double breadth)
    {
        this.length = length;
        this.breadth = breadth;
    }

    public double CalculateArea()
    {
        return length * breadth;
    }

    public double CalculatePerimeter()
    {
        return 2 * (length + breadth);
    }
}