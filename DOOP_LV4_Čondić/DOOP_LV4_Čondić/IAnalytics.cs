using System;
using System.Collections.Generic;
using System.Text;

namespace DOOP_LV4_Čondić
{
    interface IAnalytics
    {
        double[] CalculateAveragePerColumn(Dataset dataset);
        double[] CalculateAveragePerRow(Dataset dataset);
    }
}
