namespace Abstract;

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * radius * radius; //Math.PI - це число ПІ (3,14)
    }

}
