using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad56
{
    class zad6 : zad5
    {
        private DateTime timeStamp;

        public zad6(string author, string note, int importance, DateTime timeStamp)
        {
            this.Author = author;
            this.Note = note;
            this.Importance = importance;
            this.TimeStamp = timeStamp;
        }
        public zad6()
        {
            this.Author = "";
            this.Note = "";
            this.Importance = 0;
            this.TimeStamp = DateTime.Now;
        }

        public DateTime TimeStamp
        {
            get => timeStamp;
            set => timeStamp = value;
        }

        public override string ToString()
        {
            return base.ToString() + " Vrijeme: " + TimeStamp;
        }
    }
}
