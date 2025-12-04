namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Booking t1 = new Booking("Rohan", "Maldives", 38000, 8, true);
            Booking t2 = new Booking("Ananya", "Jaipur", 14200, 6, false);
            Booking t3 = new Booking("Karan", "Phuket", 29500, 9, true);
            Booking t4 = new Booking("Meera", "Darjeeling", 15800, 7, false);
            Booking t5 = new Booking("Aryan", "Paris", 52000, 11, true);
            Booking t6 = new Booking("Ishita", "Goa", 13200, 5, false);
            Booking t7 = new Booking("Vihaan", "Dubai", 41000, 10, true);
            Booking t8 = new Booking("Saanvi", "Kerala", 16800, 7, false);

            List<Booking> trips = new List<Booking> { t1, t2, t3, t4, t5, t6, t7, t8 };
            var selected = trips
                .Where(p => p.Price > 10000 && p.DurationInDays > 4)
                .ToList();
            var details = selected
                .Select(p => new
                {
                    p.CustomerName,
                    p.Destination,
                    Type = p.IsInternational ? "International" : "Domestic",
                    p.Price,
                    p.DurationInDays
                })
                .ToList();
            var output = details
                .OrderBy(x => x.Type)
                .ThenBy(x => x.Price)
                .ToList();
            Console.WriteLine("Holiday Packages Summary\n");
            Console.WriteLine("Name\t\tPlace\t\tType\t\tAmount\tNights");
            Console.WriteLine("----\t\t-----\t\t----\t\t------\t------");
            foreach (var row in output)
            {
                Console.WriteLine($"{row.CustomerName}\t\t{row.Destination}\t\t{row.Type}\t\tRs.{row.Price}\t{row.DurationInDays} days");
            }
            Console.WriteLine($"\nTotal packages listed: {output.Count}");
        }
    }
}