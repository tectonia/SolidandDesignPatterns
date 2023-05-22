class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle
        {
            Width = 7,
            Height = 6
        };
        Console.WriteLine(rectangle.GetArea()); //output is 42

        rectangle = new Square
        {
            Width = 7,
            Height = 6
        };
        Console.WriteLine(rectangle.GetArea()); //output is 49
    }
}

public abstract class Shape {

    public int Width { get; set; }
    public int Height { get; set; }

    public abstract int GetArea();

}

public class Rectangle : Shape
{
    public override int GetArea()
    {
        return Width * Height;
    }
}

public class Square: Shape
{
    public override int GetArea()
    {
        return Width * Width;
    }
}