using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DOOP_LV4_Čondić
{
    class Adapter : IAnalytics
    {
        private Analyzer3rdParty analyticsService;
        public Adapter(Analyzer3rdParty service)
        {
            this.analyticsService = service;
        }
        private double[][] ConvertData(Dataset dataset)
        {
            int rowCount = dataset.GetData().Count;
            double[][] data = new double[rowCount][];
            int rowCounter = 0;
            int colCounter = 0;
            foreach (List<double> sublist in dataset.GetData())
            {
                data[rowCounter] = new double[sublist.Count];
                foreach (double b in sublist)
                {
                    colCounter = 0;
                    data[rowCounter][colCounter] = b;
                    colCounter++;
                }
                rowCounter++;
            }
            return data;
        }
        public double[] CalculateAveragePerColumn(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerColumnAverage(data);
        }
        public double[] CalculateAveragePerRow(Dataset dataset)
        {
            double[][] data = this.ConvertData(dataset);
            return this.analyticsService.PerRowAverage(data);
        }
    }
}

