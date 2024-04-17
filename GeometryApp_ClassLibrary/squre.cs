public class square : IShape
{
    private double a;

    public square(double a)
    {
        this.a = a;
    }

    public double CalculateArea()
    {
        return a * a;
    }

    public double CalculatePerimeter()
    {
        return 4 * a;
    }
}