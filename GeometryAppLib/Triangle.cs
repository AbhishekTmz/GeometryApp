public class Triangle : IShape {
    
    private double Blength;
    private double height;
    private double Length1;
    private double Length2;
    

    public Triangle(double Blength, double height, double Length1, double Length2)
    {
        this.Blength = Blength;
        this.height = height;
        this.Length2 = Length2;
        this.Length1 = Length1;
    }

    public double CalculateArea()
    {
        return 0.5 * Blength * height;
    }

    public double CalculatePerimeter()
    {
        return Blength + Length2 + Length1;
    }
}
