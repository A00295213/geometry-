// Triangle.cs
public class triangle : IShape
{
    private double x;
    private double b;
    private double c;

    public triangle(double x, double b, double c)
    {
        this.x = x;
        this.b = b;
        this.c = c;
    }

    public double CalculateArea()
    {
        
        return (x*b)/2; 
    }

    public double CalculatePerimeter()
    {
        return x + b + c;
    }
}