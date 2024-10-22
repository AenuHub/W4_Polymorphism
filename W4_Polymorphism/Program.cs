using W4_Polymorphism;

internal class Program
{
    private static void Main(string[] args)
    {
        Square square = new Square();
        square.Height = 20;
        square.Width = 20;
        Console.WriteLine($"The area of the square is {square.Area()}");

        Rectangle rectangle = new Rectangle();
        rectangle.Height = 20;
        rectangle.Width = 30;
        Console.WriteLine($"The area of the rectangle is {rectangle.Area()}");

        RightTriangle rightTriangle = new RightTriangle();
        rightTriangle.Height = 20;
        rightTriangle.Width = 30;
        Console.WriteLine($"The area of the right triangle is {rightTriangle.Area()}");

        Console.ReadKey();
    }
}