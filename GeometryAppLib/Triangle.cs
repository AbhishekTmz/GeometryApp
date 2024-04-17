public class Triangle : IShape {
    
    private double Blength;
    private double height;
    private double Length1;
    private double Length2;
    private double Length3;

    public Triangle(double Blength, double height, double Length1, double Length2, double Length3)
    {
        this.Blength = Blength;
        this.height = height;
        this.Length1 = Length1;
        this.Length1 = Length2;
        this.Length3 = Length3;
    }

    public double CalculateArea()
    {
        return 0.5 * Blength * height;
    }

    public double CalculatePerimeter()
    {
        return Length1 + Length2 + Length3;
    }
}
