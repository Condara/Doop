﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad56
{
    class zad5
    {
        private string author;
        private string note;
        private int importance;

        public string Author
        {
            get => author;
            set => author = value;
        }

        public string Note
        {
            get => note;
            set => note = value;
        }

        public int Importance
        {
            get => importance;
            set => importance = value;
        }

        public zad5(string author, string note, int importance)
        {
            this.author = author;
            this.note = note;
            this.importance = importance;
        }

        public zad5()
        {
            this.author = "";
            this.note = "";
            this.importance = 0;
        }

        public zad5(string author)
        {
            this.author = author;
            this.note = "";
            this.importance = 0;
        }
        public override string ToString()
        {
            return "Autor: " + this.author + " Biljeska: " + this.note + " Vaznosti: " + this.importance;
        }

    }
}