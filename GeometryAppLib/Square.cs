public class Square : IShape 
{
    private double Length;

    public Square(double Length)
    {
        this.Length = Length;
    }

    public double CalculateArea()
    {
        return  * Length;
    }

    public double CalculatePerimeter()
    {
        return 4 * Length;
    }
}
