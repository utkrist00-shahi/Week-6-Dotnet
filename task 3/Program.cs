namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Program program = new Program();
            int[] numbers = { 42, 23, 23, 6, 54, 18, 7, 20, 9, 1 };
            Func<int, bool> isEven = num => num % 2 == 0;
            Console.WriteLine("Even numbers:");
            program.ProcessNumbers(numbers, isEven);
            Func<int, bool> numberGreaterThan = num => num > 10;
            Console.WriteLine("\nNumbers greater than 10:");
            program.ProcessNumbers(numbers, numberGreaterThan);

        }
        public void ProcessNumbers(int[] numbers, Func<int, bool> condition)
        {
            foreach (var number in numbers)
            {
                if (condition(number))
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}