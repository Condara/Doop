using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_LV3_Čondić
{
    class Program
    {
        static void Main(string[] args)
        {
            Dataset newDS = new Dataset("LV3.txt");
            Console.WriteLine(newDS.DatasetOutput());
            MatrixGenerator matrix = MatrixGenerator.GetInstance();
            matrix.MatrixOutput();
            Notification noticeAlert = new Notification("Autor a", "Naslov", "ALERT", DateTime.Now, Category.ALERT, ConsoleColor.DarkYellow);
            Notification noticeError = new Notification("Autor b", "Naslov", "ERROR", DateTime.Now, Category.ERROR, ConsoleColor.DarkRed);
            Notification noticeInfo = new Notification("Autor c", "Naslov", "INFO", DateTime.Now, Category.INFO, ConsoleColor.Green);
            NotificationManager noticeManager = new NotificationManager();
            noticeManager.Display(noticeAlert);
            noticeManager.Display(noticeError);
            noticeManager.Display(noticeInfo);
            NotificationBuilder builder = new NotificationBuilder();
            Director director = new Director();
            director.Construct(builder, "Autor");
            Notification noticeBuilt = builder.Build();
            noticeManager.Display(noticeBuilt);
        }
    }
}

