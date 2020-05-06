using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_LV3_Čondić
{
    class Logger
    {
        private static Logger instance;
        private string filePath;
        private Logger(string filePath)
        {
            this.filePath = filePath;
        }
        public static Logger GetInstance()
        {
            if (instance == null)
            {
                instance = new Logger("Logger.txt");
            }
            return instance;
        }
        public void Log(string data)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(this.filePath, append: true))
            {
                writer.WriteLine("\n\n" + data);
            }
        }
    }
}
