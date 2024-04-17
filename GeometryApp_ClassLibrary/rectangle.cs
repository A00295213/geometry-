
public class rectangle : IShape
{
    private double l;
    private double w;

    public rectangle(double l, double w)
    {
        this.l = l;
        this.w = w;
    }

    public double CalculateArea()
    {
        return l * w;
    }

    public double CalculatePerimeter()
    {
        return 2 * (l + w);
    }
}
