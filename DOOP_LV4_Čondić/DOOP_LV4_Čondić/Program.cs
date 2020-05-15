using System;
using DOOP_LV4_Čondić.Fasada;
using System.Collections.Generic;

namespace DOOP_LV4_Čondić
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset csvFile = new Dataset("CSV.txt");

            Analyzer3rdParty analyzer = new Analyzer3rdParty();
            Adapter adapter = new Adapter(analyzer);
            Console.WriteLine("Prosjek redaka:");
            for (int i = 0; i < 3; i++)
                Console.WriteLine(adapter.CalculateAveragePerRow(csvFile)[i]);
            Console.WriteLine("Prosjek stupaca:");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(adapter.CalculateAveragePerColumn(csvFile)[i]);

            List<IRentable> rentList = new List<IRentable>();
            Video video = new Video("Video X");
            Book book = new Book("Knjiga X");
            rentList.Add(video);
            rentList.Add(book);

            RentingConsolePrinter printer = new RentingConsolePrinter();
            printer.DisplayItems(rentList);
            printer.PrintTotalPrice(rentList);

            HotItem hitVid = new HotItem(new Video("Video hit"));
            DiscountItem discountBook = new DiscountItem(new Book("Knjiga - discount"));
            rentList.Add(hitVid);
            rentList.Add(discountBook);
            printer.DisplayItems(rentList);
            printer.PrintTotalPrice(rentList);

            EmailValidator emailValidator = new EmailValidator(12);
            PasswordValidator passwordValidator = new PasswordValidator(6);
            String passwordToCheck = new string("MoZe123");
            String passwordToCheck2 = new string("nemoze123");
            String emailToCheck = new string("valja@valja.com");
            String emailToCheck2 = new string("nevalja@qwer@.qwert");

            Console.WriteLine("MoZe123: " + passwordValidator.IsValidPassword(passwordToCheck));
            Console.WriteLine("nemoze123: " + passwordValidator.IsValidPassword(passwordToCheck2));
            Console.WriteLine("valja@valja.com: " + emailValidator.IsValidAddress(emailToCheck));
            Console.WriteLine("nevalja@qwer@.qwert: " + emailValidator.IsValidAddress(emailToCheck2));
        }
    }
}
