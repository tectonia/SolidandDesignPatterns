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

public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }

    public virtual int GetArea()
    {
        return Width * Height;
    }
}

public class Square: Rectangle
{
    public override int GetArea()
    {
        return Width * Width;
    }
}