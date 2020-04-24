using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad23
{
    class zad23
    {
        private String author;
        private String note;
        private int importance;

        public zad23(string author, string note, int importance)
        {
            this.author = author;
            this.note = note;
            this.importance = importance;
        }

        public zad23()
        {
            this.author = "";
            this.note = "";
            this.importance = 0;
        }

        public zad23(string author)
        {
            this.author = author;
            this.note = "";
            this.importance = 0;
        }

        public void setNote(string note)
        {
            this.note = note;
        }

        public void setImportance(int importance)
        {
            this.importance = importance;
        }

        public string getAuthor()
        {
            return this.author;
        }

        public string getNote()
        {
            return this.note;
        }

        public int getImportance()
        {
            return this.importance;
        }
    }
}