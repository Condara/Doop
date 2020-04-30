using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DOOP_LV2_Čondić
{
    class FileLogger : Logger, ILogger
    {
        void ILogger.Log(string message)
        {
            if (put != null)
                using (StreamWriter writer = new StreamWriter(this.put))
                {
                    writer.WriteLine(message);
                }
                else
                throw new Exception("File path = null");
        }
    }
}