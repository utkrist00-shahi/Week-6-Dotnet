using System.Diagnostics.Metrics;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Cashier cashier1 = new Cashier("utkrist", "sales of a shirt", 3000);
            Cashier cashier2 = new Cashier("thakuri", "Sales of a chips", 4000);
            Cashier cashier3 = new Cashier("shahi", "Sales of a acket", 1000);
            Cashier cashier4 = new Cashier("sudan", "Sales of a motorcycyle", 9000);
            Cashier cashier5 = new Cashier("khadka", "Sales of a car", 10000);

            List<Cashier> CashierSales = [cashier1, cashier2, cashier3, cashier4, cashier5];

            var totalNumberOfCashiers = CashierSales.Count();

            var totalSalesOfTheDay = CashierSales.Sum(cashier => cashier.sale);

            var highestSales = CashierSales.Max(cashier => cashier.sale);

            var lowestSales = CashierSales.Min(cashier => cashier.sale);

            var averageSales = CashierSales.Average(cashier => cashier.sale);

            Console.WriteLine($"\nTotal Number of Cashier : {totalNumberOfCashiers}. \nTotal Sales of the Day : {totalSalesOfTheDay}. " +
                $"\nHighest Sales : {highestSales}. \nLowest Sales : {lowestSales}. \nAverage Sales : {averageSales}.");


            Applicants applicant1 = new Applicants("mark", 19);
            Applicants applicant2 = new Applicants("robers", 28);
            Applicants applicant3 = new Applicants("steve", 17);
            Applicants applicant4 = new Applicants("jobs", 32);
            Applicants applicant5 = new Applicants("muna", 44);
            Applicants applicant6 = new Applicants("madan", 26);

            List<Applicants> ApplicantsList = [applicant1, applicant2, applicant3, applicant4, applicant5, applicant6];

            var isApplicantUnder18 = ApplicantsList.Any(applicant => applicant.age <= 18);

            var isEveryApplicantAbove16 = ApplicantsList.All(applicant => applicant.age > 16);

            Console.WriteLine($"\nAre there Any Applicant under 18 ? : {isApplicantUnder18}.");
            Console.WriteLine($"\nIs All the applicants are above 16 ? : {isEveryApplicantAbove16}.\n");


            Music music1 = new Music("thunder", "8 minutes");
            Music music2 = new Music("valley hii", "2 minutes");
            Music music3 = new Music("kalo kesh", "3 minutes");
            Music music4 = new Music("Hilton", "6 minutes");
            Music music5 = new Music("Kajra rey", "3 minutes");

            List<Music> MusicList = [music1, music2, music3, music4, music5];

            var firstMusic = MusicList.First();
            var lastMusic = MusicList.Last();

            var firstMusicAbove4MinDuration = MusicList.First(music =>
            {
                var durationParts = music.songDuration.Split(' ');

                if (durationParts.Length == 2 && int.TryParse(durationParts[0], out int minute))
                {
                    return minute > 4;
                }
                return false;
            });

            var firstSongLongerThan10Min = MusicList.FirstOrDefault(
                music =>
                {
                    var durationParts = music.songDuration.Split(' ');

                    if (durationParts.Length == 2 && int.TryParse(durationParts[0], out int minute))
                    {
                        if (minute > 10)
                        {
                            return true;
                        }
                    }
                    return false;
                }
             );

            Console.WriteLine($"\nFirst Music : {firstMusic.songName}, Duration : {firstMusic.songDuration}.");
            Console.WriteLine($"\nLast Music : {lastMusic.songName}, Duration : {lastMusic.songDuration}.");
            Console.WriteLine($"\nFirst music longer than 4 minutes: {firstMusicAbove4MinDuration}");
            Console.WriteLine($"\nFirst song longer than 10 minutes: {firstSongLongerThan10Min}");

        }

    }
}