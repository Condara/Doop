using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_LV2_Čondić
{
    class ConsoleLogger : ILogger
    {
        void ILogger.Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
