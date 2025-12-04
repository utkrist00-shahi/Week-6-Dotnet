using System.Security.Cryptography.X509Certificates;

namespace Task_2
{
    internal class Program
    {
        public static void Main()
        { 
            Calculate calculate;
            calculate = Add;
            Console.WriteLine(calculate(5, 8));
            calculate = Subtract;
            Console.WriteLine(calculate(10, 4));
            Console.WriteLine(CalculateFinalPrice(2000, FestivalDiscount));
            Console.WriteLine(CalculateFinalPrice(2000, SeasonalDiscount));
            Console.WriteLine(CalculateFinalPrice(2000, NoDiscount));
            Console.WriteLine(CalculateFinalPrice(2000, (double price = 2000) => price - (price * 0.3)));
        }

        public delegate int Calculate(int x, int y);
        public static int Add(int x, int y) => x + y;
        public static int Subtract(int x, int y) => x - y;
        public delegate double DiscountStrategy(double price);
        public static double FestivalDiscount(double price) => price - (price * 0.2);
        public static double SeasonalDiscount(double price) => price - (price * 0.1);
        public static double NoDiscount(double price) => price;
        public static double CalculateFinalPrice(double OriginalPrice, DiscountStrategy discountStrategy)
        {
            return discountStrategy(OriginalPrice);
            
        }

    }

}