using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_LV2_Čondić
{
    interface ILogger
    {
        void Log(string message);
    }
    class Logger
    {
        private string tip;
        protected string put;
        public Logger()
        {
            this.tip = "File";
            this.put = null;
        }
        public Logger(string type, string filePath)
        {
            this.tip = type;
            this.put = filePath;
        }
        public void Log(string message)
        {
            if (tip.Equals("Console"))
            Console.WriteLine(message);
            else if (tip.Equals("File"))
                using (System.IO.StreamWriter writer = new System.IO.StreamWriter(put))
                {
                    writer.WriteLine(message);
                }
            else
                throw new ArgumentException("Unknown type"); 
        }
    }
}
