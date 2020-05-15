using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DOOP_LV4_Čondić
{
    class RentingConsolePrinter
    {
        public void PrintTotalPrice(List<IRentable> items)
        {
            Console.WriteLine(items.Sum(r => r.CalculatePrice()));
        }
        public void DisplayItems(List<IRentable> items)
        {
            items.ForEach(r => Console.WriteLine(r.Description));
        }
    }
}