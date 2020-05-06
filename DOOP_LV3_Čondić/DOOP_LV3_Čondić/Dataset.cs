﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOOP_LV3_Čondić
{
    class Dataset : Prototype
    {
        private List<List<string>> data; 
        public Dataset()
        {
            this.data = new List<List<string>>();
        }
        public Dataset(List<List<string>> data)
        {
            this.data = data;
        }
        public Dataset(string filePath) : this()
        {
            this.LoadDataFromCSV(filePath);
        }
        public void LoadDataFromCSV(string filePath)
        {
            using (System.IO.StreamReader reader = new System.IO.StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    List<string> row = new List<string>();
                    string[] items = line.Split(',');
                    foreach (string item in items)
                    {
                        row.Add(item);
                    }
                    this.data.Add(row);
                }
            }
        }
        public IList<List<string>> GetData()
        {
           return
           new System.Collections.ObjectModel.ReadOnlyCollection<List<string>>(data);
        }
        public void ClearData()
        {
            this.data.Clear();
        }
        public Prototype ShallowClone()
        {
            return (Prototype)this.MemberwiseClone();
        }
        public string DatasetOutput()
        {
            StringBuilder builder = new StringBuilder();
            foreach (List<string> row in this.data)
            {
                foreach (string word in row)
                {
                    builder.Append(word);
                }
                builder.Append("\n\n");
            }
            string outString = builder.ToString();
            return outString;
        }
    }
}
