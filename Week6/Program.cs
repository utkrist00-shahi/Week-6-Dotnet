namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Rectangle rectangle = new Rectangle();
            rectangle.Length = 7.0;
            rectangle.Breadth = 8.0;
            Console.WriteLine(rectangle.ShowDetails);
            Console.WriteLine($"Perimeter of a Rectangle: {rectangle.CalculatePerimeter}");
            Console.WriteLine($"Area of a Rectangle: {rectangle.GetArea}");
        }
    }
}