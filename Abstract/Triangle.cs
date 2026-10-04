namespace Abstract;

public class Triangle : Shape
{
    public double BaseLength { get; set; } // довжина основи трикутника
    public double Height { get; set; } // висота 

    public Triangle(double baseLength, double height)
    {
        BaseLength = baseLength;
        Height = height;
    }

    public override double GetArea()
    {
        return 0.5 * BaseLength * Height; //0,5 * на довжину основи * на висоту
    }
}
