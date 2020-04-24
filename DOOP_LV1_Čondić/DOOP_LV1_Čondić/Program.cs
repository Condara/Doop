using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_LV1_Čondić
{
    class Program
    {
        static void Main(string[] args)
        {
            Zad23.zad23 object1 = new Zad23.zad23 ("autor", "biljeska", 4);
            Zad23.zad23 object2 = new Zad23.zad23 ("autor", "biljeska", 4);
            Zad23.zad23 object3 = new Zad23.zad23 ("autor", "biljeska", 4);

            Zad56.zad6 object4 = new Zad56.zad6("autorTime", "biljeskaTime", 5, DateTime.Now);
            Console.WriteLine(object4.ToString());
        }
    }
}